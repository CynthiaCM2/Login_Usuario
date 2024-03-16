using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = user.Text;
            contraseña = pass.Text;
            MySqlConnection con = new MySqlConnection("server = LAPTOP-FM7HKCC1; Database = SC_Tienda");
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "select user,pass from users where user = '" + nombre + "' AND pass = '" + contraseña + "' ";
            MySqlCommand cmd  = new MySqlCommand(sql,con);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + nombre);
            }
            else
            {
                MessageBox.Show("No existe ese usuario " + nombre);
            }

        }

        private void cerrar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
