namespace Kütüphane_Otomasyonu
{
    partial class emanetislemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetislemi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oduncislemi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alankisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.verilentxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emanet Ver";
            // 
            // oduncislemi
            // 
            this.oduncislemi.Location = new System.Drawing.Point(59, 196);
            this.oduncislemi.Name = "oduncislemi";
            this.oduncislemi.Size = new System.Drawing.Size(100, 20);
            this.oduncislemi.TabIndex = 2;
            this.oduncislemi.Text = "Ödünç Verildi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emanet İşlemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veriliş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geri Alınacak Tarih";
            // 
            // alankisi
            // 
            this.alankisi.Location = new System.Drawing.Point(59, 337);
            this.alankisi.Name = "alankisi";
            this.alankisi.Size = new System.Drawing.Size(100, 20);
            this.alankisi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alan Kişi";
            // 
            // verilentxt
            // 
            this.verilentxt.Location = new System.Drawing.Point(59, 389);
            this.verilentxt.Name = "verilentxt";
            this.verilentxt.Size = new System.Drawing.Size(100, 20);
            this.verilentxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Verilen Kitap";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(59, 240);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(156, 20);
            this.date1.TabIndex = 4;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(59, 289);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(156, 20);
            this.date2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Emanet Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emanetislemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verilentxt);
            this.Controls.Add(this.alankisi);
            this.Controls.Add(this.oduncislemi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emanetislemi";
            this.Text = "Emanet Ver";
            this.Load += new System.EventHandler(this.emanetislemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oduncislemi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alankisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox verilentxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button button1;
    }
}