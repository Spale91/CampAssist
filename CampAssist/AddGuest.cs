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
    public partial class AddGuest: Form
    {
        public AddGuest()
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
            if(guestController.AddGuest(name, surname, birthDate, OIB))
            {
                MessageBox.Show("Novi gost je uspješno dodan");
                Close();
            }
            else
            {
                MessageBox.Show("Gost već postoji");
                Close();
            }
        }
    }
}
