using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Laboratorio203.Controllers
{
    public class HomeController : Controller
    {
        string cadenaConexion = @"Data Source=localhost;Initial Catalog=Productos;Integrated Security=True";

        public ActionResult Index()
        {
            ViewBag.MensajeConexion = ProbarConexion();
            return View();
        }

        private string ProbarConexion()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    return "Conexión exitosa a la base de datos.";
                }
            }
            catch (Exception ex)
            {
                return $"No hay conexión a la base de datos. Error: {ex.Message}";
            }
        }


        [HttpPost]
        public ActionResult Index(int? buscarId, string accion, string nombre = "", decimal precio = 0, int stock = 0)
        {
            ViewBag.MensajeConexion = ProbarConexion();


            if (!buscarId.HasValue)
            {
                ViewBag.MensajeConexion = "Error: Debe proporcionar un ID válido.";
                return View();
            }

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    try
                    {
                        con.Open();

                        if (accion == "Buscar")
                        {
                            cmd.CommandText = "SELECT * FROM Productos WHERE Id = @id";
                            cmd.Parameters.AddWithValue("@id", buscarId.Value);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    ViewBag.Id = reader["Id"];
                                    ViewBag.Nombre = reader["Nombre"];
                                    ViewBag.Precio = reader["Precio"];
                                    ViewBag.Stock = reader["Stock"];
                                    ViewBag.MensajeConexion = "Producto encontrado exitosamente.";
                                }
                                else
                                {
                                    ViewBag.MensajeConexion = $"No se encontró ningún producto con ID {buscarId.Value}.";
                                }
                            }
                        }
                        else if (accion == "Agregar")
                        {
      
                            if (string.IsNullOrWhiteSpace(nombre))
                            {
                                ViewBag.MensajeConexion = "Error: El nombre del producto es requerido.";
                                return View();
                            }

     
                            cmd.CommandText = "SELECT COUNT(*) FROM Productos WHERE Id = @id";
                            cmd.Parameters.AddWithValue("@id", buscarId.Value);
                            int existe = (int)cmd.ExecuteScalar();

                            if (existe > 0)
                            {
                                ViewBag.MensajeConexion = $"Error: Ya existe un producto con ID {buscarId.Value}.";
                                return View();
                            }

                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO Productos (Id, Nombre, Precio, Stock) VALUES (@id, @nombre, @precio, @stock)";
                            cmd.Parameters.AddWithValue("@id", buscarId.Value);
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@stock", stock);

                            int filasAfectadas = cmd.ExecuteNonQuery();
                            ViewBag.MensajeConexion = filasAfectadas > 0 ? "Producto agregado exitosamente." : "Error al agregar el producto.";
                        }
                        else if (accion == "Modificar")
                        {
                            if (string.IsNullOrWhiteSpace(nombre))
                            {
                                ViewBag.MensajeConexion = "Error: El nombre del producto es requerido.";
                                return View();
                            }

                            cmd.CommandText = "UPDATE Productos SET Nombre=@nombre, Precio=@precio, Stock=@stock WHERE Id=@id";
                            cmd.Parameters.AddWithValue("@id", buscarId.Value);
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@stock", stock);

                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                ViewBag.MensajeConexion = "Producto modificado exitosamente.";
            
                                ViewBag.Id = buscarId.Value;
                                ViewBag.Nombre = nombre;
                                ViewBag.Precio = precio;
                                ViewBag.Stock = stock;
                            }
                            else
                            {
                                ViewBag.MensajeConexion = $"No se encontró ningún producto con ID {buscarId.Value} para modificar.";
                            }
                        }
                        else if (accion == "Eliminar")
                        {
                            cmd.CommandText = "DELETE FROM Productos WHERE Id=@id";
                            cmd.Parameters.AddWithValue("@id", buscarId.Value);

                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                ViewBag.MensajeConexion = "Producto eliminado exitosamente.";

                                ViewBag.Id = null;
                                ViewBag.Nombre = null;
                                ViewBag.Precio = null;
                                ViewBag.Stock = null;
                            }
                            else
                            {
                                ViewBag.MensajeConexion = $"No se encontró ningún producto con ID {buscarId.Value} para eliminar.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.MensajeConexion = $"Error al ejecutar la operación: {ex.Message}";
                    }
                }
            }

            return View();
        }
    }
}
