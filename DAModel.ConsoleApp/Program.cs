using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DAModel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //argüman olarak gelen keyword bu değere atanmalı
            string keyword = "velavela";
                
            //veritabanı bağlantısı için context nesnemiz oluşturuluyor
            DAMesajEntities context = new DAMesajEntities();

            //hangi adresten gönderim olacaksa burada tanımlanmalı
            var fromAddress = new MailAddress("firat.caglar.akbulut@gmail.com", "Caglar Akbulut");

            //alıcıların listesini tutacağımız collection
            MailAddressCollection toAddresses = new MailAddressCollection();

            //öncelikle db de böyle bir keywordun varlığını kontrol edelim
            var key = FindKeyword(keyword, context);

            //eğer varsa mail ilgili parametrelere göre atılır, yoksa atılamayacak, program kapanır.
            if(key==null)
                return;
            else
                AliciListesiniDoldur(toAddresses, AliciGruplariniBul(key));

            //maili gönderebilmek için ihtiyaç duyduğumuz smtp clientını oluşturuyoruz
            var smtp = SmtpClientOlustur();

            //dosyadan okuma yaparak, mail gövdesini oluşturuyoruz
            string body = PopulateBody(key.AtilacakMail.MailPath);

            //ilgili parametreler ile mail gönderiliyor.
            MailGonder(fromAddress, toAddresses, smtp, body);           
        }

        private static void MailGonder(MailAddress fromAddress, MailAddressCollection toAddresses,
            SmtpClient smtp, string body)
        {
            foreach (var alici in toAddresses)
            {
                using (var message = new MailMessage(fromAddress, alici)
                {
                    Subject = "deneme",
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                }
            }
        }

        private static SmtpClient SmtpClientOlustur()
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("firat.caglar.akbulut@gmail.com", "")
            };
            return smtp;
        }

        private static void AliciListesiniDoldur(MailAddressCollection toAddresses, List<MailGrubu> aliciGruplari)
        {
            foreach (var grup in aliciGruplari)
            {
                foreach (var aliciMailGrubu in grup.Alici_MailGrubu)
                {
                    MailAddress adres = new MailAddress(aliciMailGrubu.Alici.MailAdres,
                        aliciMailGrubu.Alici.AdSoyad);

                    toAddresses.Add(adres);
                }
            }
        }

        private static List<MailGrubu> AliciGruplariniBul(Keyword key)
        {
            List<MailGrubu> aliciGruplari = new List<MailGrubu>();

            foreach (var keywordAliciGrubu in key.MailGrubu_Keyword)
            {
                aliciGruplari.Add(keywordAliciGrubu.MailGrubu);
            }
            return aliciGruplari;
        }

        private static Keyword FindKeyword(string keyword, DAMesajEntities context)
        {
            var key = (from k in context.Keywords
                       where keyword.Equals(k.Keyword1)
                       select k).FirstOrDefault();
            return key;
        }
        
        public static string PopulateBody(string mailPath)
        {
            string body = string.Empty;
            StreamReader reader = new StreamReader(mailPath);

            body = reader.ReadToEnd();
            return body;
        }
        
    }
}
