namespace DAModel.Forms
{
    partial class YeniKeywordEkleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keywordEkleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.epostaComboBox = new System.Windows.Forms.ComboBox();
            this.atilacakMailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keywordAdiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keywordEkleButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.epostaComboBox);
            this.groupBox1.Controls.Add(this.keywordAdiTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ekle";
            // 
            // keywordEkleButton
            // 
            this.keywordEkleButton.Location = new System.Drawing.Point(147, 98);
            this.keywordEkleButton.Name = "keywordEkleButton";
            this.keywordEkleButton.Size = new System.Drawing.Size(113, 23);
            this.keywordEkleButton.TabIndex = 4;
            this.keywordEkleButton.Text = "Ekle";
            this.keywordEkleButton.UseVisualStyleBackColor = true;
            this.keywordEkleButton.Click += new System.EventHandler(this.keywordEkleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-posta:";
            // 
            // epostaComboBox
            // 
            this.epostaComboBox.DataSource = this.atilacakMailBindingSource;
            this.epostaComboBox.DisplayMember = "MailName";
            this.epostaComboBox.FormattingEnabled = true;
            this.epostaComboBox.Location = new System.Drawing.Point(81, 62);
            this.epostaComboBox.Name = "epostaComboBox";
            this.epostaComboBox.Size = new System.Drawing.Size(177, 21);
            this.epostaComboBox.TabIndex = 2;
            this.epostaComboBox.ValueMember = "MailName";
            // 
            // atilacakMailBindingSource
            // 
            this.atilacakMailBindingSource.DataSource = typeof(DAModel.AtilacakMail);
            // 
            // keywordAdiTextBox
            // 
            this.keywordAdiTextBox.Location = new System.Drawing.Point(81, 26);
            this.keywordAdiTextBox.Name = "keywordAdiTextBox";
            this.keywordAdiTextBox.Size = new System.Drawing.Size(177, 20);
            this.keywordAdiTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword Adı:";
            // 
            // YeniKeywordEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 175);
            this.Controls.Add(this.groupBox1);
            this.Name = "YeniKeywordEkleForm";
            this.Text = "YeniKeywordEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeniKeywordEkleForm_FormClosing);
            this.Load += new System.EventHandler(this.YeniKeywordEkleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button keywordEkleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox epostaComboBox;
        private System.Windows.Forms.TextBox keywordAdiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource atilacakMailBindingSource;

    }
}