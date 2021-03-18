using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkarsuOtel.FormTanımlamaları
{
    public partial class TanımlamaYonlendir : Form
    {
        public TanımlamaYonlendir()
        {
            InitializeComponent();
        }

        private void panelControl8_Click(object sender, EventArgs e)
        {
            TelefonFormu tel = new TelefonFormu();
            tel.Show();
        }

        private void panelControl1_Click(object sender, EventArgs e)
        {
            DurumFormu durumFormu = new DurumFormu();
            durumFormu.Show();
        }

        private void panelControl2_Click(object sender, EventArgs e)
        {
            DepartmanFormu dep = new DepartmanFormu();
            dep.Show();
        }

        private void panelControl3_Click(object sender, EventArgs e)
        {
            GorevFormu gorev = new GorevFormu();
            gorev.Show();
        }

        private void panelControl4_Click(object sender, EventArgs e)
        {
            BirimForm birim = new BirimForm();
            birim.Show();
        }

        private void panelControl10_Click(object sender, EventArgs e)
        {
            KurFormu kur = new KurFormu();
            kur.Show();
        }

        private void panelControl5_Click(object sender, EventArgs e)
        {
            BankaFormu banka = new BankaFormu();
            banka.Show();
        }

        private void panelControl6_Click(object sender, EventArgs e)
        {
            IslemlerFormu ıslemler = new IslemlerFormu();
            ıslemler.Show();
        }

        private void panelControl9_Click(object sender, EventArgs e)
        {
            //odalar formu
        }

        private void panelControl11_Click(object sender, EventArgs e)
        {
            UrunGrupFormu urunGrup = new UrunGrupFormu();
            urunGrup.Show();
        }
    }
}
