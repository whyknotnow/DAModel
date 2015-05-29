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
    public partial class AliciListesiDuzenleForm : Form
    {
        private DAMesajEntities context;
        private DBEditForm ownerForm;

        public AliciListesiDuzenleForm(DBEditForm _ownerForm, DAMesajEntities _context)
        {
            InitializeComponent();
            ownerForm = _ownerForm;
            context = _context;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AliciListesiDuzenleForm_FormClosing);
        }

        private void AliciListesiDuzenleForm_Load(object sender, EventArgs e)
        {
            aliciListesiniGuncelle();
        }

        private void aliciListesiniGuncelle()
        {
            aliciBindingSource.DataSource = context.Alicis.ToList();
        }

        private void aliciGüncelleButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void yeniAliciKayitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(yeniAliciAdSoyadTextBox.Text == "" || yeniAliciEpostaAdresTextBox.Text == ""))
                {
                    var alici = new Alici
                    {
                        AdSoyad = yeniAliciAdSoyadTextBox.Text,
                        MailAdres = yeniAliciEpostaAdresTextBox.Text
                    };

                    context.Alicis.Add(alici);
                    context.SaveChanges();
                    aliciListesiniGuncelle();
                    MessageBox.Show("Eklendi!", "Kayıt eklendi");
                }                   
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }            
        }

        private void aliciKayitSilButton_Click(object sender, EventArgs e)
        {
            try
            {
                var alici = (Alici)aliciBindingSource.Current;
                var removed = context.Alicis.Remove(alici);
                
                context.SaveChanges();
                aliciListesiniGuncelle();
                MessageBox.Show("Seçili kayıt başarıyla silindi.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }            
        }       

        private void AliciListesiDuzenleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ownerForm.aliciListesiniYenile();
        }
    }
}
