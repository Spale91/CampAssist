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
    public partial class frmEmployeeList: Form
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            List<User> users = userController.GetUsers();
            dgvEmployeeList.DataSource = users;


            dgvEmployeeList.Columns["UserID"].Visible = false;
            dgvEmployeeList.Columns["Password"].Visible = false;
            dgvEmployeeList.Columns["RoleID"].Visible = false;
            dgvEmployeeList.Columns["Role"].Visible = false;
        }
    }
}
