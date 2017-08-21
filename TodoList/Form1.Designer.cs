namespace TodoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEkle = new System.Windows.Forms.ToolStripButton();
            this.btnDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapıştır = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYardım = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDüzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHakkımda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUygulamaHakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.munYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYapılacaklarListesi = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gb_Yenigorev = new System.Windows.Forms.GroupBox();
            this.txtYeniGörev = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSilTamamlananListeden = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_Yenigorev.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.btnDüzenle,
            this.btnSil,
            this.toolStripSeparator,
            this.btnKes,
            this.btnKopyala,
            this.btnYapıştır,
            this.toolStripSeparator1,
            this.btnYardım});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::TodoList.Properties.Resources.ekle;
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(24, 24);
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDüzenle.Image = global::TodoList.Properties.Resources.düzenle;
            this.btnDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(24, 24);
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::TodoList.Properties.Resources.sil__2_;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(24, 24);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(24, 24);
            this.btnKes.Text = "C&ut";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(24, 24);
            this.btnKopyala.Text = "&Copy";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapıştır
            // 
            this.btnYapıştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapıştır.Image = ((System.Drawing.Image)(resources.GetObject("btnYapıştır.Image")));
            this.btnYapıştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapıştır.Name = "btnYapıştır";
            this.btnYapıştır.Size = new System.Drawing.Size(24, 24);
            this.btnYapıştır.Text = "&Paste";
            this.btnYapıştır.Click += new System.EventHandler(this.btnYapıştır_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnYardım
            // 
            this.btnYardım.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardım.Image = ((System.Drawing.Image)(resources.GetObject("btnYardım.Image")));
            this.btnYardım.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardım.Name = "btnYardım";
            this.btnYardım.Size = new System.Drawing.Size(24, 24);
            this.btnYardım.Text = "He&lp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuTodo,
            this.mnuHakkımda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCıkıs});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(62, 24);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuCıkıs
            // 
            this.mnuCıkıs.Image = global::TodoList.Properties.Resources.sil__2_;
            this.mnuCıkıs.Name = "mnuCıkıs";
            this.mnuCıkıs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuCıkıs.Size = new System.Drawing.Size(164, 26);
            this.mnuCıkıs.Text = "Çıkış";
            this.mnuCıkıs.Click += new System.EventHandler(this.mnuCıkıs_Click);
            // 
            // mnuTodo
            // 
            this.mnuTodo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.mnuDüzenle,
            this.toolStripMenuItem1,
            this.mnuSil,
            this.toolStripMenuItem2});
            this.mnuTodo.Name = "mnuTodo";
            this.mnuTodo.Size = new System.Drawing.Size(55, 24);
            this.mnuTodo.Text = "Todo";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Image = global::TodoList.Properties.Resources.ekle;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuYeni.Size = new System.Drawing.Size(188, 26);
            this.mnuYeni.Text = "Yeni";
            this.mnuYeni.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mnuDüzenle
            // 
            this.mnuDüzenle.Image = global::TodoList.Properties.Resources.düzenle;
            this.mnuDüzenle.Name = "mnuDüzenle";
            this.mnuDüzenle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuDüzenle.Size = new System.Drawing.Size(188, 26);
            this.mnuDüzenle.Text = "Düzenle";
            this.mnuDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuSil
            // 
            this.mnuSil.Image = global::TodoList.Properties.Resources.sil__2_;
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSil.Size = new System.Drawing.Size(188, 26);
            this.mnuSil.Text = "Sil";
            this.mnuSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuHakkımda
            // 
            this.mnuHakkımda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUygulamaHakkında,
            this.toolStripMenuItem3,
            this.munYardım});
            this.mnuHakkımda.Name = "mnuHakkımda";
            this.mnuHakkımda.Size = new System.Drawing.Size(88, 24);
            this.mnuHakkımda.Text = "Hakkımda";
            // 
            // mnuUygulamaHakkında
            // 
            this.mnuUygulamaHakkında.Image = global::TodoList.Properties.Resources.dosya;
            this.mnuUygulamaHakkında.Name = "mnuUygulamaHakkında";
            this.mnuUygulamaHakkında.Size = new System.Drawing.Size(217, 26);
            this.mnuUygulamaHakkında.Text = "Uygulama Hakkında";
            this.mnuUygulamaHakkında.Click += new System.EventHandler(this.mnuUygulamaHakkında_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 6);
            // 
            // munYardım
            // 
            this.munYardım.Image = global::TodoList.Properties.Resources.Ayarlar;
            this.munYardım.Name = "munYardım";
            this.munYardım.Size = new System.Drawing.Size(217, 26);
            this.munYardım.Text = "Yardım";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gb_Yenigorev);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 462);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.clbYapilacaklarListesi);
            this.panel3.Controls.Add(this.lblYapılacaklarListesi);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 365);
            this.panel3.TabIndex = 0;
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.clbYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(0, 18);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(258, 347);
            this.clbYapilacaklarListesi.TabIndex = 1;
            this.clbYapilacaklarListesi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbYapilacaklarListesi_ItemCheck);
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            this.clbYapilacaklarListesi.ContextMenuStripChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            this.clbYapilacaklarListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbYapilacaklarListesi_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.toolStripMenuItem4,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 88);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = global::TodoList.Properties.Resources.ekle;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::TodoList.Properties.Resources.düzenle;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 6);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::TodoList.Properties.Resources.sil__2_;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblYapılacaklarListesi
            // 
            this.lblYapılacaklarListesi.AutoSize = true;
            this.lblYapılacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapılacaklarListesi.Location = new System.Drawing.Point(0, 0);
            this.lblYapılacaklarListesi.Name = "lblYapılacaklarListesi";
            this.lblYapılacaklarListesi.Size = new System.Drawing.Size(126, 18);
            this.lblYapılacaklarListesi.TabIndex = 0;
            this.lblYapılacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Location = new System.Drawing.Point(-110, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 11);
            this.panel4.TabIndex = 0;
            // 
            // gb_Yenigorev
            // 
            this.gb_Yenigorev.Controls.Add(this.txtYeniGörev);
            this.gb_Yenigorev.Location = new System.Drawing.Point(3, 3);
            this.gb_Yenigorev.Name = "gb_Yenigorev";
            this.gb_Yenigorev.Size = new System.Drawing.Size(258, 88);
            this.gb_Yenigorev.TabIndex = 0;
            this.gb_Yenigorev.TabStop = false;
            this.gb_Yenigorev.Text = "Yeni Görev";
            // 
            // txtYeniGörev
            // 
            this.txtYeniGörev.Location = new System.Drawing.Point(6, 25);
            this.txtYeniGörev.Multiline = true;
            this.txtYeniGörev.Name = "txtYeniGörev";
            this.txtYeniGörev.Size = new System.Drawing.Size(232, 55);
            this.txtYeniGörev.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.panel2.Location = new System.Drawing.Point(279, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 462);
            this.panel2.TabIndex = 3;
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.ContextMenuStrip = this.contextMenuStrip2;
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.ItemHeight = 18;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(0, 18);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(503, 444);
            this.lstTamamlananlarListesi.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSilTamamlananListeden});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 28);
            // 
            // btnSilTamamlananListeden
            // 
            this.btnSilTamamlananListeden.Name = "btnSilTamamlananListeden";
            this.btnSilTamamlananListeden.Size = new System.Drawing.Size(94, 24);
            this.btnSilTamamlananListeden.Text = "Sil";
            this.btnSilTamamlananListeden.Click += new System.EventHandler(this.btnSilTamamlananListeden_Click);
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(0, 0);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(152, 18);
            this.lblTamamlananlarListesi.TabIndex = 1;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Bilgilendirme";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TodoList";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_Yenigorev.ResumeLayout(false);
            this.gb_Yenigorev.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEkle;
        private System.Windows.Forms.ToolStripButton btnDüzenle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapıştır;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYardım;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuCıkıs;
        private System.Windows.Forms.ToolStripMenuItem mnuTodo;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripMenuItem mnuDüzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSil;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkımda;
        private System.Windows.Forms.ToolStripMenuItem mnuUygulamaHakkında;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem munYardım;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.Label lblYapılacaklarListesi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gb_Yenigorev;
        private System.Windows.Forms.TextBox txtYeniGörev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnSilTamamlananListeden;
    }
}

