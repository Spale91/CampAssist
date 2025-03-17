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
    public partial class frmAccommodationUnitList: Form
    {
        public frmAccommodationUnitList()
        {
            InitializeComponent();
        }

        public void ShowAccommodationUnits()
        {
            Type type = cboTypes.SelectedItem as Type;

            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            List<AccommodationUnit> accommodationUnits = accommodationUnitController.GetAccommodationUnits(type);
            dgvAccommodationUnitList.DataSource = accommodationUnits;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAccommodationUnit frmAddAccommodationUnit = new frmAddAccommodationUnit();
            frmAddAccommodationUnit.ShowDialog();
            ShowAccommodationUnits();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AccommodationUnit selectedUnit = dgvAccommodationUnitList.CurrentRow.DataBoundItem as AccommodationUnit;
            if(selectedUnit != null)
            {
                frmEditAccommodationUnit frmEditAccommodationUnit = new frmEditAccommodationUnit(selectedUnit);
                frmEditAccommodationUnit.ShowDialog();
                ShowAccommodationUnits();
                MessageBox.Show("Smještaj uspješno ažuriran");
            }
            else
            {
                MessageBox.Show("Nije odabran nijedan smještaj");
            }
        }

        private void frmAccommodationUnitList_Load(object sender, EventArgs e)
        {
            TypeController typeController = new TypeController();
            List<Type> types = typeController.GetTypes();
            cboTypes.DataSource = types;
            cboTypes.DisplayMember = "TypeName";
            ShowAccommodationUnits();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radioBtnFree.Checked = false;
            radioBtnReserved.Checked = false;
            ShowAccommodationUnits();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AccommodationUnit selectedUnit = dgvAccommodationUnitList.CurrentRow.DataBoundItem as AccommodationUnit;
            if(selectedUnit != null) 
            {
                AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
                accommodationUnitController.DeleteUnit(selectedUnit);
                MessageBox.Show("Smještaj uspješno obrisan");
                ShowAccommodationUnits();
            }
            else
            {
                MessageBox.Show("Nije odabran nijedan smještaj");
            }
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type type = cboTypes.SelectedItem as Type;

            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            List<AccommodationUnit> accommodationUnits = accommodationUnitController.CboIndexChange(type);
            dgvAccommodationUnitList.DataSource = accommodationUnits;
        }

        private void radioBtnReserved_CheckedChanged(object sender, EventArgs e)
        {
            Type type = cboTypes.SelectedItem as Type;

            if(radioBtnReserved.Checked)
            {
                radioBtnFree.Checked = false;
                AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
                List<AccommodationUnit> accommodationUnits = accommodationUnitController.GetReservedAccommodationUnits(type);
                dgvAccommodationUnitList.DataSource = accommodationUnits;
            }
        }

        private void radioBtnFree_CheckedChanged(object sender, EventArgs e)
        {
            Type type = cboTypes.SelectedItem as Type;

            if (radioBtnFree.Checked)
            {
                radioBtnReserved.Checked = false;
                AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
                List<AccommodationUnit> accommodationUnits = accommodationUnitController.GetFreeAccommodationUnits(type);
                dgvAccommodationUnitList.DataSource = accommodationUnits;
            }
        }
    }
}
