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
    public partial class frmAddType: Form
    {
        public frmAddType()
        {
            InitializeComponent();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            float priceSeason = (float)numPriceSeason.Value;
            float priceOffSeason = (float)numPriceOffSeason.Value;
            int capacity = (int)numCapacity.Value;

            TypeController typeController = new TypeController();
            if(typeController.AddType(typeName, priceSeason, priceOffSeason, capacity))
            {
                MessageBox.Show("Novi tip smještaja uspješno dodan");
            }
            else
            {
                MessageBox.Show("Tip smještaja već postoji");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
