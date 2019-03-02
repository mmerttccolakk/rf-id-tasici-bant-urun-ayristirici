namespace bant_projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baglanti_bildirim = new System.Windows.Forms.Label();
            this.baglan_b = new System.Windows.Forms.Button();
            this.haberlesme_hiz = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.portlar = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.periyodik_kontrol = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.veri_temizle = new System.Windows.Forms.Button();
            this.log_kayit = new System.Windows.Forms.ListBox();
            this.anlik_veri = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.veri_gonder = new System.Windows.Forms.Button();
            this.veri_giris = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baglanti_bildirim);
            this.groupBox1.Controls.Add(this.baglan_b);
            this.groupBox1.Controls.Add(this.haberlesme_hiz);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.portlar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Ayarları";
            // 
            // baglanti_bildirim
            // 
            this.baglanti_bildirim.AutoSize = true;
            this.baglanti_bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglanti_bildirim.Location = new System.Drawing.Point(44, 132);
            this.baglanti_bildirim.Name = "baglanti_bildirim";
            this.baglanti_bildirim.Size = new System.Drawing.Size(111, 20);
            this.baglanti_bildirim.TabIndex = 12;
            this.baglanti_bildirim.Text = "Bağlantı Yok";
            // 
            // baglan_b
            // 
            this.baglan_b.Enabled = false;
            this.baglan_b.Location = new System.Drawing.Point(7, 91);
            this.baglan_b.Name = "baglan_b";
            this.baglan_b.Size = new System.Drawing.Size(195, 23);
            this.baglan_b.TabIndex = 10;
            this.baglan_b.Text = "Bağlan";
            this.baglan_b.UseVisualStyleBackColor = true;
            this.baglan_b.Click += new System.EventHandler(this.baglan_b_Click);
            // 
            // haberlesme_hiz
            // 
            this.haberlesme_hiz.FormattingEnabled = true;
            this.haberlesme_hiz.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.haberlesme_hiz.Location = new System.Drawing.Point(95, 56);
            this.haberlesme_hiz.Name = "haberlesme_hiz";
            this.haberlesme_hiz.Size = new System.Drawing.Size(107, 21);
            this.haberlesme_hiz.TabIndex = 9;
            this.haberlesme_hiz.Text = "9600";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Baund Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Port";
            // 
            // portlar
            // 
            this.portlar.FormattingEnabled = true;
            this.portlar.Location = new System.Drawing.Point(95, 29);
            this.portlar.Name = "portlar";
            this.portlar.Size = new System.Drawing.Size(107, 21);
            this.portlar.TabIndex = 6;
            this.portlar.Text = "Bağlantı Seçin";
            this.portlar.SelectedIndexChanged += new System.EventHandler(this.portlar_SelectedIndexChanged);
            this.portlar.Click += new System.EventHandler(this.portlar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // periyodik_kontrol
            // 
            this.periyodik_kontrol.Tick += new System.EventHandler(this.periyodik_kontrol_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gelen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.veri_temizle);
            this.groupBox2.Controls.Add(this.log_kayit);
            this.groupBox2.Controls.Add(this.anlik_veri);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // veri_temizle
            // 
            this.veri_temizle.Location = new System.Drawing.Point(6, 199);
            this.veri_temizle.Name = "veri_temizle";
            this.veri_temizle.Size = new System.Drawing.Size(196, 27);
            this.veri_temizle.TabIndex = 4;
            this.veri_temizle.Text = "Temizle";
            this.veri_temizle.UseVisualStyleBackColor = true;
            this.veri_temizle.Click += new System.EventHandler(this.veri_temizle_Click);
            // 
            // log_kayit
            // 
            this.log_kayit.FormattingEnabled = true;
            this.log_kayit.Location = new System.Drawing.Point(6, 59);
            this.log_kayit.Name = "log_kayit";
            this.log_kayit.Size = new System.Drawing.Size(196, 134);
            this.log_kayit.TabIndex = 4;
            // 
            // anlik_veri
            // 
            this.anlik_veri.AutoSize = true;
            this.anlik_veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlik_veri.Location = new System.Drawing.Point(91, 30);
            this.anlik_veri.Name = "anlik_veri";
            this.anlik_veri.Size = new System.Drawing.Size(33, 20);
            this.anlik_veri.TabIndex = 3;
            this.anlik_veri.Text = "veri";
            this.anlik_veri.TextChanged += new System.EventHandler(this.anlik_veri_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(227, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 355);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrol Paneli";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.veri_gonder);
            this.groupBox4.Controls.Add(this.veri_giris);
            this.groupBox4.Location = new System.Drawing.Point(220, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manuel Veri Girişi";
            // 
            // veri_gonder
            // 
            this.veri_gonder.Location = new System.Drawing.Point(476, 27);
            this.veri_gonder.Name = "veri_gonder";
            this.veri_gonder.Size = new System.Drawing.Size(86, 23);
            this.veri_gonder.TabIndex = 1;
            this.veri_gonder.Text = "Gönder";
            this.veri_gonder.UseVisualStyleBackColor = true;
            this.veri_gonder.Click += new System.EventHandler(this.veri_gonder_Click);
            // 
            // veri_giris
            // 
            this.veri_giris.Location = new System.Drawing.Point(8, 27);
            this.veri_giris.Name = "veri_giris";
            this.veri_giris.Size = new System.Drawing.Size(462, 20);
            this.veri_giris.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kontrol Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button baglan_b;
        private System.Windows.Forms.ComboBox haberlesme_hiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox portlar;
        private System.Windows.Forms.Label baglanti_bildirim;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer periyodik_kontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label anlik_veri;
        private System.Windows.Forms.ListBox log_kayit;
        private System.Windows.Forms.Button veri_temizle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button veri_gonder;
        private System.Windows.Forms.TextBox veri_giris;
    }
}

