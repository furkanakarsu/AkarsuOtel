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
    public partial class IslemlerFormu : Form
    {
        public IslemlerFormu()
        {
            InitializeComponent();
        }

        OtelDBEntities db = new OtelDBEntities();
        private void IslemlerFormu_Load(object sender, EventArgs e)
        {
            db.ISLEM.Load();
            bindingSource1.DataSource = db.ISLEM.Local;

            repositoryItemLookUpEdit1.DataSource = (from x in db.TBLDURUM
                                                    select new
                                                    {
                                                        x.DURUMID,
                                                        x.DURUMAD
                                                    }).ToList();


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
