using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using InventoryClient.Home.Kelly;
using EntityFrameworkCore.Data.Home.Kelly;

namespace InventoryClient.Home.Kelly
{
    public partial class FormMain : Form
    {
        string apiRoot;
        Item workingItem;
        public FormMain(string _apiRoot)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            barcodeSearchButton.BackColor = SystemColors.GradientActiveCaption;
            menuStrip.BackColor = SystemColors.GradientActiveCaption;
            apiRoot = _apiRoot;
        }

        private async void barcodeSearchButton_Click(object sender, EventArgs e)
        {
            workingItem = await Translate.GetItemFromBarcode(apiRoot, barcodeTextBox.Text);
            if(workingItem != null)
            {
                titleTextBox.Text = workingItem.Title;
                brandTextBox.Text = workingItem.Brand;
                mfrTextBox.Text = workingItem.Manufacturer;
                msrpTextBox.Text = workingItem.Msrp.ToString();
                descRichTextBox.Text = workingItem.Description;
            }
            else
            {
                MessageBox.Show("Error", "No item could be found using the barcode entered. Check your barcode and try again, or enter the item manually.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (recordModeRadioButton.Checked)
            {
                recordButton_Click(this, EventArgs.Empty);
            }
        }

        private void recordButton_Click(object sender, EventArgs e)
        {

        }

        private void barcodeTextBox_Enter(object sender, EventArgs e)
        {
            barcodeSearchButton_Click(this, EventArgs.Empty);
        }
    }
}
