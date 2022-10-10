namespace Kütüphane_Otomasyonu
{
    partial class bookadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookadd));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapseri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kitapadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Seri Numarası";
            // 
            // kitapseri
            // 
            this.kitapseri.Location = new System.Drawing.Point(30, 197);
            this.kitapseri.Name = "kitapseri";
            this.kitapseri.Size = new System.Drawing.Size(100, 20);
            this.kitapseri.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Adı";
            // 
            // kitapadi
            // 
            this.kitapadi.Location = new System.Drawing.Point(30, 243);
            this.kitapadi.Name = "kitapadi";
            this.kitapadi.Size = new System.Drawing.Size(100, 20);
            this.kitapadi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategori";
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(30, 292);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(100, 20);
            this.kategori.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giriş Tarihi";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(30, 336);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(148, 20);
            this.date.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kitapadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitapseri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "bookadd";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.bookadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kitapseri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kitapadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button1;
    }
}