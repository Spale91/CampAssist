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
    public partial class frmRegister: Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            RoleController roleController = new RoleController();   
            var roles = roleController.GetRoles();
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "RoleName";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Role role = (Role)cboRole.SelectedItem;

            RegisterController registerController = new RegisterController();
            if(registerController.Register(name, surname, username, password, role.RoleID))
            {
                MessageBox.Show("Uspješna registracija");
                if(role.RoleName == "Admin")
                {
                    FrmStart frmStart = new FrmStart();
                    frmStart.ShowDialog();
                }
                if(role.RoleName == "Zaposlenik")
                {
                    /*frmEmployee frmEmployee == new frmEmployee();
                    frmEmployee.ShowDialog();
                    Close();*/
                }
            }
            else
            {
                MessageBox.Show("Korisničko ime već postoji");
            }
            Close();
        }
    }
}
