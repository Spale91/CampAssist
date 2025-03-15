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
    public partial class frmTypeList: Form
    {
        public frmTypeList()
        {
            InitializeComponent();
        }

        private void ShowTypes()
        {
            TypeController typeController = new TypeController();
            List<Type> types = typeController.GetTypes();
            dgvTypeList.DataSource = types;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddType frmAddType = new frmAddType();
            frmAddType.ShowDialog();
            ShowTypes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Type selectedType = dgvTypeList.CurrentRow.DataBoundItem as Type;
            if (selectedType != null)
            {
                frmEditType frmEditType = new frmEditType(selectedType);
                frmEditType.ShowDialog();
                ShowTypes();
                MessageBox.Show("Smještaj uspješno ažuriran");
            }
            else
            {
                MessageBox.Show("Nije odabran nijedan smještaj");
            }
        }

        private void frmTypeList_Load(object sender, EventArgs e)
        {
            ShowTypes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowTypes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Type selectedType = dgvTypeList.CurrentRow.DataBoundItem as Type;
            if (selectedType != null)
            {
                TypeController typeController = new TypeController();
                typeController.DeleteType(selectedType);
                ShowTypes();
                MessageBox.Show("Smještaj uspješno obrisan");
            }
            else
            {
                MessageBox.Show("Nije odabran nijedan smještaj");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            TypeController typeController = new TypeController();
            List<Type> searchResult = typeController.SearchType(search);
            dgvTypeList.DataSource = searchResult;
        }
    }
}
