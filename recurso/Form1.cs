using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recurso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            classFunciones funciones = new classFunciones();
            // Llamar al método ConsultarRegistro
            funciones.ConsultarRegistro();
            // Mostrar el resultado en el DataGridView
            dgvDatos.DataSource = funciones.datos;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        public string Texto
        {
            get
            {
                return textBox.Text;
            }
        }

    }

}
