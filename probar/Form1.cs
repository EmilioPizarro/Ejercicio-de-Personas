using probar.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtId.Text = "1";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = txtDni.Text.Trim();

            Persona p = new Persona(id, nombre, apellido, dni);

            dtgPersonas.Rows.Add(p.Id,p.Nombre, p.Apellido, p.Dni);

            //Aumentar el identificador de forma automatica con cada carga de persona 
            id ++;

            txtId.Text = id.ToString();


            LimpiarCampos();

            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Cargar persona en la lista de objetos persona
            List<Persona> list = new List<Persona>();
            for (int i = 0; i < dtgPersonas.Rows.Count; i++)
            {
                Persona per = new Persona();
                per.Id = int.Parse(dtgPersonas.Rows[i].Cells[0].Value.ToString());
                per.Nombre = dtgPersonas.Rows[i].Cells[1].Value.ToString();
                per.Apellido = dtgPersonas.Rows[i].Cells[2].Value.ToString();
                per.Dni = dtgPersonas.Rows[i].Cells[3].Value.ToString();
                list.Add(per);
            }

            //Iterar sobre la lista para mostrar el contendio (Salida es un funcion del objeto persona)

            foreach (var item in list)
            {
               MessageBox.Show (item.Salida());
            }



        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
        
        
        }
    }
}
