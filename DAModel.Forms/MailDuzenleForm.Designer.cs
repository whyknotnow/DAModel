namespace DAModel.Forms
{
    partial class MailDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailDuzenleForm));
            this.atilacakMailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atilacakMailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.atilacakMailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupbox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yeniEpostaAdTextBox = new System.Windows.Forms.TextBox();
            this.yeniEpostaKonumuTextBox = new System.Windows.Forms.TextBox();
            this.yeniEpostaEkleButton = new System.Windows.Forms.Button();
            this.epostaSilButton = new System.Windows.Forms.Button();
            this.epostaGuncelleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailBindingNavigator)).BeginInit();
            this.atilacakMailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailDataGridView)).BeginInit();
            this.grupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atilacakMailBindingSource
            // 
            this.atilacakMailBindingSource.DataSource = typeof(DAModel.AtilacakMail);
            // 
            // atilacakMailBindingNavigator
            // 
            this.atilacakMailBindingNavigator.AddNewItem = null;
            this.atilacakMailBindingNavigator.BindingSource = this.atilacakMailBindingSource;
            this.atilacakMailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.atilacakMailBindingNavigator.DeleteItem = null;
            this.atilacakMailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.atilacakMailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.atilacakMailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.atilacakMailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.atilacakMailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.atilacakMailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.atilacakMailBindingNavigator.Name = "atilacakMailBindingNavigator";
            this.atilacakMailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.atilacakMailBindingNavigator.Size = new System.Drawing.Size(617, 25);
            this.atilacakMailBindingNavigator.TabIndex = 0;
            this.atilacakMailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // atilacakMailDataGridView
            // 
            this.atilacakMailDataGridView.AllowUserToAddRows = false;
            this.atilacakMailDataGridView.AllowUserToDeleteRows = false;
            this.atilacakMailDataGridView.AutoGenerateColumns = false;
            this.atilacakMailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atilacakMailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.atilacakMailDataGridView.DataSource = this.atilacakMailBindingSource;
            this.atilacakMailDataGridView.Location = new System.Drawing.Point(12, 28);
            this.atilacakMailDataGridView.Name = "atilacakMailDataGridView";
            this.atilacakMailDataGridView.Size = new System.Drawing.Size(594, 244);
            this.atilacakMailDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MailName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Eposta Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MailPath";
            this.dataGridViewTextBoxColumn3.HeaderText = "Eposta Dosya Yolu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // grupbox1
            // 
            this.grupbox1.Controls.Add(this.yeniEpostaEkleButton);
            this.grupbox1.Controls.Add(this.yeniEpostaKonumuTextBox);
            this.grupbox1.Controls.Add(this.yeniEpostaAdTextBox);
            this.grupbox1.Controls.Add(this.label2);
            this.grupbox1.Controls.Add(this.label1);
            this.grupbox1.Location = new System.Drawing.Point(12, 278);
            this.grupbox1.Name = "grupbox1";
            this.grupbox1.Size = new System.Drawing.Size(272, 112);
            this.grupbox1.TabIndex = 2;
            this.grupbox1.TabStop = false;
            this.grupbox1.Text = "Yeni Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eposta Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Konumu:";
            // 
            // yeniEpostaAdTextBox
            // 
            this.yeniEpostaAdTextBox.Location = new System.Drawing.Point(87, 19);
            this.yeniEpostaAdTextBox.Name = "yeniEpostaAdTextBox";
            this.yeniEpostaAdTextBox.Size = new System.Drawing.Size(179, 20);
            this.yeniEpostaAdTextBox.TabIndex = 2;
            // 
            // yeniEpostaKonumuTextBox
            // 
            this.yeniEpostaKonumuTextBox.Location = new System.Drawing.Point(87, 53);
            this.yeniEpostaKonumuTextBox.Name = "yeniEpostaKonumuTextBox";
            this.yeniEpostaKonumuTextBox.Size = new System.Drawing.Size(179, 20);
            this.yeniEpostaKonumuTextBox.TabIndex = 3;
            // 
            // yeniEpostaEkleButton
            // 
            this.yeniEpostaEkleButton.Location = new System.Drawing.Point(152, 83);
            this.yeniEpostaEkleButton.Name = "yeniEpostaEkleButton";
            this.yeniEpostaEkleButton.Size = new System.Drawing.Size(113, 23);
            this.yeniEpostaEkleButton.TabIndex = 4;
            this.yeniEpostaEkleButton.Text = "Ekle";
            this.yeniEpostaEkleButton.UseVisualStyleBackColor = true;
            this.yeniEpostaEkleButton.Click += new System.EventHandler(this.yeniEpostaEkleButton_Click);
            // 
            // epostaSilButton
            // 
            this.epostaSilButton.Location = new System.Drawing.Point(461, 279);
            this.epostaSilButton.Name = "epostaSilButton";
            this.epostaSilButton.Size = new System.Drawing.Size(144, 23);
            this.epostaSilButton.TabIndex = 3;
            this.epostaSilButton.Text = "Seçili Kaydı Sil";
            this.epostaSilButton.UseVisualStyleBackColor = true;
            this.epostaSilButton.Click += new System.EventHandler(this.epostaSilButton_Click);
            // 
            // epostaGuncelleButton
            // 
            this.epostaGuncelleButton.Location = new System.Drawing.Point(328, 278);
            this.epostaGuncelleButton.Name = "epostaGuncelleButton";
            this.epostaGuncelleButton.Size = new System.Drawing.Size(127, 23);
            this.epostaGuncelleButton.TabIndex = 4;
            this.epostaGuncelleButton.Text = "Güncelle";
            this.epostaGuncelleButton.UseVisualStyleBackColor = true;
            // 
            // MailDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 402);
            this.Controls.Add(this.epostaGuncelleButton);
            this.Controls.Add(this.epostaSilButton);
            this.Controls.Add(this.grupbox1);
            this.Controls.Add(this.atilacakMailDataGridView);
            this.Controls.Add(this.atilacakMailBindingNavigator);
            this.Name = "MailDuzenleForm";
            this.Text = "MailDuzenleForm";
            this.Load += new System.EventHandler(this.MailDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailBindingNavigator)).EndInit();
            this.atilacakMailBindingNavigator.ResumeLayout(false);
            this.atilacakMailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atilacakMailDataGridView)).EndInit();
            this.grupbox1.ResumeLayout(false);
            this.grupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource atilacakMailBindingSource;
        private System.Windows.Forms.BindingNavigator atilacakMailBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView atilacakMailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox grupbox1;
        private System.Windows.Forms.Button yeniEpostaEkleButton;
        private System.Windows.Forms.TextBox yeniEpostaKonumuTextBox;
        private System.Windows.Forms.TextBox yeniEpostaAdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button epostaSilButton;
        private System.Windows.Forms.Button epostaGuncelleButton;
    }
}