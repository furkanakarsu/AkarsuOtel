using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AkarsuOtel.Entity;
using DevExpress.XtraEditors;

namespace AkarsuOtel.Urun
{
    public partial class UrunFormu : Form
    {
        public UrunFormu()
        {
            InitializeComponent();
        }
        OtelDBEntities db = new OtelDBEntities();
        private void UrunFormu_Load(object sender, EventArgs e)
        {
            lookBirimSec.Properties.DataSource = (from x in db.BIRIM
                                                  select new
                                                  {
                                                      x.BIRIMID,
                                                      x.BIRIMAD
                                                  }).ToList();

            lookParaBirimi.Properties.DataSource = (from x in db.KURLAR
                                                  select new
                                                  {
                                                      x.KURID,
                                                      x.KURAD
                                                  }).ToList();


            lookUrunGrup.Properties.DataSource = (from x in db.URUNGRUP
                                                  select new
                                                  {
                                                      x.URUNGRUPID,
                                                      x.GRUPADI
                                                  }).ToList();


            //lookKDV.Properties.DataSource = (from x in db.
            //                                      select new
            //                                      {
            //                                          x.BIRIMID,
            //                                          x.BIRIMAD
            //                                      }).ToList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            URUN u = new URUN();
            u.BIRIM = int.Parse(lookBirimSec.EditValue.ToString());
            u.FIYAT = int.Parse(txtFiyat.Text);
            u.KDV = byte.Parse(cmbKDV.Text);
            u.DURUM = 1;
            u.URUNAD = txtUrunAd.Text;
            u.URUNGRUPID = int.Parse(lookUrunGrup.EditValue.ToString());
            u.KUR = int.Parse(lookParaBirimi.EditValue.ToString());
            db.URUN.Add(u);
            db.SaveChanges();
            XtraMessageBox.Show($"Eklenen Ürün:{u.URUNAD} \nSisteme Ekleme:BAŞARILI","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
