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
    public partial class frmAdmin: Form
    {
        User user;
        public frmAdmin(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnTypeList_Click(object sender, EventArgs e)
        {
            Hide();
            frmTypeList frmTypeList = new frmTypeList();
            frmTypeList.ShowDialog();
        }

        private void btnAccommodationUnits_Click(object sender, EventArgs e)
        {
            Hide();
            frmAccommodationUnitList frmAccommodationUnitList = new frmAccommodationUnitList();
            frmAccommodationUnitList.ShowDialog();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Hide();
            frmNewReservation frmNewReservation = new frmNewReservation();
            frmNewReservation.ShowDialog();
        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {
            Hide();
            frmAccommodationUnitGuestList frmAccommodationUnitGuestList = new frmAccommodationUnitGuestList();
            frmAccommodationUnitGuestList.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Hide();
            frmEmployeeList frmEmployeeList = new frmEmployeeList();
            frmEmployeeList.ShowDialog();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblUser.Text = user.FullName();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Hide();
            frmStats frmStats = new frmStats();
            frmStats.ShowDialog();
        }
    }
}
