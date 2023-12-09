namespace emlakofisi
{
    partial class SorgulamaForm
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
            this.comboBoxEvturu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxoda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSemt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxfiyat = new System.Windows.Forms.TextBox();
            this.textBoxkira = new System.Windows.Forms.TextBox();
            this.checkBoxSatilik = new System.Windows.Forms.CheckBox();
            this.checkBoxkiralık = new System.Windows.Forms.CheckBox();
            this.buttonSorgula = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonduzenleme = new System.Windows.Forms.Button();
            this.buttonsilme = new System.Windows.Forms.Button();
            this.buttonarsiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEvturu
            // 
            this.comboBoxEvturu.AutoCompleteCustomSource.AddRange(new string[] {
            "Daire",
            "Bahceli",
            "Dubleks",
            "Mustakil"});
            this.comboBoxEvturu.FormattingEnabled = true;
            this.comboBoxEvturu.Items.AddRange(new object[] {
            "Daire",
            "Bahceli",
            "Dubleks",
            "Mustakil"});
            this.comboBoxEvturu.Location = new System.Drawing.Point(111, 187);
            this.comboBoxEvturu.Name = "comboBoxEvturu";
            this.comboBoxEvturu.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEvturu.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ev Türü";
            // 
            // textBoxKat
            // 
            this.textBoxKat.Location = new System.Drawing.Point(111, 57);
            this.textBoxKat.Name = "textBoxKat";
            this.textBoxKat.Size = new System.Drawing.Size(200, 22);
            this.textBoxKat.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Alanı";
            // 
            // textBoxAlan
            // 
            this.textBoxAlan.Location = new System.Drawing.Point(110, 140);
            this.textBoxAlan.Name = "textBoxAlan";
            this.textBoxAlan.Size = new System.Drawing.Size(200, 22);
            this.textBoxAlan.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Semt Seçimi";
            // 
            // textBoxoda
            // 
            this.textBoxoda.Location = new System.Drawing.Point(111, 12);
            this.textBoxoda.Name = "textBoxoda";
            this.textBoxoda.Size = new System.Drawing.Size(200, 22);
            this.textBoxoda.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kat Numarası";
            // 
            // comboBoxSemt
            // 
            this.comboBoxSemt.FormattingEnabled = true;
            this.comboBoxSemt.Items.AddRange(new object[] {
            "Selçuklu",
            "Karatay",
            "Meram",
            "Beşiktaş",
            "Beyoğlu",
            "Kadıköy",
            "Taksim",
            "Zeytinburnu"});
            this.comboBoxSemt.Location = new System.Drawing.Point(111, 101);
            this.comboBoxSemt.Name = "comboBoxSemt";
            this.comboBoxSemt.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSemt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oda Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Kira";
            // 
            // textBoxfiyat
            // 
            this.textBoxfiyat.Location = new System.Drawing.Point(179, 274);
            this.textBoxfiyat.Name = "textBoxfiyat";
            this.textBoxfiyat.Size = new System.Drawing.Size(128, 22);
            this.textBoxfiyat.TabIndex = 32;
            // 
            // textBoxkira
            // 
            this.textBoxkira.Location = new System.Drawing.Point(179, 236);
            this.textBoxkira.Name = "textBoxkira";
            this.textBoxkira.Size = new System.Drawing.Size(128, 22);
            this.textBoxkira.TabIndex = 31;
            // 
            // checkBoxSatilik
            // 
            this.checkBoxSatilik.AutoSize = true;
            this.checkBoxSatilik.Location = new System.Drawing.Point(15, 270);
            this.checkBoxSatilik.Name = "checkBoxSatilik";
            this.checkBoxSatilik.Size = new System.Drawing.Size(65, 20);
            this.checkBoxSatilik.TabIndex = 29;
            this.checkBoxSatilik.Text = "Satılık";
            this.checkBoxSatilik.UseVisualStyleBackColor = true;
            // 
            // checkBoxkiralık
            // 
            this.checkBoxkiralık.AutoSize = true;
            this.checkBoxkiralık.Location = new System.Drawing.Point(15, 236);
            this.checkBoxkiralık.Name = "checkBoxkiralık";
            this.checkBoxkiralık.Size = new System.Drawing.Size(65, 20);
            this.checkBoxkiralık.TabIndex = 28;
            this.checkBoxkiralık.Text = "Kiralık";
            this.checkBoxkiralık.UseVisualStyleBackColor = true;
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.Location = new System.Drawing.Point(51, 334);
            this.buttonSorgula.Name = "buttonSorgula";
            this.buttonSorgula.Size = new System.Drawing.Size(183, 96);
            this.buttonSorgula.TabIndex = 36;
            this.buttonSorgula.Text = "Sorgula";
            this.buttonSorgula.UseVisualStyleBackColor = true;
            this.buttonSorgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(317, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 308);
            this.listBox1.TabIndex = 37;
            // 
            // buttonduzenleme
            // 
            this.buttonduzenleme.Location = new System.Drawing.Point(331, 352);
            this.buttonduzenleme.Name = "buttonduzenleme";
            this.buttonduzenleme.Size = new System.Drawing.Size(129, 63);
            this.buttonduzenleme.TabIndex = 38;
            this.buttonduzenleme.Text = "Düzenleme";
            this.buttonduzenleme.UseVisualStyleBackColor = true;
            this.buttonduzenleme.Click += new System.EventHandler(this.buttonduzenleme_Click);
            // 
            // buttonsilme
            // 
            this.buttonsilme.Location = new System.Drawing.Point(474, 352);
            this.buttonsilme.Name = "buttonsilme";
            this.buttonsilme.Size = new System.Drawing.Size(129, 62);
            this.buttonsilme.TabIndex = 39;
            this.buttonsilme.Text = "Silme";
            this.buttonsilme.UseVisualStyleBackColor = true;
            this.buttonsilme.Click += new System.EventHandler(this.buttonsilme_Click);
            // 
            // buttonarsiv
            // 
            this.buttonarsiv.Location = new System.Drawing.Point(625, 352);
            this.buttonarsiv.Name = "buttonarsiv";
            this.buttonarsiv.Size = new System.Drawing.Size(139, 61);
            this.buttonarsiv.TabIndex = 40;
            this.buttonarsiv.Text = "Arşivleme";
            this.buttonarsiv.UseVisualStyleBackColor = true;
            this.buttonarsiv.Click += new System.EventHandler(this.buttonarsiv_Click);
            // 
            // SorgulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonarsiv);
            this.Controls.Add(this.buttonsilme);
            this.Controls.Add(this.buttonduzenleme);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSorgula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxfiyat);
            this.Controls.Add(this.textBoxkira);
            this.Controls.Add(this.checkBoxSatilik);
            this.Controls.Add(this.checkBoxkiralık);
            this.Controls.Add(this.comboBoxEvturu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxoda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSemt);
            this.Controls.Add(this.label1);
            this.Name = "SorgulamaForm";
            this.Text = "SorgulamaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxEvturu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSemt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxfiyat;
        private System.Windows.Forms.TextBox textBoxkira;
        private System.Windows.Forms.CheckBox checkBoxSatilik;
        private System.Windows.Forms.CheckBox checkBoxkiralık;
        private System.Windows.Forms.Button buttonSorgula;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonduzenleme;
        private System.Windows.Forms.Button buttonsilme;
        private System.Windows.Forms.Button buttonarsiv;
    }
}