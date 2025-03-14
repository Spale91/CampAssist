using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampAssist
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            LoginController loginController = new LoginController();
            if(loginController.CheckCredentials(username, password))
            {
                MessageBox.Show("Uspješna prijava");
                if(loginController.checkAdmin(username))
                {
                    Hide();
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.ShowDialog();
                }
                else
                {
                    /*frmEmployee frmEmployee = new frmEmployee();
                    frmEmployee.ShowDialog();*/
                }
            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime ili lozinka");
            }
        }
    }
}
