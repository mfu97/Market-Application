using System;

namespace market
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urun_adi_satis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barkod_satıs = new System.Windows.Forms.TextBox();
            this.satıs_fiyat = new System.Windows.Forms.TextBox();
            this.satıs_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.satıs_adet = new System.Windows.Forms.TextBox();
            this.kalan_adet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // urun_adi_satis
            // 
            this.urun_adi_satis.FormattingEnabled = true;
            this.urun_adi_satis.Items.AddRange(new object[] {
            "PEPSİ",
            "ÜLKER",
            "ETİ",
            "LAYS",
            "GONG"});
            this.urun_adi_satis.Location = new System.Drawing.Point(179, 282);
            this.urun_adi_satis.Name = "urun_adi_satis";
            this.urun_adi_satis.Size = new System.Drawing.Size(121, 24);
            this.urun_adi_satis.TabIndex = 10;
            this.urun_adi_satis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "BRAND";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "BARCODE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRICE";
            // 
            // barkod_satıs
            // 
            this.barkod_satıs.Location = new System.Drawing.Point(179, 327);
            this.barkod_satıs.Name = "barkod_satıs";
            this.barkod_satıs.Size = new System.Drawing.Size(100, 22);
            this.barkod_satıs.TabIndex = 14;
            // 
            // satıs_fiyat
            // 
            this.satıs_fiyat.Location = new System.Drawing.Point(179, 365);
            this.satıs_fiyat.Name = "satıs_fiyat";
            this.satıs_fiyat.Size = new System.Drawing.Size(100, 22);
            this.satıs_fiyat.TabIndex = 15;
            // 
            // satıs_btn
            // 
            this.satıs_btn.Location = new System.Drawing.Point(179, 444);
            this.satıs_btn.Name = "satıs_btn";
            this.satıs_btn.Size = new System.Drawing.Size(75, 23);
            this.satıs_btn.TabIndex = 16;
            this.satıs_btn.Text = "SALES";
            this.satıs_btn.UseVisualStyleBackColor = true;
            this.satıs_btn.Click += new System.EventHandler(this.satıs_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(345, 282);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(885, 185);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "PIECE";
            // 
            // satıs_adet
            // 
            this.satıs_adet.Location = new System.Drawing.Point(179, 402);
            this.satıs_adet.Name = "satıs_adet";
            this.satıs_adet.Size = new System.Drawing.Size(100, 22);
            this.satıs_adet.TabIndex = 19;
            // 
            // kalan_adet
            // 
            this.kalan_adet.Location = new System.Drawing.Point(1236, 50);
            this.kalan_adet.Name = "kalan_adet";
            this.kalan_adet.Size = new System.Drawing.Size(100, 22);
            this.kalan_adet.TabIndex = 20;
            this.kalan_adet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 623);
            this.Controls.Add(this.kalan_adet);
            this.Controls.Add(this.satıs_adet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.satıs_btn);
            this.Controls.Add(this.satıs_fiyat);
            this.Controls.Add(this.barkod_satıs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urun_adi_satis);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox urun_adi_satis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox barkod_satıs;
        private System.Windows.Forms.TextBox satıs_fiyat;
        private System.Windows.Forms.Button satıs_btn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox satıs_adet;
        private System.Windows.Forms.TextBox kalan_adet;
    }
}

