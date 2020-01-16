namespace Number
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
            this.components = new System.ComponentModel.Container();
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(40, 35);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(50, 22);
            this.txbGetal1.TabIndex = 0;
            this.txbGetal1.Text = "10";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(90, 90);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 25);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(165, 35);
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(50, 22);
            this.txbGetal2.TabIndex = 2;
            this.txbGetal2.Text = "5";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(101, 147);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(46, 17);
            this.lblAntwoord.TabIndex = 3;
            this.lblAntwoord.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

