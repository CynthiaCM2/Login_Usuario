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
using Microsoft.EntityFrameworkCore;
using Login_Usuario.Models;


namespace Login_Usuario
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LAPTOP-FM7HKCC1; Database = Login_Usuario; Trusted_Connection=True;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void entrar_Click(object sender, EventArgs e)
        {
            string Nombre, Clave;
            Nombre = user.Text;
            Clave = pass.Text;
            SqlConnection conexion = new SqlConnection("server = LAPTOP-FM7HKCC1; Database = Login_Usuario; Trusted_Connection=True;");
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql  = "select * from usuario where user = '" + Nombre + "' AND clave = '" + Clave + "'";
            SqlCommand cmd = new SqlCommand(sql,conexion);
            SqlDataReader read = cmd.ExecuteReader();
            //"select user, pass from usuario = user '" + Nombre + "' AND pass = '" + Clave + "'";
            if (read.Read())
            {
                //this.Hide();//
                MessageBox.Show("Bienvenido" + Nombre);
            }
            else
            {
                MessageBox.Show("No existe este usuario"  + Nombre);
            }
           


        }
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Ingrese su usuario";
                user.ForeColor = Color.Black;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Ingrese su usuario")
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Ingrese su contraseña";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = false;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Ingrese su contraseña")
            {
                pass.Text = "";
                pass.ForeColor= Color.Black;
                pass.UseSystemPasswordChar = true;
            }
        }

        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
            if (!muestra.Checked == true)
            {
                pass.UseSystemPasswordChar = true;
            }
            else
            {
                pass.UseSystemPasswordChar = false;
            }

            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }

       
    }
}
