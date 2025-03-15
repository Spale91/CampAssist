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
    public partial class frmAddAccommodationUnit: Form
    {
        public frmAddAccommodationUnit()
        {
            InitializeComponent();
        }

        private void frmAddAccommodationUnit_Load(object sender, EventArgs e)
        {
            TypeController typeController = new TypeController();
            var types = typeController.GetTypes();
            cboTypeName.DataSource = types;
            cboTypeName.DisplayMember = "TypeName";
            cboTypeName.ValueMember = "TypeID";
        }

        private void cboTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = (Type)cboTypeName.SelectedItem;
            numPriceSeason.Value = (decimal)selectedType.PriceSeason;
            numPriceOffSeason.Value = (decimal)selectedType.PriceOffSeason;
            numCapacity.Value = (decimal)selectedType.Capacity;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            string unitName = txtAccommodationUnitName.Text;
            float priceSeason = (float)numPriceSeason.Value;
            float priceOffSeason = (float)numPriceOffSeason.Value;
            int capacity = (int)numCapacity.Value;
            Type type = (Type)cboTypeName.SelectedItem;

            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            if(accommodationUnitController.AddUnit(unitName, priceSeason, priceOffSeason, capacity, type.TypeID))
            {
                MessageBox.Show("Novi smještaj uspješno dodan");
                Close();
            }
            else
            {
                MessageBox.Show("Smještaj već postoji");
            }
        }
    }
}
