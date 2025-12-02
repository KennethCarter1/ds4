using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Parcial_3
{
    public partial class Default : System.Web.UI.Page
    {
        string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           
           using (SqlConnection conn = new SqlConnection(connString))
           {
              SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM KC_Casos", conn);
              DataTable dt = new DataTable();
              data.Fill(dt);
              gvCasos.DataSource = dt;
              gvCasos.DataBind();
           }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO KC_Casos (CasoNombre, FechaInicio, FechaVencimiento, AbogadoAsignado, NombreCliente, EstadoCaso, DescripcionCaso) VALUES (@CasoNombre, @FechaInicio, @FechaVencimiento, @AbogadoAsignado, @NombreCliente, @EstadoCaso, @DescripcionCaso)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CasoNombre", txtCasoNombre.Text);
                cmd.Parameters.AddWithValue("@FechaInicio", txtFechaInicio.Text);
                cmd.Parameters.AddWithValue("@FechaVencimiento", txtFechaVencimiento.Text);
                cmd.Parameters.AddWithValue("@AbogadoAsignado", txtAbogado.Text);
                cmd.Parameters.AddWithValue("@NombreCliente", txtCliente.Text);
                cmd.Parameters.AddWithValue("@EstadoCaso", Estado.SelectedValue);
                cmd.Parameters.AddWithValue("@DescripcionCaso", txtDescripcion.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            txtCasoNombre.Text = "";
            txtFechaInicio.Text = "";
            txtFechaVencimiento.Text = "";
            txtAbogado.Text = "";
            txtCliente.Text = "";
            Estado.SelectedIndex = 0;
            txtDescripcion.Text = "";


            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM KC_Casos", conn);
                DataTable dt = new DataTable();
                data.Fill(dt);
                gvCasos.DataSource = dt;
                gvCasos.DataBind();
            }
        }

        protected void BtnEliminarCaso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCasoNombre.Text))
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();


                    string queryDelete = "DELETE FROM KC_Casos WHERE CasoNombre = @CasoNombre";
                    SqlCommand cmd = new SqlCommand(queryDelete, conn);
                    cmd.Parameters.AddWithValue("@CasoNombre", txtCasoNombre.Text.Trim());
                    cmd.ExecuteNonQuery();


                    txtCasoNombre.Text = "";
                    txtFechaInicio.Text = "";
                    txtFechaVencimiento.Text = "";
                    txtAbogado.Text = "";
                    txtCliente.Text = "";
                    Estado.SelectedIndex = 0;
                    txtDescripcion.Text = "";

    
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KC_Casos", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvCasos.DataSource = dt;
                    gvCasos.DataBind();
                }
            }
        }


        protected void btnBuscarCaso_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
 
                string query = @"SELECT * FROM KC_Casos WHERE CasoNombre LIKE '%' + @CasoNombre + '%'";

                SqlDataAdapter data = new SqlDataAdapter(query, conn);
                data.SelectCommand.Parameters.AddWithValue("@CasoNombre", txtCasoNombre.Text.Trim());

                DataTable dt = new DataTable();
                data.Fill(dt);

                gvCasos.DataSource = dt;
                gvCasos.DataBind();
            }
        }

    }
}
