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
    public partial class frmStats: Form
    {
        public frmStats()
        {
            InitializeComponent();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            ReservationController reservationController = new ReservationController();
            float averageGuestNumber = reservationController.GetAverageGuestNumber();
            lblAverageGuestNumber.Text = averageGuestNumber.ToString() + " gosta";

            float yearlyIncome = reservationController.GetYearlyIncome();
            lblYearlyIncome.Text = yearlyIncome.ToString() + " €";

            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            float unitsFillThroughYear = accommodationUnitController.GetUnitsFillThroughYear();
            lblFillYear.Text = unitsFillThroughYear.ToString() + "%";
        }
    }
}
