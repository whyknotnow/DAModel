namespace DAModel.Forms
{
    partial class MainForm
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
            this.htmlDuzenlemeButon = new System.Windows.Forms.Button();
            this.veritabaniIslemButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // htmlDuzenlemeButon
            // 
            this.htmlDuzenlemeButon.Location = new System.Drawing.Point(119, 245);
            this.htmlDuzenlemeButon.Name = "htmlDuzenlemeButon";
            this.htmlDuzenlemeButon.Size = new System.Drawing.Size(146, 23);
            this.htmlDuzenlemeButon.TabIndex = 0;
            this.htmlDuzenlemeButon.Text = "HTML Düzenleme İşlemleri";
            this.htmlDuzenlemeButon.UseVisualStyleBackColor = true;
            this.htmlDuzenlemeButon.Click += new System.EventHandler(this.htmlDuzenlemeButon_Click);
            // 
            // veritabaniIslemButon
            // 
            this.veritabaniIslemButon.Location = new System.Drawing.Point(271, 245);
            this.veritabaniIslemButon.Name = "veritabaniIslemButon";
            this.veritabaniIslemButon.Size = new System.Drawing.Size(124, 23);
            this.veritabaniIslemButon.TabIndex = 1;
            this.veritabaniIslemButon.Text = "Veritabanı İşlemleri";
            this.veritabaniIslemButon.UseVisualStyleBackColor = true;
            this.veritabaniIslemButon.Click += new System.EventHandler(this.veritabaniIslemButon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 280);
            this.Controls.Add(this.veritabaniIslemButon);
            this.Controls.Add(this.htmlDuzenlemeButon);
            this.Name = "MainForm";
            this.Text = "DAMesaj / Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button htmlDuzenlemeButon;
        private System.Windows.Forms.Button veritabaniIslemButon;
    }
}

