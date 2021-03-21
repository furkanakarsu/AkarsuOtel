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
    }
}
