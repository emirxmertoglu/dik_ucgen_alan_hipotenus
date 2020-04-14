namespace dik_ucgen_alan_hipotenus
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
            this.ilkKenar = new System.Windows.Forms.Label();
            this.ikinciKenar = new System.Windows.Forms.Label();
            this.txtIlkKenar = new System.Windows.Forms.TextBox();
            this.txtIkinciKenar = new System.Windows.Forms.TextBox();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblHipotenus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ilkKenar
            // 
            this.ilkKenar.AutoSize = true;
            this.ilkKenar.Location = new System.Drawing.Point(81, 31);
            this.ilkKenar.Name = "ilkKenar";
            this.ilkKenar.Size = new System.Drawing.Size(49, 13);
            this.ilkKenar.TabIndex = 0;
            this.ilkKenar.Text = "İlk Kenar";
            // 
            // ikinciKenar
            // 
            this.ikinciKenar.AutoSize = true;
            this.ikinciKenar.Location = new System.Drawing.Point(81, 67);
            this.ikinciKenar.Name = "ikinciKenar";
            this.ikinciKenar.Size = new System.Drawing.Size(63, 13);
            this.ikinciKenar.TabIndex = 0;
            this.ikinciKenar.Text = "İkinci Kenar";
            // 
            // txtIlkKenar
            // 
            this.txtIlkKenar.Location = new System.Drawing.Point(191, 28);
            this.txtIlkKenar.Name = "txtIlkKenar";
            this.txtIlkKenar.Size = new System.Drawing.Size(100, 20);
            this.txtIlkKenar.TabIndex = 1;
            // 
            // txtIkinciKenar
            // 
            this.txtIkinciKenar.Location = new System.Drawing.Point(191, 64);
            this.txtIkinciKenar.Name = "txtIkinciKenar";
            this.txtIkinciKenar.Size = new System.Drawing.Size(100, 20);
            this.txtIkinciKenar.TabIndex = 1;
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Location = new System.Drawing.Point(146, 108);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(75, 23);
            this.hesaplaBtn.TabIndex = 2;
            this.hesaplaBtn.Text = "HESAPLA";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.hesaplaBtn_Click);
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Location = new System.Drawing.Point(112, 155);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(130, 20);
            this.lblAlan.TabIndex = 3;
            this.lblAlan.Text = "ALAN DEĞERİ";
            // 
            // lblHipotenus
            // 
            this.lblHipotenus.AutoSize = true;
            this.lblHipotenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHipotenus.Location = new System.Drawing.Point(84, 192);
            this.lblHipotenus.Name = "lblHipotenus";
            this.lblHipotenus.Size = new System.Drawing.Size(186, 20);
            this.lblHipotenus.TabIndex = 3;
            this.lblHipotenus.Text = "HİPOTENÜS DEĞERİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 246);
            this.Controls.Add(this.lblHipotenus);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.hesaplaBtn);
            this.Controls.Add(this.txtIkinciKenar);
            this.Controls.Add(this.txtIlkKenar);
            this.Controls.Add(this.ikinciKenar);
            this.Controls.Add(this.ilkKenar);
            this.Name = "Form1";
            this.Text = "Dik Üçgende Alan ve Hipotenüs Hesabı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilkKenar;
        private System.Windows.Forms.Label ikinciKenar;
        private System.Windows.Forms.TextBox txtIlkKenar;
        private System.Windows.Forms.TextBox txtIkinciKenar;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblHipotenus;
    }
}

