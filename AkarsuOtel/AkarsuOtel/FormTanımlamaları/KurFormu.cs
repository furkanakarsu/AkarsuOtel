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
    public partial class KurFormu : Form
    {
        public KurFormu()
        {
            InitializeComponent();
        }
        OtelDBEntities db = new OtelDBEntities();
        private void KurFormu_Load(object sender, EventArgs e)
        {
            db.KURLAR.Load();
            bindingSource1.DataSource = db.KURLAR.Local;
            //repositoryItemLookUpEdit1.DataSource=(from x in db.KURLAR select new
            //{

            //})

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
