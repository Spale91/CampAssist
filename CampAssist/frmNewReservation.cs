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
    public partial class frmNewReservation: Form
    {
        public frmNewReservation()
        {
            InitializeComponent();
        }

        private void frmNewReservation_Load(object sender, EventArgs e)
        {
            TypeController typeController = new TypeController();
            List<Type> types = typeController.GetTypes();
            cboTypes.DataSource = types;
            cboTypes.DisplayMember = "TypeName";
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedType = cboTypes.SelectedItem as Type;
            AccommodationUnitController accommodationUnitController = new AccommodationUnitController();
            List<AccommodationUnit> accommodationUnits = accommodationUnitController.CboIndexChange(selectedType);
            cboAccommodations.DataSource = accommodationUnits;
            cboAccommodations.DisplayMember = "Name";
        }
    }
}
