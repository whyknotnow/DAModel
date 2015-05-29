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
    public partial class MailGrubuDuzenleForm : Form
    {
        private DAMesajEntities context;
        private DBEditForm ownerForm;

        public MailGrubuDuzenleForm(DBEditForm _ownerForm, DAMesajEntities _context)
        {
            InitializeComponent();
            ownerForm = _ownerForm;
            context = _context;
        }

        private void AliciListesiniGuncelle()
        {
            var mailGrubu = (MailGrubu)mailGrubuBindingSource1.Current;
            aliciBindingSource1.DataSource = (from alici in context.Alicis
                                              from weaktable in context.Alici_MailGrubu
                                              where mailGrubu.Id == weaktable.GrupId && alici.Id == weaktable.AliciId
                                              select alici).ToList();


        }

        private void MailGrubuDuzenleForm_Load_1(object sender, EventArgs e)
        {
            mailGrubuBindingSource1.DataSource = context.MailGrubus.ToList();
            AliciListesiniGuncelle();
            bindingSource1.DataSource = context.Alicis.ToList();
        }

        private void mailGrubuBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            AliciListesiniGuncelle();
        }

        private void aliciEkleButton_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		        var eklenecekAlici = (Alici)bindingSource1.Current;
                var mailGrubu = (MailGrubu)mailGrubuBindingSource1.Current;
                var aliciMailGrubu = new Alici_MailGrubu{
                    AliciId = eklenecekAlici.Id,
                    GrupId = mailGrubu.Id,
                    Alici = eklenecekAlici,
                    MailGrubu = mailGrubu
                };
                context.Alici_MailGrubu.Add(aliciMailGrubu);
                context.SaveChanges();
                mailGrubuBindingSource1.DataSource = context.MailGrubus.ToList();
                MessageBox.Show("Eklendi");
	        }
	        catch (Exception)
	        {		
		        MessageBox.Show("Eklenemedi. Bir hata var.");
	        }            
        }

        private void aliciSil_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecekAlici = (Alici)aliciBindingSource1.Current;
                var mailGrubu = (MailGrubu)mailGrubuBindingSource1.Current;

                var silinecek = (from veri in context.Alici_MailGrubu
                                 where veri.AliciId == silinecekAlici.Id && veri.GrupId == mailGrubu.Id
                                 select veri).FirstOrDefault();

                context.Alici_MailGrubu.Remove(silinecek);
                context.SaveChanges();
                AliciListesiniGuncelle();
                MessageBox.Show("Veri başarıyla silindi");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu");
            }           

        }

        private void MailGrubuDuzenleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ownerForm.grupListesiniYenile();
        }

        private void mailGrubuEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailGrubu eklenecekGrup = new MailGrubu
                {
                    GrupAd = mailGrubuEkleTextBox.Text
                };
                context.MailGrubus.Add(eklenecekGrup);
                context.SaveChanges();
                mailGrubuBindingSource1.DataSource = context.MailGrubus.ToList();
                ownerForm.mailGrubuComboBoxDoldur();
                MessageBox.Show("Mail grubu oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu.");
            }
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecek = (MailGrubu)mailGrubuBindingSource1.Current;
                context.MailGrubus.Remove(silinecek);
                context.SaveChanges();
                MessageBox.Show("Başarıyla silindi.");
                mailGrubuBindingSource1.DataSource = context.MailGrubus.ToList();
                ownerForm.mailGrubuComboBoxDoldur();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Silinemedi.");
            }
            
            
        }      

        
    }
}
