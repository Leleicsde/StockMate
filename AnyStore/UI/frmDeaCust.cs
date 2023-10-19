using AnyStore.BLL;
using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDal = new DeaCustDAL();
        userDAL uDal = new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIdFromUsername(loggedUsr);

            dc.added_by = usr.id;


            bool success = dcDal.Insert(dc);

            if (success == true)
            {

                MessageBox.Show("Dealer or Customer Added Successfully!");
                Clear();
                DataTable dt = dcDal.Select();
                dgvDeaCrust.DataSource = dt;
            }
            else
            {
                //Failed to Add New product
                MessageBox.Show("Failed to Add New Dealer or Customer!");
            }

        }
        public void Clear()
        {
            txtDeaCustID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            DataTable dt = dcDal.Select();
            dgvDeaCrust.DataSource = dt;
        }

        private void dgvDeaCrust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtDeaCustID.Text = dgvDeaCrust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCrust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCrust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCrust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCrust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCrust.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtDeaCustID.Text);
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIdFromUsername(loggedUsr);

            dc.added_by = usr.id;


            bool success = dcDal.Update(dc);

            if (success == true)
            {

                MessageBox.Show("Dealer or Customer Successfully Updated!");
                Clear();

                DataTable dt = dcDal.Select();
                dgvDeaCrust.DataSource = dt;
            }
            else
            {

                MessageBox.Show("Failed to Update Dealer or Customer!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtDeaCustID.Text);


            bool success = dcDal.Delete(dc);


            if (success == true)
            {

                MessageBox.Show("Dealer or Customer successfully deleted!");
                Clear();
                DataTable dt = dcDal.Select();
                dgvDeaCrust.DataSource = dt;
            }
            else
            {

                MessageBox.Show("Failed to Delete Dealer or Customer!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {

                DataTable dt = dcDal.Search(keywords);
                dgvDeaCrust.DataSource = dt;
            }
            else
            {

                DataTable dt = dcDal.Select();
                dgvDeaCrust.DataSource = dt;
            }
        }
    }
}
