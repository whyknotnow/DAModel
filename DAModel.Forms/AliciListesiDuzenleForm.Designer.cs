namespace DAModel.Forms
{
    partial class AliciListesiDuzenleForm
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
            this.aliciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aliciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciGüncelleButton = new System.Windows.Forms.Button();
            this.yeniAliciKayitButton = new System.Windows.Forms.Button();
            this.aliciKayitSilButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniAliciEpostaAdresTextBox = new System.Windows.Forms.TextBox();
            this.yeniAliciAdSoyadTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aliciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliciDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aliciBindingSource
            // 
            this.aliciBindingSource.DataSource = typeof(DAModel.Alici);
            // 
            // aliciDataGridView
            // 
            this.aliciDataGridView.AllowUserToAddRows = false;
            this.aliciDataGridView.AllowUserToDeleteRows = false;
            this.aliciDataGridView.AllowUserToOrderColumns = true;
            this.aliciDataGridView.AutoGenerateColumns = false;
            this.aliciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aliciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.aliciDataGridView.DataSource = this.aliciBindingSource;
            this.aliciDataGridView.Location = new System.Drawing.Point(12, 12);
            this.aliciDataGridView.Name = "aliciDataGridView";
            this.aliciDataGridView.Size = new System.Drawing.Size(494, 236);
            this.aliciDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AdSoyad";
            this.dataGridViewTextBoxColumn2.HeaderText = "AdSoyad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MailAdres";
            this.dataGridViewTextBoxColumn3.HeaderText = "MailAdres";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // aliciGüncelleButton
            // 
            this.aliciGüncelleButton.Location = new System.Drawing.Point(108, 261);
            this.aliciGüncelleButton.Name = "aliciGüncelleButton";
            this.aliciGüncelleButton.Size = new System.Drawing.Size(131, 23);
            this.aliciGüncelleButton.TabIndex = 2;
            this.aliciGüncelleButton.Text = "Güncelle ve Yenile";
            this.aliciGüncelleButton.UseVisualStyleBackColor = true;
            this.aliciGüncelleButton.Click += new System.EventHandler(this.aliciGüncelleButton_Click);
            // 
            // yeniAliciKayitButton
            // 
            this.yeniAliciKayitButton.Location = new System.Drawing.Point(6, 206);
            this.yeniAliciKayitButton.Name = "yeniAliciKayitButton";
            this.yeniAliciKayitButton.Size = new System.Drawing.Size(211, 23);
            this.yeniAliciKayitButton.TabIndex = 3;
            this.yeniAliciKayitButton.Text = "Ekleme işlemini tamamla";
            this.yeniAliciKayitButton.UseVisualStyleBackColor = true;
            this.yeniAliciKayitButton.Click += new System.EventHandler(this.yeniAliciKayitButton_Click);
            // 
            // aliciKayitSilButton
            // 
            this.aliciKayitSilButton.Location = new System.Drawing.Point(12, 261);
            this.aliciKayitSilButton.Name = "aliciKayitSilButton";
            this.aliciKayitSilButton.Size = new System.Drawing.Size(90, 23);
            this.aliciKayitSilButton.TabIndex = 4;
            this.aliciKayitSilButton.Text = "Seçili Kaydı Sil";
            this.aliciKayitSilButton.UseVisualStyleBackColor = true;
            this.aliciKayitSilButton.Click += new System.EventHandler(this.aliciKayitSilButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yeniAliciEpostaAdresTextBox);
            this.groupBox1.Controls.Add(this.yeniAliciAdSoyadTextBox);
            this.groupBox1.Controls.Add(this.yeniAliciKayitButton);
            this.groupBox1.Location = new System.Drawing.Point(513, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Alıcı Kaydı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eposta Adresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alıcının Ad - Soyadı:";
            // 
            // yeniAliciEpostaAdresTextBox
            // 
            this.yeniAliciEpostaAdresTextBox.Location = new System.Drawing.Point(9, 80);
            this.yeniAliciEpostaAdresTextBox.Name = "yeniAliciEpostaAdresTextBox";
            this.yeniAliciEpostaAdresTextBox.Size = new System.Drawing.Size(211, 20);
            this.yeniAliciEpostaAdresTextBox.TabIndex = 1;
            // 
            // yeniAliciAdSoyadTextBox
            // 
            this.yeniAliciAdSoyadTextBox.Location = new System.Drawing.Point(9, 41);
            this.yeniAliciAdSoyadTextBox.Name = "yeniAliciAdSoyadTextBox";
            this.yeniAliciAdSoyadTextBox.Size = new System.Drawing.Size(211, 20);
            this.yeniAliciAdSoyadTextBox.TabIndex = 0;
            // 
            // AliciListesiDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aliciKayitSilButton);
            this.Controls.Add(this.aliciGüncelleButton);
            this.Controls.Add(this.aliciDataGridView);
            this.Name = "AliciListesiDuzenleForm";
            this.Text = "Alıcılar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AliciListesiDuzenleForm_FormClosing);
            this.Load += new System.EventHandler(this.AliciListesiDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aliciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliciDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource aliciBindingSource;
        private System.Windows.Forms.DataGridView aliciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button aliciGüncelleButton;
        private System.Windows.Forms.Button yeniAliciKayitButton;
        private System.Windows.Forms.Button aliciKayitSilButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yeniAliciEpostaAdresTextBox;
        private System.Windows.Forms.TextBox yeniAliciAdSoyadTextBox;
    }
}