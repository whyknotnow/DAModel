using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAModel.Forms
{
    public partial class MainForm : Form
    {
        private HtmlEditForm htmlEditForm;
        private DBEditForm dbEditForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void htmlDuzenlemeButon_Click(object sender, EventArgs e)
        {
            htmlEditForm = new HtmlEditForm();
            htmlEditForm.ShowDialog();
        }

        private void veritabaniIslemButon_Click(object sender, EventArgs e)
        {
            dbEditForm = new DBEditForm();
            dbEditForm.ShowDialog();
        }
    }
}
