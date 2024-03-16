using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void guardar_Click(object sender, EventArgs e)
        {
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

            string sql = "insert into users(user,pass) values ('" + n_user.Text + "', '" + n_pass.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO REGISTRADO");
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();

            }
            catch (MySqlException ex) { MessageBox.Show("Error" + ex.ToString()); }
            

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
