using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CampAssist
{
    public partial class frmEditAccommodationUnit: Form
    {
        AccommodationUnit selectedUnit;
        public frmEditAccommodationUnit(AccommodationUnit selectedUnit)
        {
            InitializeComponent();
            this.selectedUnit = selectedUnit;
        }



        private void frmEditAccommodationUnit_Load(object sender, EventArgs e)
        {
            TypeController typeController = new TypeController();
            var types = typeController.GetTypes();
            cboTypeName.DataSource = types;
            cboTypeName.DisplayMember = "TypeName";
            cboTypeName.ValueMember = "TypeID";

            cboTypeName.SelectedValue = selectedUnit.TypeID;
            txtAccommodationUnitName.Text = selectedUnit.Name;
            numPriceSeason.Value = (decimal)selectedUnit.PriceSeason;
            numPriceOffSeason.Value = (decimal)selectedUnit.PriceOffSeason;
            numCapacity.Value = (int)selectedUnit.Capacity;
        }

        private void cboTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = (Type)cboTypeName.SelectedItem;
            numPriceSeason.Value = (decimal)selectedType.PriceSeason;
            numPriceOffSeason.Value = (decimal)selectedType.PriceOffSeason;
            numCapacity.Value = (decimal)selectedType.Capacity;
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            Type type = (Type)cboTypeName.SelectedItem;
            string unitName = txtAccommodationUnitName.Text;
            float priceSeason = (float)numPriceSeason.Value;
            float priceOffSeason = (float)numPriceOffSeason.Value;
            int capacity = (int)numCapacity.Value;

            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            accommodationUnitController.EditUnit(selectedUnit, unitName, priceSeason, priceOffSeason, capacity, type.TypeID);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
