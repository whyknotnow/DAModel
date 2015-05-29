using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAModel;

namespace DAModel.Forms
{
    public partial class DBEditForm : Form
    {
        private DAMesajEntities context = new DAMesajEntities();

        private AliciListesiDuzenleForm aliciListesiDuzenlemeEkrani;
        private MailGrubuDuzenleForm mailGrubuDuzenlemeEkrani;
        private MailDuzenleForm mailDuzenlemeEkrani;
        private YeniKeywordEkleForm yeniKeywordEkleEkrani;

        public DBEditForm()
        {
            InitializeComponent();
        }

        public void DBEditForm_Load(object sender, EventArgs e)
        {
            keywordDataSourceYenile();
            grupListesiniYenile();
            aliciListesiniYenile();
            mailGrubuComboBoxDoldur();
        }

        public void mailGrubuComboBoxDoldur()
        {
            yeniGrupEkleComboBox.DataSource = context.MailGrubus.ToList();
        }

        public void keywordDataSourceYenile()
        {
            this.keyword1BindingSource.DataSource = context.Keywords.ToList();
        }   
        public void grupListesiniYenile()
        {
            var keyValue = (Keyword)this.keyword1BindingSource.Current;
            
            //this.mailGrubuBindingSource.DataSource = context.MailGrubus.Where(c => c.KeywordId == keyValue.Id).ToList();

            this.mailGrubuBindingSource.DataSource = (from weaktable in context.MailGrubu_Keyword
                                                      from mailgrubu in context.MailGrubus
                                                      where weaktable.KeywordId == keyValue.Id && weaktable.MailGrubuId == mailgrubu.Id
                                                      select mailgrubu).ToList();
                                                     
        }
        public void aliciListesiniYenile()
        {
            MailGrubu mailGrubuValue = (MailGrubu)this.mailGrubuBindingSource.Current;

            if (mailGrubuValue == null)
            {
                aliciBindingSource.Clear();
                return;
            }

            var alicilar = (from aliciGrup in context.Alici_MailGrubu
                            from alici in context.Alicis
                            where aliciGrup.AliciId == alici.Id && aliciGrup.GrupId == mailGrubuValue.Id
                            select alici).ToList();

            this.aliciBindingSource.DataSource = alicilar;
        }
        public void atilacakMailYenile()
        {
            var keyword = (Keyword)keyword1BindingSource.Current;
            atilacakMailBindingSource.DataSource = (from mail in context.AtilacakMails
                                                    where keyword.MailId == mail.Id
                                                    select mail).FirstOrDefault();
        }
        private void keyword1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            grupListesiniYenile();
            atilacakMailYenile();

        }
        private void mailGrubuBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            aliciListesiniYenile();
        }  
        private void kaydetButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (aliciBindingSource.Current != null)
            //    {
            //        var alici = (Alici)aliciBindingSource.Current;
            //        var grup = (MailGrubu)mailGrubuBindingSource.Current;
            //        var aliciMailGrubu = new Alici_MailGrubu
            //        {
            //            AliciId = context.Alicis.Add(alici).Id,
            //            GrupId = grup.Id
            //        };
            //        context.Alici_MailGrubu.Add(aliciMailGrubu);
            //        context.SaveChanges();
            //        MessageBox.Show("başarılı.");
            //    }
            //    else if (mailGrubuBindingSource.Current != null && aliciBindingSource.Current == null)
            //    {
            //        var grup = (MailGrubu)mailGrubuBindingSource.Current;
            //        var keyword = (Keyword)keyword1BindingSource.Current;

            //        if (grup.KeywordId == 0)
            //        {
            //            grup.KeywordId = keyword.Id;
            //            context.MailGrubus.Add(grup);
            //            context.SaveChanges();
            //        }
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void aliciListesiDuzenleButton_Click(object sender, EventArgs e)
        {
            aliciListesiDuzenlemeEkrani = new AliciListesiDuzenleForm(this, context);
            aliciListesiDuzenlemeEkrani.ShowDialog();
        }

        private void mailGrubuDuzenleButton_Click(object sender, EventArgs e)
        {
            mailGrubuDuzenlemeEkrani = new MailGrubuDuzenleForm(this, context);
            mailGrubuDuzenlemeEkrani.Show();
        }

        private void epostaDuzenleButton_Click(object sender, EventArgs e)
        {
            mailDuzenlemeEkrani = new MailDuzenleForm(this, context);
            mailDuzenlemeEkrani.Show();
        }

        private void keywordDuzenleButton_Click(object sender, EventArgs e)
        {
            yeniKeywordEkleEkrani = new YeniKeywordEkleForm(this, context);
            yeniKeywordEkleEkrani.ShowDialog();
        }

        private void grupEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                var mailGrubu = (MailGrubu)yeniGrupEkleComboBox.SelectedItem;                
                var keyword = (Keyword)keyword1BindingSource.Current;
                //mailGrubu.KeywordId = keyword.Id;

                var mk = new MailGrubu_Keyword
                {
                    KeywordId = keyword.Id,
                    MailGrubuId = mailGrubu.Id,
                    Keyword = keyword,
                    MailGrubu = mailGrubu
                };

                context.MailGrubu_Keyword.Add(mk);
                context.SaveChanges();

                
                grupListesiniYenile();
                MessageBox.Show("Mail grubu eklendi");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hata var.");                
            }
            
        }

        private void grubuCikarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var mailGrubu = (MailGrubu)mailGrubuBindingSource.Current;
                var keyword = (Keyword)keyword1BindingSource.Current;
                MailGrubu_Keyword silinecek = (from item in context.MailGrubu_Keyword
                                               where item.KeywordId == keyword.Id && item.MailGrubuId == mailGrubu.Id
                                               select item).FirstOrDefault();
                context.MailGrubu_Keyword.Remove(silinecek);
                context.SaveChanges();
                grupListesiniYenile();
                
                MessageBox.Show("Başarıyla silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Silemedim");
            }
        }

        private void aramaYapButton_Click(object sender, EventArgs e)
        {
            string aranacakKelime = aramaKutusuTextBox.Text;

            var keyword = (from key in context.Keywords
                           where aranacakKelime.Equals(key.Keyword1)
                           select key).FirstOrDefault();

            if (keyword == null)
                MessageBox.Show("Aradığınız kriterlere göre bir sonuç yok.");
            else
            {
                keyword1BindingSource.Position = keyword1BindingSource.IndexOf(keyword);
            }
                
        }
    }
}
