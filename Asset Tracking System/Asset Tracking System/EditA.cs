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

        public EditA(Asset assets)
        {
            InitializeComponent();

            this.asset = assets;
        }

        private void EditA_Load(object sender, EventArgs e)
        {
            // Retrieves the data from the variable and updates the text fields
            txtName.Text = asset.Name;
            txtMan.Text = asset.Manufacturer;
            txtModel.Text = asset.Model;
            txtType.Text = asset.Type;
            txtIp.Text = asset.IPAddress;

            if (asset.PurchaseDate != default(DateTime)) { checkBox1.Checked = true; }

            txtNote.Text = asset.Note;


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
    }
}
