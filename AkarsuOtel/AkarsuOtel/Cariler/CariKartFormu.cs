using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkarsuOtel.Entity;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace AkarsuOtel.Cariler
{
    public partial class CariKartFormu : Form
    {
        public CariKartFormu()
        {
            InitializeComponent();
        }
        OtelDBEntities db = new OtelDBEntities();

        private void CariKartFormu_Load(object sender, EventArgs e)
        {
            lookUlke.Properties.DataSource = (from x in db.UYRUK
                                                 select new
                                                 {
                                                     x.UYRUKID,
                                                     x.ULKEAD
                                                 }).ToList();

            lookCari.Properties.DataSource = (from x in db.CARITUR
                                                 select new
                                                 {
                                                     x.CARITURID,
                                                     x.CARITURAD
                                                 }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                CARI cari = new CARI();

            try
            {
                //todo:Vergi numarası SQL e eklenecek.
                //todo:53-54. satır hata veriyor.
                cari.ACIKLAMA = rchAciklama.Text;
                cari.CARIADRES = rchAdres.Text;
                cari.TELEFON = txtTelefon.Text;
                cari.CARIADSOYAD = txtAdSoyad.Text;
                cari.CARITUR = int.Parse(lookCari.EditValue.ToString());
                cari.UYRUK = int.Parse(lookUlke.EditValue.ToString());
                cari.DURUM = 1;
                cari.MAIL = txtMail.Text;
                cari.VERGIDAIRESI = txtVergiDairesi.Text;
                cari.CARITC = txtTc.Text;
                cari.YETKILI = txtYetkiliAd.Text;
                db.CARI.Add(cari);
                db.SaveChanges();
                XtraMessageBox.Show("Cari bilgileri sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata lütfen ilgili alanları kontrol edip tekrar deneyin");
            }
        }
    }
}
