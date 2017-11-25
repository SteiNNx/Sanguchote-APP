using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;


namespace Vista
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
            CL_Usuario user = null;
            user = serv.Login(txt_user.Text,txt_contraseña.Text);

            if (user!=null)
            {
                this.Hide();
                frm_Home home = new frm_Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
