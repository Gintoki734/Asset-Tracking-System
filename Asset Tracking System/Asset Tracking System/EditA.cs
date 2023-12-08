using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Asset_Tracking_System
{
    public partial class EditA : Form
    {
        private Asset asset;
        private Employee emp;
        private dbConManagement dbConManager;
        private SoftwareAsset soft;

        int aID;
        int sID;

        public EditA(Asset assets,SoftwareAsset sAsset, int a, int s)
        {
            InitializeComponent();

            this.asset = assets;
            this.soft = sAsset;
            this.aID = a;
            this.sID = s;

            // Initialize the DbConnectionManager with your connection string
            dbConManager = new dbConManagement();
            dbConManager.OpenConnection(); // Open the connection when the main form starts

            emp = new Employee(dbConManager);
        }

        private void EditA_Load(object sender, EventArgs e)
        {
            // Retrieves the data from the variable and updates the text fields
            txtName.Text = asset.Name;
            txtMan.Text = asset.Manufacturer;
            txtModel.Text = asset.Model;
            txtType.Text = asset.Type;
            txtIp.Text = asset.IPAddress;

            if (asset.PurchaseDate != default(DateTime)) { checkBox1.Checked = true; dtpPdate.Value = asset.PurchaseDate; }

            txtNote.Text = asset.Note;

            dgvE.DataSource = emp.ViewEmp();

            // Find the row with the specified ID
            DataGridViewRow targetRow = null;
            foreach (DataGridViewRow row in dgvE.Rows)
            {
                // Assuming the "ID" column is at index 0, modify accordingly
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == asset.EmployeeID.ToString())
                {
                    targetRow = row;
                    break;
                }


            }

            // If the row is found, select it
            if (targetRow != null)
            {
                targetRow.Selected = true;
                dgvE.FirstDisplayedScrollingRowIndex = targetRow.Index;
            }

            //Software Asset
            txtOSN.Text = soft.OSName;
            txtOSV.Text = soft.OSVersion;
            txtOSM.Text = soft.Manufacturer;
            dtpINS.Value = soft.InstallationDate;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Cheks if the user wants to add purchase date or not
            if (checkBox1.Checked)
            {
                dtpPdate.Visible = true;
            }
            else
            {
                dtpPdate.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //saves the data in the variable
            asset.Name = txtName.Text;
            asset.Manufacturer = txtMan.Text;
            asset.Model = txtModel.Text;
            asset.Type = txtType.Text;
            asset.IPAddress = txtIp.Text;
            // Software Asset
            soft.OSName = txtOSN.Text;
            soft.OSVersion = txtOSV.Text;
            soft.Manufacturer = txtOSM.Text;
            soft.InstallationDate = dtpINS.Value;

            //checks if the asset has purchase date or not
            if (checkBox1.Checked)
            {
                asset.PurchaseDate = dtpPdate.Value;
            }
            else
            {
                asset.PurchaseDate = default(DateTime);
            }

            asset.Note = txtNote.Text;


            if (dgvE.SelectedRows.Count > 0)
            {

                //gets employee id
                asset.EmployeeID = Convert.ToInt32(dgvE.SelectedRows[0].Cells["EmployeeID"].Value);

                try // try executing this block
                {

                    //Edits assets
                    soft.EditSoftwareAsset(soft, sID);

                }
                catch (Exception ex) // catch any error from above block
                {
                    MessageBox.Show(ex.Message);

                }

                try
                {
                    asset.EditAsset(asset, aID);
                }
                catch (Exception xe)
                {

                    MessageBox.Show(xe.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select an Employee to assign");
            }
        }
    }
}
