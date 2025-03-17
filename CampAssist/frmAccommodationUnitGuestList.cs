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
    public partial class frmAccommodationUnitGuestList: Form
    {
        public frmAccommodationUnitGuestList()
        {
            InitializeComponent();
        }

        private void frmAccommodationUnitGuestList_Load(object sender, EventArgs e)
        {
            GuestController guestController = new GuestController();
            List<AccommodationUnitGuestDTO> guestList = guestController.getAccommodationUnitGuests();
            dgvGuestList.DataSource = guestList;
        }
    }
}
