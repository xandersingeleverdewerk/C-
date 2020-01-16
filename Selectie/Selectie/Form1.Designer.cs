namespace Selectie
{
    partial class Selectie
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
            this.Geboortedatum = new System.Windows.Forms.DateTimePicker();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.checkBoxMeisje = new System.Windows.Forms.CheckBox();
            this.checkBoxJongen = new System.Windows.Forms.CheckBox();
            this.dtpSchoolfeest = new System.Windows.Forms.DateTimePicker();
            this.btnMagIkDanAlcoholDrinken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Geboortedatum
            // 
            this.Geboortedatum.Location = new System.Drawing.Point(307, 118);
            this.Geboortedatum.Name = "Geboortedatum";
            this.Geboortedatum.Size = new System.Drawing.Size(220, 22);
            this.Geboortedatum.TabIndex = 1;
            this.Geboortedatum.Value = new System.DateTime(2000, 6, 3, 0, 0, 0, 0);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(307, 173);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(220, 23);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // checkBoxMeisje
            // 
            this.checkBoxMeisje.AutoSize = true;
            this.checkBoxMeisje.Checked = true;
            this.checkBoxMeisje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMeisje.Location = new System.Drawing.Point(307, 146);
            this.checkBoxMeisje.Name = "checkBoxMeisje";
            this.checkBoxMeisje.Size = new System.Drawing.Size(70, 21);
            this.checkBoxMeisje.TabIndex = 3;
            this.checkBoxMeisje.Text = "Meisje";
            this.checkBoxMeisje.UseVisualStyleBackColor = true;
            this.checkBoxMeisje.CheckedChanged += new System.EventHandler(this.CheckBoxMeisje_CheckedChanged);
            // 
            // checkBoxJongen
            // 
            this.checkBoxJongen.AutoSize = true;
            this.checkBoxJongen.Location = new System.Drawing.Point(450, 146);
            this.checkBoxJongen.Name = "checkBoxJongen";
            this.checkBoxJongen.Size = new System.Drawing.Size(77, 21);
            this.checkBoxJongen.TabIndex = 4;
            this.checkBoxJongen.Text = "Jongen";
            this.checkBoxJongen.UseVisualStyleBackColor = true;
            this.checkBoxJongen.CheckedChanged += new System.EventHandler(this.CheckBoxJongen_CheckedChanged);
            // 
            // dtpSchoolfeest
            // 
            this.dtpSchoolfeest.Location = new System.Drawing.Point(12, 118);
            this.dtpSchoolfeest.Name = "dtpSchoolfeest";
            this.dtpSchoolfeest.Size = new System.Drawing.Size(220, 22);
            this.dtpSchoolfeest.TabIndex = 5;
            // 
            // btnMagIkDanAlcoholDrinken
            // 
            this.btnMagIkDanAlcoholDrinken.Location = new System.Drawing.Point(12, 146);
            this.btnMagIkDanAlcoholDrinken.Name = "btnMagIkDanAlcoholDrinken";
            this.btnMagIkDanAlcoholDrinken.Size = new System.Drawing.Size(220, 23);
            this.btnMagIkDanAlcoholDrinken.TabIndex = 6;
            this.btnMagIkDanAlcoholDrinken.Text = "Mag ik dan alcohol drinken?";
            this.btnMagIkDanAlcoholDrinken.UseVisualStyleBackColor = true;
            this.btnMagIkDanAlcoholDrinken.Click += new System.EventHandler(this.BtnMagIkDanAlcoholDrinken_Click);
            // 
            // Selectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMagIkDanAlcoholDrinken);
            this.Controls.Add(this.dtpSchoolfeest);
            this.Controls.Add(this.checkBoxJongen);
            this.Controls.Add(this.checkBoxMeisje);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.Geboortedatum);
            this.Name = "Selectie";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Geboortedatum;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.CheckBox checkBoxMeisje;
        private System.Windows.Forms.CheckBox checkBoxJongen;
        private System.Windows.Forms.DateTimePicker dtpSchoolfeest;
        private System.Windows.Forms.Button btnMagIkDanAlcoholDrinken;
    }
}

