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
    public partial class frmGuestList: Form
    {
        public frmGuestList()
        {
            InitializeComponent();
        }

        private void frmGuestList_Load(object sender, EventArgs e)
        {
            GuestController guestController = new GuestController();
            List<Guest> getOldGuests = guestController.GetOldGuests();
            dgvGuestList.DataSource = getOldGuests;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            Guest selectedGuest = dgvGuestList.CurrentRow.DataBoundItem as Guest;

            GuestController guestController = new GuestController();
            Guest guest = guestController.GetGuest(selectedGuest);
            guestController.AddGuestToReservation(guest);
            Close();
            MessageBox.Show("Gost uspješno dodan!");
        }
    }
}
