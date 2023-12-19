using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiyatrooooo.Resources;

namespace tiyatrooooo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi = new List<Tiyatro>();
        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroListesi.Add(new Tiyatro(9, "Doğa", (new DateTime(2023, 7, 8)), "sahil", true, 150, 50));
            tiyatroListesi.Add(new Tiyatro(12, "Şair Evlenmesi", (new DateTime(1960, 12, 2)), "Çayır", false, 100, 45));
            tiyatroListesi.Add(new Tiyatro(34, "Rapunzel", (new DateTime(2008, 7, 26)), "Bahçe", true, 300, 25));
            tiyatroListesi.Add(new Tiyatro(55, "Kül Kedisi", (new DateTime(2017, 11, 5)), "Sahil", false, 60, 90));
            tiyatroListesi.Add(new Tiyatro(3, "Pamuk Prenses", (new DateTime(1997, 3, 15)), "Park", true, 180, 60));

            dgvListe.DataSource = tiyatroListesi;
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            cmbAd.Text = dgvListe.CurrentRow.Cells["ad"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            chkMuzikal.Checked = (bool)dgvListe.CurrentRow.Cells["muzikal"].Value;
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();
            nupOyunSuresi.Text = dgvListe.CurrentRow.Cells["oyunSuresi"].Value.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string oyunAd = cmbAd.Text;
            DateTime tarih = dtpTarih.Value;
            string sahne = cmbSahne.Text;
            bool muzikal= chkMuzikal.Checked;
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            decimal oyunSuresi= Convert.ToDecimal(nupOyunSuresi.Text);


            Tiyatro yeniTiyatro = new Tiyatro(id, oyunAd, tarih, sahne, muzikal, fiyat,oyunSuresi);

            tiyatroListesi.Add(yeniTiyatro);
            dgvListe.DataSource = tiyatroListesi.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Tiyatro secilenTiyatro = secilenSatir.DataBoundItem as Tiyatro;



            DialogResult result = MessageBox.Show("Seçilen tiyatro silinsin mi?", "tiyatro Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                tiyatroListesi.Remove(secilenTiyatro);
            }

            dgvListe.DataSource = tiyatroListesi.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            









        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Tiyatro secilenTiyatro = secilenSatir.DataBoundItem as Tiyatro;

            int id = Convert.ToInt32(txtId.Text);
            string ad = cmbAd.Text;
            DateTime tarih = dtpTarih.Value;
            string sahne = cmbSahne.Text;
            bool muzikal = chkMuzikal.Checked;
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            decimal oyunSure = Convert.ToDecimal(nupOyunSuresi.Text);


            secilenTiyatro.Id = id;
            secilenTiyatro.Ad = ad;
            secilenTiyatro.Tarih = tarih;
            secilenTiyatro.Sahne = sahne;
            secilenTiyatro.Muzikal = muzikal;
            secilenTiyatro.Fiyat = fiyat;
            secilenTiyatro.OyunSuresi = oyunSure;


            dgvListe.DataSource = null;
            dgvListe.DataSource = tiyatroListesi.ToList();
        }
    }
}
