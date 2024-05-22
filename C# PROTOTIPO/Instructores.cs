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
    public partial class Instructores : Form
    {
        public Instructores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Prototipo002central Tres = new Prototipo002central();
            this.Close();
            Tres.Show();
        }

        private void Instructores_Load(object sender, EventArgs e)
        {
            string Conexion2 = "server=localhost;user=root;password=Atlas96;database=Prototipo;";
            MySqlConnection ConexionBD = new MySqlConnection(Conexion2);
            ConexionBD.Open();
            string BFicha = "select Codigo_Ficha from Usuario;";
            MySqlCommand Telv = new MySqlCommand(BFicha, ConexionBD);
            MySqlDataReader T = Telv.ExecuteReader();
            if (T.Read())
            {
                cmbFicha.Items.Add(T["Codigo_Ficha"].ToString());
            }
            


            /*string Registro = "Select Codigo_u,Fecha from Registro join Usuario on Usuario.codigo_usuario = Registro.Codigo_u join Ficha on Usuario.Codigo_ficha = Ficha.Codigo_f where Codigo_ficha = " + cmbFicha.Text + ";";
             MySqlCommand Regi = new MySqlCommand(Registro, ConexionBD);
             MySqlDataReader R = Regi.ExecuteReader();*/


        }

        private void cmbFicha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Conexion2 = "server=localhost;user=root;password=Atlas96;database=Prototipo;";
            MySqlConnection ConexionBD = new MySqlConnection(Conexion2);
            ConexionBD.Open();
            string Comando = "select Nombre_usuario,Cedula from Usuario ;";
            MySqlCommand C = new MySqlCommand(Comando, ConexionBD);
            MySqlDataAdapter com = new MySqlDataAdapter();
            com.SelectCommand = C;
            DataTable Tabla = new DataTable();
            com.Fill(Tabla);
            DGAprendices.DataSource = Tabla;



        }

    }
}
