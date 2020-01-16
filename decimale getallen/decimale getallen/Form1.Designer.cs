namespace decimale_getallen
{
    partial class Form1
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
            this.berekenen = new System.Windows.Forms.Button();
            this.txbUitvoer = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // berekenen
            // 
            this.berekenen.Location = new System.Drawing.Point(268, 115);
            this.berekenen.Name = "berekenen";
            this.berekenen.Size = new System.Drawing.Size(184, 23);
            this.berekenen.TabIndex = 0;
            this.berekenen.Text = "button1";
            this.berekenen.UseVisualStyleBackColor = true;
            this.berekenen.Click += new System.EventHandler(this.Berekenen_Click);
            // 
            // txbUitvoer
            // 
            this.txbUitvoer.Location = new System.Drawing.Point(268, 144);
            this.txbUitvoer.Multiline = true;
            this.txbUitvoer.Name = "txbUitvoer";
            this.txbUitvoer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbUitvoer.Size = new System.Drawing.Size(184, 163);
            this.txbUitvoer.TabIndex = 1;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(497, 115);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(91, 23);
            this.btnResize.TabIndex = 2;
            this.btnResize.Text = "verzenden";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.txbUitvoer);
            this.Controls.Add(this.berekenen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button berekenen;
        private System.Windows.Forms.TextBox txbUitvoer;
        private System.Windows.Forms.Button btnResize;
    }
}

