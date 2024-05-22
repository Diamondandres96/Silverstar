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

namespace Prototipo002
{
    public partial class Prototipo002central : Form
    {
        public Prototipo002central()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Conexion = "server=localhost;user=root;password=Atlas96;database=Prototipo;";
            MySqlConnection ConexionBD = new MySqlConnection(Conexion);
            
            try
            {
                ConexionBD.Open();
                //string IngresoBusqueda = "select codigo_Usuario, codigo_tipou ,Codigo_Tipo from Usuario join Tipo_Usuario on Tipo_Usuario.Codigo_Tipo = Usuario.codigo_tipou where Codigo_Usuario=" + txtCodigo.Text +";"; 
                //MySqlCommand Ingreso = new MySqlCommand(IngresoBusqueda, ConexionBD);
               // MySqlDataReader I = Ingreso.ExecuteReader();
                string llenar = "Select codigo_tipou from Usuario where Codigo_Usuario=" + txtCodigo.Text + ";";
                MySqlCommand llenar2 = new MySqlCommand(llenar, ConexionBD);
                MySqlDataReader ll = llenar2.ExecuteReader();
                if(ll.Read())
                {
                    Prueba.Text = ll["codigo_tipou"].ToString();
                    if (Prueba.Text =="3")
                    {
                        MessageBox.Show("Bienvenido Instructor");
                        Instructores uno = new Instructores();
                        
                        uno.Visible=true;
                        this.Visible = false;
                    }
                    if(Prueba.Text=="2")
                    {
                        MessageBox.Show("Bienvenido");
                        Vigilantes dos = new Vigilantes();
                        
                        dos.Visible = true;
                        this.Visible = false;

                    }
                }
                
            
            }
            catch
            {
                MessageBox.Show("El Usuario no esta en la Base de Datos"); 
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    
}



