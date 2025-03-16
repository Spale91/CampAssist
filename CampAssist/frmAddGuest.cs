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
    public partial class frmAddGuest: Form
    {
        public frmAddGuest()
        {
            InitializeComponent();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            DateTime birthDate = dtpBirthDate.Value;
            int OIB = (int)numOIB.Value;

            GuestController guestController = new GuestController();
            if(guestController.AddGuest(name,surname, birthDate, OIB))
            {
                Close();
                MessageBox.Show("Gost uspješno dodan!");

            }
            else
            {
                Close();
                MessageBox.Show("Gost već postoji!");
            }
        }
    }
}
