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
    public partial class MailDuzenleForm : Form
    {
        private DAMesajEntities context;
        private DBEditForm ownerForm;

        public MailDuzenleForm(DBEditForm _ownerForm, DAMesajEntities _context)
        {
            InitializeComponent();
            ownerForm = _ownerForm;
            context = _context;
        }

        private void MailDuzenleForm_Load(object sender, EventArgs e)
        {
            atilacakMailBindingSource.DataSource = context.AtilacakMails.ToList();
        }

        private void yeniEpostaEkleButton_Click(object sender, EventArgs e)
        {
            try
            {               
                var atilacakMail = new AtilacakMail
                {
                    MailName = yeniEpostaAdTextBox.Text,
                    MailPath = yeniEpostaKonumuTextBox.Text
                };
                context.AtilacakMails.Add(atilacakMail);
                context.SaveChanges();

                atilacakMailBindingSource.DataSource = context.AtilacakMails.ToList();
                MessageBox.Show("Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Eklenemedi. Bir hata var.");
            }            
        }

        private void epostaSilButton_Click(object sender, EventArgs e)
        {
             try
            {
                var silinecekMail = (AtilacakMail)atilacakMailBindingSource.Current;

                var silinecek = (from veri in context.AtilacakMails
                                 where veri.Id == silinecekMail.Id
                                 select veri).FirstOrDefault();

                context.AtilacakMails.Remove(silinecek);
                context.SaveChanges();

                atilacakMailBindingSource.DataSource = context.AtilacakMails.ToList();

                yeniEpostaAdTextBox.Text = "";
                yeniEpostaKonumuTextBox.Text = "";

                MessageBox.Show("Veri başarıyla silindi");                
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu");
            }           

        
        }
    }
}
