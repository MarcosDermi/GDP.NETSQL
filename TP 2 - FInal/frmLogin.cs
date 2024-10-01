using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace TP_2___FInal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            oBEUsu = new BEUsuario();
            oBLLseg = new BLLSeguridad();
            oBLLUsuario = new BLLUsuario();
        }


        BEUsuario oBEUsu;
        BLLSeguridad oBLLseg;
        BLLUsuario oBLLUsuario;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            oBEUsu.Usuario = txtUsuario.Text;
            oBEUsu.Pass = oBLLseg.ObtenerMD5(txtContrasena.Text);


            if (oBLLUsuario.Validar(oBEUsu))
            {
                MessageBox.Show("bienvenido " + txtUsuario.Text);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }





        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

}




