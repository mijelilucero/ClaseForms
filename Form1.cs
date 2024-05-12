using ClaseForms.Formularios;

namespace ClaseForms
{
    public partial class Form1 : Form
    {

        int intentosfallidos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido!!!");
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsr.Text.ToLower();
            string contra = textBoxPwd.Text.ToLower();

            if (usuario.Equals("admin") && contra.Equals("admin"))
            {
                FrmIngreso forma = new FrmIngreso();
                forma.Show();
            }
            else
            {
                intentosfallidos++;

                if (intentosfallidos == 3)
                {
                    MessageBox.Show("Has realizado más de tres intentos de ingreso.");
                    buttonIngreso.Enabled = false;
                    textBoxUsr.Text = "";
                    textBoxPwd.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto.");
                    textBoxUsr.Text = "";
                    textBoxPwd.Text = "";
                }
            }
        }

        //private void btInicio_Click(object sender, EventArgs e)
        //{
        //    lblTitulo.Text = "Bienvenido a mi App";
        //    FrmIngreso forma =new FrmIngreso();
        //    forma.Show();
        //}
    }
}
