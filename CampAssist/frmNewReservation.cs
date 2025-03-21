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
    public partial class frmNewReservation: Form
    {
        List<Guest> tempReservationGuests;
        public frmNewReservation()
        {
            InitializeComponent();
        }

        public void RefreshPage()
        {
            GuestController guestController = new GuestController();
            tempReservationGuests = guestController.GetGuestList();
            dgvReservationGuestList.DataSource = tempReservationGuests;

            Type type = cboTypes.SelectedItem as Type;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if(!guestController.checkCapacity(type, tempReservationGuests))
            {
                MessageBox.Show("Kapacitet smještajne jedinice je popunjen");
                btnAddGuest.Enabled = false;
                btnPickOldGuest.Enabled = false;
            }
            else
            {
                btnAddGuest.Enabled = true;
                btnPickOldGuest.Enabled = true;
            }

            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            List<AccommodationUnit> accommodationUnits = accommodationUnitController.CboIndexChangeOnReservation(type, startDate, endDate);
            cboAccommodations.DataSource = accommodationUnits;
            cboAccommodations.DisplayMember = "Name";

            ReservationController reservationController = new ReservationController();
            float totalPrice = reservationController.CalculatePrice(type, startDate, endDate, tempReservationGuests);
            numTotalPrice.Value = (decimal)totalPrice;
            numTotalPrice.Enabled = false;
        }

        private void frmNewReservation_Load(object sender, EventArgs e)
        {
            TypeController typeController = new TypeController();
            List<Type> types = typeController.GetTypes();
            cboTypes.DataSource = types;
            cboTypes.DisplayMember = "TypeName";
            RefreshPage();
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            frmAddGuest frmAddGuest = new frmAddGuest();
            frmAddGuest.ShowDialog();
            RefreshPage();
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            Guest guest = dgvReservationGuestList.CurrentRow.DataBoundItem as Guest;
            if(guest != null)
            {
                GuestController guestController = new GuestController();
                guestController.RemoveGuest(guest);
                RefreshPage();
                MessageBox.Show("Gost uspješno obrisan!");
            }
            else
            {
                MessageBox.Show("Nije odabran nijedan gost");
            }
        }

        private void btnPickOldGuest_Click(object sender, EventArgs e)
        {
            frmGuestList frmGuestList = new frmGuestList();
            frmGuestList.ShowDialog();
            RefreshPage();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Type type = cboTypes.SelectedItem as Type;
            AccommodationUnit unit = cboAccommodations.SelectedItem as AccommodationUnit;
            float price = (float)numTotalPrice.Value;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReservationController reservationController = new ReservationController();
            Reservation reservation = reservationController.AddReservation(type, unit, price, startDate, endDate);
            reservationController.AddReservationDate(reservation, unit, tempReservationGuests);
            reservationController.AddAccommodationUnitGuest(unit, tempReservationGuests);
            reservationController.AddReservationGuest(reservation, tempReservationGuests);
            reservationController.changeOldGuest(reservation);

            Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReservationController reservationController = new ReservationController();
            if (!reservationController.CheckDates(startDate, endDate))
            {
                dtpEndDate.Value = startDate;
                MessageBox.Show("Završni datum ne može biti prije početnog datuma");
            }

            RefreshPage();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            ReservationController reservationController = new ReservationController();
            if (!reservationController.CheckDates(startDate, endDate))
            {
                dtpEndDate.Value = startDate;
                MessageBox.Show("Završni datum ne može biti prije početnog datuma");
            }

            RefreshPage();
        }
    }
}
