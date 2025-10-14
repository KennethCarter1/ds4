using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=Northwind;TrustServerCertificate=True;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

            string query = "SELECT ProductName FROM Products";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;

            try
            {
                reader = comando.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    listBox1.Items.Add(productName);
                }

                MessageBox.Show($"Se cargaron {listBox1.Items.Count} productos en el ListBox.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
            finally
            {
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }


            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
