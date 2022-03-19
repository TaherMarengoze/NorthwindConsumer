using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreLibrary;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetCategories_Click(object sender, EventArgs e)
        {
            btnGetCategories.Enabled = false;
            dgvViewer.DataSource = await WebApiBroker.GetCategoriesAsync("api/Categories");
            dgvViewer.AutoResizeRows();
            btnGetCategories.Enabled = true;
        }
    }
}
