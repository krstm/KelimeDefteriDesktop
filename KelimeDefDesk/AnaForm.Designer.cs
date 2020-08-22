namespace KelimeDefDesk
{
    partial class AnaForm
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
            this.kelimeEkleButton = new System.Windows.Forms.Button();
            this.sinavButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kelimeEkleButton
            // 
            this.kelimeEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kelimeEkleButton.ForeColor = System.Drawing.Color.White;
            this.kelimeEkleButton.Location = new System.Drawing.Point(12, 158);
            this.kelimeEkleButton.Name = "kelimeEkleButton";
            this.kelimeEkleButton.Size = new System.Drawing.Size(326, 40);
            this.kelimeEkleButton.TabIndex = 1;
            this.kelimeEkleButton.Text = "Kelime Ekle";
            this.kelimeEkleButton.UseVisualStyleBackColor = false;
            this.kelimeEkleButton.Click += new System.EventHandler(this.kelimeEkleButton_Click);
            // 
            // sinavButton
            // 
            this.sinavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sinavButton.ForeColor = System.Drawing.Color.White;
            this.sinavButton.Location = new System.Drawing.Point(12, 204);
            this.sinavButton.Name = "sinavButton";
            this.sinavButton.Size = new System.Drawing.Size(326, 40);
            this.sinavButton.TabIndex = 2;
            this.sinavButton.Text = "Sınav";
            this.sinavButton.UseVisualStyleBackColor = false;
            this.sinavButton.Click += new System.EventHandler(this.sinavButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cikisButton.ForeColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(12, 250);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(326, 40);
            this.cikisButton.TabIndex = 3;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.sinavButton);
            this.Controls.Add(this.kelimeEkleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kelimeEkleButton;
        private System.Windows.Forms.Button sinavButton;
        private System.Windows.Forms.Button cikisButton;
    }
}