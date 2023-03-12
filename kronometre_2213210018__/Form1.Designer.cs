namespace kronometre_2213210018__
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
            this.lblSure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrKronometre = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.lbKayit = new System.Windows.Forms.ListBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(651, 130);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(52, 60);
            this.lblSure.TabIndex = 10;
            this.lblSure.Text = "0";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Forte", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kronometrem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmrKronometre
            // 
            this.tmrKronometre.Interval = 1000;
            this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kalan Süre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Süreyi Giriniz (Saniye):";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(221, 98);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(100, 22);
            this.txtSure.TabIndex = 15;
            // 
            // lbKayit
            // 
            this.lbKayit.FormattingEnabled = true;
            this.lbKayit.ItemHeight = 16;
            this.lbKayit.Location = new System.Drawing.Point(465, 270);
            this.lbKayit.Name = "lbKayit";
            this.lbKayit.Size = new System.Drawing.Size(354, 212);
            this.lbKayit.TabIndex = 14;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(9, 312);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(131, 93);
            this.btnBasla.TabIndex = 13;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(192, 312);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(149, 93);
            this.btnDur.TabIndex = 12;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // cmbInterval
            // 
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000"});
            this.cmbInterval.Location = new System.Drawing.Point(9, 161);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(312, 24);
            this.cmbInterval.TabIndex = 11;
            this.cmbInterval.Text = "Hız Seçin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 529);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.lbKayit);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.cmbInterval);
            this.Name = "Form1";
            this.Text = "Yazılım Uzmanlığı Kronometre Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrKronometre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ListBox lbKayit;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.ComboBox cmbInterval;
    }
}

