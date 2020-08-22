namespace KelimeDefDesk
{
    partial class SinavForm
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
            this.cevap1Button = new System.Windows.Forms.Button();
            this.cevap2Button = new System.Windows.Forms.Button();
            this.cevap3Button = new System.Windows.Forms.Button();
            this.cevap4Button = new System.Windows.Forms.Button();
            this.geriDonButton = new System.Windows.Forms.Button();
            this.ileriButton = new System.Windows.Forms.Button();
            this.soruButton = new System.Windows.Forms.Button();
            this.puanLabel = new System.Windows.Forms.Label();
            this.dogruCevapLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cevap1Button
            // 
            this.cevap1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cevap1Button.ForeColor = System.Drawing.Color.White;
            this.cevap1Button.Location = new System.Drawing.Point(73, 165);
            this.cevap1Button.Name = "cevap1Button";
            this.cevap1Button.Size = new System.Drawing.Size(211, 40);
            this.cevap1Button.TabIndex = 1;
            this.cevap1Button.Text = "1";
            this.cevap1Button.UseVisualStyleBackColor = false;
            this.cevap1Button.Click += new System.EventHandler(this.cevapButton_Click);
            // 
            // cevap2Button
            // 
            this.cevap2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cevap2Button.ForeColor = System.Drawing.Color.White;
            this.cevap2Button.Location = new System.Drawing.Point(73, 211);
            this.cevap2Button.Name = "cevap2Button";
            this.cevap2Button.Size = new System.Drawing.Size(211, 40);
            this.cevap2Button.TabIndex = 2;
            this.cevap2Button.Text = "2";
            this.cevap2Button.UseVisualStyleBackColor = false;
            this.cevap2Button.Click += new System.EventHandler(this.cevapButton_Click);
            // 
            // cevap3Button
            // 
            this.cevap3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cevap3Button.ForeColor = System.Drawing.Color.White;
            this.cevap3Button.Location = new System.Drawing.Point(73, 257);
            this.cevap3Button.Name = "cevap3Button";
            this.cevap3Button.Size = new System.Drawing.Size(211, 40);
            this.cevap3Button.TabIndex = 3;
            this.cevap3Button.Text = "3";
            this.cevap3Button.UseVisualStyleBackColor = false;
            this.cevap3Button.Click += new System.EventHandler(this.cevapButton_Click);
            // 
            // cevap4Button
            // 
            this.cevap4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cevap4Button.ForeColor = System.Drawing.Color.White;
            this.cevap4Button.Location = new System.Drawing.Point(73, 303);
            this.cevap4Button.Name = "cevap4Button";
            this.cevap4Button.Size = new System.Drawing.Size(211, 40);
            this.cevap4Button.TabIndex = 4;
            this.cevap4Button.Text = "4";
            this.cevap4Button.UseVisualStyleBackColor = false;
            this.cevap4Button.Click += new System.EventHandler(this.cevapButton_Click);
            // 
            // geriDonButton
            // 
            this.geriDonButton.BackColor = System.Drawing.Color.Black;
            this.geriDonButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriDonButton.Location = new System.Drawing.Point(263, 12);
            this.geriDonButton.Margin = new System.Windows.Forms.Padding(0);
            this.geriDonButton.Name = "geriDonButton";
            this.geriDonButton.Size = new System.Drawing.Size(75, 23);
            this.geriDonButton.TabIndex = 5;
            this.geriDonButton.Text = "geri dön";
            this.geriDonButton.UseVisualStyleBackColor = false;
            this.geriDonButton.Click += new System.EventHandler(this.geriDonButton_Click);
            // 
            // ileriButton
            // 
            this.ileriButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ileriButton.ForeColor = System.Drawing.Color.White;
            this.ileriButton.Location = new System.Drawing.Point(174, 363);
            this.ileriButton.Name = "ileriButton";
            this.ileriButton.Size = new System.Drawing.Size(110, 29);
            this.ileriButton.TabIndex = 5;
            this.ileriButton.Text = "İleri";
            this.ileriButton.UseVisualStyleBackColor = false;
            this.ileriButton.Visible = false;
            this.ileriButton.Click += new System.EventHandler(this.ileriButton_Click);
            // 
            // soruButton
            // 
            this.soruButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.soruButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.soruButton.ForeColor = System.Drawing.Color.White;
            this.soruButton.Location = new System.Drawing.Point(73, 84);
            this.soruButton.Name = "soruButton";
            this.soruButton.Size = new System.Drawing.Size(211, 40);
            this.soruButton.TabIndex = 1;
            this.soruButton.Text = "Kelime";
            this.soruButton.UseVisualStyleBackColor = false;
            // 
            // puanLabel
            // 
            this.puanLabel.AutoSize = true;
            this.puanLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.Location = new System.Drawing.Point(12, 14);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(51, 17);
            this.puanLabel.TabIndex = 6;
            this.puanLabel.Text = "puan: 0";
            // 
            // dogruCevapLabel
            // 
            this.dogruCevapLabel.AutoSize = true;
            this.dogruCevapLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogruCevapLabel.Location = new System.Drawing.Point(70, 127);
            this.dogruCevapLabel.Name = "dogruCevapLabel";
            this.dogruCevapLabel.Size = new System.Drawing.Size(0, 17);
            this.dogruCevapLabel.TabIndex = 6;
            // 
            // SinavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.dogruCevapLabel);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.ileriButton);
            this.Controls.Add(this.geriDonButton);
            this.Controls.Add(this.cevap4Button);
            this.Controls.Add(this.cevap3Button);
            this.Controls.Add(this.cevap2Button);
            this.Controls.Add(this.soruButton);
            this.Controls.Add(this.cevap1Button);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "SinavForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinavForm";
            this.Load += new System.EventHandler(this.SinavForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SinavForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cevap1Button;
        private System.Windows.Forms.Button cevap2Button;
        private System.Windows.Forms.Button cevap3Button;
        private System.Windows.Forms.Button cevap4Button;
        private System.Windows.Forms.Button geriDonButton;
        private System.Windows.Forms.Button ileriButton;
        private System.Windows.Forms.Button soruButton;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label dogruCevapLabel;
    }
}