namespace KelimeDefDesk
{
    partial class KelimeEkleForm
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
            this.kelimeLabel = new System.Windows.Forms.Label();
            this.kelimeTextBox = new System.Windows.Forms.TextBox();
            this.karsilikLabel = new System.Windows.Forms.Label();
            this.karsilikTextBox = new System.Windows.Forms.TextBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.geriDonButton = new System.Windows.Forms.Button();
            this.karsilikListBox = new System.Windows.Forms.ListBox();
            this.kelimeListBox = new System.Windows.Forms.ListBox();
            this.silButton = new System.Windows.Forms.Button();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.bildirimLabel = new System.Windows.Forms.Label();
            this.bildirimTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kelimeLabel
            // 
            this.kelimeLabel.AutoSize = true;
            this.kelimeLabel.Location = new System.Drawing.Point(34, 67);
            this.kelimeLabel.Name = "kelimeLabel";
            this.kelimeLabel.Size = new System.Drawing.Size(60, 21);
            this.kelimeLabel.TabIndex = 0;
            this.kelimeLabel.Text = "Kelime:";
            // 
            // kelimeTextBox
            // 
            this.kelimeTextBox.Location = new System.Drawing.Point(117, 59);
            this.kelimeTextBox.Name = "kelimeTextBox";
            this.kelimeTextBox.Size = new System.Drawing.Size(188, 29);
            this.kelimeTextBox.TabIndex = 1;
            // 
            // karsilikLabel
            // 
            this.karsilikLabel.AutoSize = true;
            this.karsilikLabel.Location = new System.Drawing.Point(34, 102);
            this.karsilikLabel.Name = "karsilikLabel";
            this.karsilikLabel.Size = new System.Drawing.Size(63, 21);
            this.karsilikLabel.TabIndex = 0;
            this.karsilikLabel.Text = "Karşılık:";
            // 
            // karsilikTextBox
            // 
            this.karsilikTextBox.Location = new System.Drawing.Point(117, 94);
            this.karsilikTextBox.Name = "karsilikTextBox";
            this.karsilikTextBox.Size = new System.Drawing.Size(188, 29);
            this.karsilikTextBox.TabIndex = 2;
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ekleButton.ForeColor = System.Drawing.Color.White;
            this.ekleButton.Location = new System.Drawing.Point(195, 129);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(110, 29);
            this.ekleButton.TabIndex = 3;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = false;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // geriDonButton
            // 
            this.geriDonButton.BackColor = System.Drawing.Color.Black;
            this.geriDonButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriDonButton.Location = new System.Drawing.Point(266, 9);
            this.geriDonButton.Margin = new System.Windows.Forms.Padding(0);
            this.geriDonButton.Name = "geriDonButton";
            this.geriDonButton.Size = new System.Drawing.Size(75, 23);
            this.geriDonButton.TabIndex = 5;
            this.geriDonButton.Text = "geri dön";
            this.geriDonButton.UseVisualStyleBackColor = false;
            this.geriDonButton.Click += new System.EventHandler(this.geriDonButton_Click);
            // 
            // karsilikListBox
            // 
            this.karsilikListBox.FormattingEnabled = true;
            this.karsilikListBox.HorizontalScrollbar = true;
            this.karsilikListBox.ItemHeight = 21;
            this.karsilikListBox.Location = new System.Drawing.Point(178, 184);
            this.karsilikListBox.Name = "karsilikListBox";
            this.karsilikListBox.Size = new System.Drawing.Size(160, 214);
            this.karsilikListBox.TabIndex = 5;
            this.karsilikListBox.SelectedIndexChanged += new System.EventHandler(this.karsilikListBox_SelectedIndexChanged);
            // 
            // kelimeListBox
            // 
            this.kelimeListBox.FormattingEnabled = true;
            this.kelimeListBox.HorizontalScrollbar = true;
            this.kelimeListBox.ItemHeight = 21;
            this.kelimeListBox.Location = new System.Drawing.Point(12, 184);
            this.kelimeListBox.Name = "kelimeListBox";
            this.kelimeListBox.Size = new System.Drawing.Size(160, 214);
            this.kelimeListBox.TabIndex = 5;
            this.kelimeListBox.SelectedIndexChanged += new System.EventHandler(this.kelimeListBox_SelectedIndexChanged);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.silButton.ForeColor = System.Drawing.Color.White;
            this.silButton.Location = new System.Drawing.Point(117, 129);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(72, 29);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kaydetButton.ForeColor = System.Drawing.Color.White;
            this.kaydetButton.Location = new System.Drawing.Point(228, 409);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(110, 29);
            this.kaydetButton.TabIndex = 5;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = false;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // bildirimLabel
            // 
            this.bildirimLabel.AutoSize = true;
            this.bildirimLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bildirimLabel.Location = new System.Drawing.Point(225, 393);
            this.bildirimLabel.Name = "bildirimLabel";
            this.bildirimLabel.Size = new System.Drawing.Size(0, 13);
            this.bildirimLabel.TabIndex = 6;
            // 
            // bildirimTxt
            // 
            this.bildirimTxt.AutoSize = true;
            this.bildirimTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bildirimTxt.Location = new System.Drawing.Point(187, 184);
            this.bildirimTxt.Name = "bildirimTxt";
            this.bildirimTxt.Size = new System.Drawing.Size(0, 13);
            this.bildirimTxt.TabIndex = 6;
            // 
            // KelimeEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.bildirimTxt);
            this.Controls.Add(this.bildirimLabel);
            this.Controls.Add(this.kelimeListBox);
            this.Controls.Add(this.karsilikListBox);
            this.Controls.Add(this.geriDonButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.karsilikTextBox);
            this.Controls.Add(this.karsilikLabel);
            this.Controls.Add(this.kelimeTextBox);
            this.Controls.Add(this.kelimeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "KelimeEkleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KelimeEkleForm";
            this.Load += new System.EventHandler(this.KelimeEkleForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KelimeEkleForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kelimeLabel;
        private System.Windows.Forms.TextBox kelimeTextBox;
        private System.Windows.Forms.Label karsilikLabel;
        private System.Windows.Forms.TextBox karsilikTextBox;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button geriDonButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Label bildirimLabel;
        private System.Windows.Forms.Label bildirimTxt;
        public System.Windows.Forms.ListBox karsilikListBox;
        public System.Windows.Forms.ListBox kelimeListBox;
    }
}