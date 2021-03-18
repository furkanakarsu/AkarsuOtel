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

namespace AkarsuOtel.FormTanımlamaları
{
    public partial class OdalarFormu : Form
    {
        public OdalarFormu()
        {
            InitializeComponent();
        }

        OtelDBEntities db = new OtelDBEntities();
        private void OdalarFormu_Load(object sender, EventArgs e)
        {
            db.ODALAR.Load();
            bindingSource1.DataSource = db.ODALAR.Local;

            repositoryItemLookUpEdit1.DataSource = (from x in db.TBLDURUM
                                                    select new
                                                    {
                                                        x.DURUMAD,
                                                        x.DURUMID
                                                    }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
