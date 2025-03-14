﻿using System;
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
        public frmAdmin()
        {
            InitializeComponent();
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
    }
}
