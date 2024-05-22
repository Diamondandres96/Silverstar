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
    public partial class Vigilantes : Form
    {
        public Vigilantes()
        {
            InitializeComponent();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Conexion2 = "server=localhost;user=root;password=Atlas96;database=Prototipo;";
            MySqlConnection ConexionBD = new MySqlConnection(Conexion2);
            ConexionBD.Open();

            string IngresoA = "Select Nombre_Tipo,Cedula,Codigo_Ficha from Usuario join Tipo_Usuario on Usuario.codigo_tipou=Tipo_Usuario.Codigo_Tipo where Cedula=" + txtCedula.Text + ";";
            MySqlCommand Ingreso = new MySqlCommand(IngresoA, ConexionBD);
            MySqlDataReader Ingre = Ingreso.ExecuteReader();
            if (Ingre.Read()) 
            {
                panelRegistro.Visible = true;
                txtTipo_Usuario.Text = Ingre["Nombre_Tipo"].ToString();
                txtFicha.Text = Ingre["Codigo_Ficha"].ToString();
    
            
            }
            else 
            {
                MessageBox.Show("El Usuario no Registra en la Base de Datos");
                txtTipo_Usuario.Text="Visitantes";
            }
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Prototipo002central Tres = new Prototipo002central();
            this.Close();
            Tres.Show();
            
        }
    }
}
