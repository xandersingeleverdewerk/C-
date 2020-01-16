namespace teksten
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
            this.txbRegelnummer = new System.Windows.Forms.TextBox();
            this.btnNaam = new System.Windows.Forms.Button();
            this.txbUitvoer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbRegelnummer
            // 
            this.txbRegelnummer.Location = new System.Drawing.Point(419, 117);
            this.txbRegelnummer.Name = "txbRegelnummer";
            this.txbRegelnummer.Size = new System.Drawing.Size(225, 22);
            this.txbRegelnummer.TabIndex = 0;
            // 
            // btnNaam
            // 
            this.btnNaam.Location = new System.Drawing.Point(419, 145);
            this.btnNaam.Name = "btnNaam";
            this.btnNaam.Size = new System.Drawing.Size(133, 23);
            this.btnNaam.TabIndex = 1;
            this.btnNaam.Text = "verzend nummer";
            this.btnNaam.UseVisualStyleBackColor = true;
            this.btnNaam.Click += new System.EventHandler(this.BtnNaam_Click);
            // 
            // txbUitvoer
            // 
            this.txbUitvoer.Location = new System.Drawing.Point(569, 145);
            this.txbUitvoer.Name = "txbUitvoer";
            this.txbUitvoer.Size = new System.Drawing.Size(75, 23);
            this.txbUitvoer.TabIndex = 3;
            this.txbUitvoer.Text = "sorteren";
            this.txbUitvoer.UseVisualStyleBackColor = true;
            this.txbUitvoer.Click += new System.EventHandler(this.Uitvoer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(225, 110);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbUitvoer);
            this.Controls.Add(this.btnNaam);
            this.Controls.Add(this.txbRegelnummer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbRegelnummer;
        private System.Windows.Forms.Button btnNaam;
        private System.Windows.Forms.Button txbUitvoer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

