using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseForms.Formularios
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            comboBoxFacultades.Items.Add("Ingenieria");
            comboBoxFacultades.Items.Add("Medicina");
            comboBoxFacultades.Items.Add("Derecho");


            int n1 = Int32.Parse(textBoxNumero1.Text);
            int n2 = Int32.Parse(textBoxNumero2.Text);
            int resultado = n1 + n2;
            textBoxResultado.Text = resultado.ToString();
        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFacultades.SelectedItem.ToString());
        }
    }
}
