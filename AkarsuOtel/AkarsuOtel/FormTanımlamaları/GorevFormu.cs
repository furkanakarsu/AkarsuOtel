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

namespace AkarsuOtel.FormTanımlamaları
{
    public partial class GorevFormu : Form
    {
        public GorevFormu()
        {
            InitializeComponent();
        }
        OtelDBEntities db = new OtelDBEntities();
        private void GorevFormu_Load(object sender, EventArgs e)
        {
            db.GOREV.Load();
            bindingSource1.DataSource = db.GOREV.Local;
            repositoryItemLookUpEdit1.DataSource = (from x in db.DEPARTMAN
                                                    select new
                                                    {
                                                        x.DEPARTMANID,
                                                        x.DEPARTMANAD
                                                    }).ToList();
            repositoryItemLookUpEdit2.DataSource = (from x in db.TBLDURUM
                                                    select new
                                                    {
                                                        x.DURUMID,
                                                        x.DURUMAD
                                                    }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata lütfen tekrar deneyin");
            }
        }
    }
}
