using Login_Usuario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Login_Usuario
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LAPTOP-FM7HKCC1; Database = Login_Usuario; Trusted_Connection=True;");
        private void guardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }

            string sql = "insert into usuario(Nombre,Clave) values ('" + usuario2.Text + "', '" + contraseña2.Text + "')";
            SqlCommand cmd = new SqlCommand(sql,conexion);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO REGISTRADO");
                //this.Hide();//
                Form1 n1 = new Form1();
                n1.Show();

            }
            catch (SqlException ex) { MessageBox.Show("Error" + ex.ToString()); }
            

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuario2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
