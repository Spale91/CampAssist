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
    public partial class frmEditType: Form
    {
        Type selectedType;
        public frmEditType(Type selectedType)
        {
            InitializeComponent();
            this.selectedType = selectedType;
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            float priceSeason = (float)numPriceSeason.Value;
            float priceOffSeason = (float)numPriceOffSeason.Value;
            int capacity = (int)numCapacity.Value;

            TypeController typeController = new TypeController();
            typeController.EditType(selectedType, typeName, priceSeason, priceOffSeason, capacity);
            Close();
        }

        private void frmEditType_Load(object sender, EventArgs e)
        {
            txtTypeName.Text = selectedType.TypeName.ToString();
            numPriceSeason.Value = (decimal)selectedType.PriceSeason;
            numPriceOffSeason.Value = (decimal)selectedType.PriceOffSeason;
            numCapacity.Value = (int)selectedType.Capacity;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
