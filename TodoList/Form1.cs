using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Path = Application.StartupPath + @"\data.xml";
        private List<TodoItem> Gorevlerim = new List<TodoItem>();
        private MyXmlSerializer serializer = new MyXmlSerializer();
        private void ListeleriDoldur()
        {
            this.lstTamamlananlarListesi.Items.Clear();
            this.clbYapilacaklarListesi.Items.Clear();
            foreach (TodoItem gorev in Gorevlerim)
            {
                if (gorev.Tamamlandi == false)
                    this.clbYapilacaklarListesi.Items.Add(gorev);
                else
                    this.lstTamamlananlarListesi.Items.Add(gorev);
            }
        }
        private void YapilacaklarListesiKaydet()
        {
            serializer.Serialize<List<TodoItem>>(Path, this.Gorevlerim);
        }
        private void YapilacaklarListesiOku()
        {
            this.Gorevlerim = serializer.Deserialize<List<TodoItem>>(Path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtYeniGörev.Text = string.Empty;
            if (File.Exists(Path))
            {
                this.YapilacaklarListesiOku();
            }
            this.ListeleriDoldur();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            TodoItem yeniGorev = new TodoItem()
            {
                GorevMetni = txtYeniGörev.Text,
                Tamamlandi = false

            };
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipText = "Yeni görev oluşturuldu.";
            this.notifyIcon1.ShowBalloonTip(2000);

            this.Gorevlerim.Add(yeniGorev);
            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
            //this.clbYapilacaklarListesi.Items.Add(yeniGorev);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzeltme işlemi için bir görev seçiniz.");
                return;
            }

            TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
            gorev.GorevMetni = txtYeniGörev.Text;

            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();

            this.notifyIcon1.BalloonTipText = "Seçili görev düzeltildi.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silme işlemi için bir görev seçiniz.");
                return;
            }

            this.Gorevlerim.Remove((TodoItem) clbYapilacaklarListesi.SelectedItem);

            //clbYapilacaklarListesi.Items.Remove(clbYapilacaklarListesi.SelectedItem);

            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();

            this.notifyIcon1.BalloonTipText = "Kayıtlı görev silindi.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void clbYapilacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1) return;
            TodoItem gorev = (TodoItem) clbYapilacaklarListesi.SelectedItem;
            txtYeniGörev.Text = gorev.GorevMetni;
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Copy();
        }

        private void btnYapıştır_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Paste();
        }

        private void clbYapilacaklarListesi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.Index == -1)
                return;

            if (e.NewValue == CheckState.Checked)
            {
                TodoItem gorev = (TodoItem) clbYapilacaklarListesi.SelectedItem;
                gorev.Tamamlandi = true;
                gorev.TamamlanmaTarihi = DateTime.Now;

                this.YapilacaklarListesiKaydet();
            }
            
        }

        private void clbYapilacaklarListesi_MouseUp(object sender, MouseEventArgs e)
        {
            if (clbYapilacaklarListesi.CheckedItems.Count > 0)
            {
                this.ListeleriDoldur();
            }
        }

        private void mnuCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuUygulamaHakkında_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void btnSilTamamlananListeden_Click(object sender, EventArgs e)
        {
            if (lstTamamlananlarListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silme işlemi için bir görev seçiniz.");
                return;
            }

            this.Gorevlerim.Remove((TodoItem)lstTamamlananlarListesi.SelectedItem);

            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();

            this.notifyIcon1.BalloonTipText = "Kayıtlı görev silindi.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

    }
}
