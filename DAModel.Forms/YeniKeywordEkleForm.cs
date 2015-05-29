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
    public partial class YeniKeywordEkleForm : Form
    {
        private DAMesajEntities context;
        private DBEditForm ownerForm;

        public YeniKeywordEkleForm(DBEditForm _ownerForm, DAMesajEntities _context)
        {
            InitializeComponent();
            ownerForm = _ownerForm;
            context = _context;
        }

        private void YeniKeywordEkleForm_Load(object sender, EventArgs e)
        {
            epostaComboBox.DataSource = context.AtilacakMails.ToList();
        }

        private void keywordEkleButton_Click(object sender, EventArgs e)
        {
            try 
	        {
                var key = (from veri in context.Keywords
                           where veri.Keyword1.Equals(keywordAdiTextBox.Text)
                           select veri).FirstOrDefault();

                if (key != null)
                {
                    MessageBox.Show("Zaten bu isimde bir keyword var.");
                }
                else
                {
                    var keyword = new Keyword
                    {
                        Keyword1 = keywordAdiTextBox.Text,
                        AtilacakMail = (AtilacakMail)epostaComboBox.SelectedItem
                    };

                    context.Keywords.Add(keyword);
                    context.SaveChanges();
                    MessageBox.Show("Başarıyla eklendi.");
                }

	        }
	        catch (Exception)
	        {
                MessageBox.Show("Veritabanı ile alakalı bir sıkıntıdan ötürü veri eklenemedi.");		       
	        }
            
        }

        private void YeniKeywordEkleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ownerForm.keywordDataSourceYenile();
        }


    }
}
