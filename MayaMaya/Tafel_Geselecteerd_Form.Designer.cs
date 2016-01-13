namespace MayaMaya
{
    partial class Tafel_Geselecteerd_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Tafelnaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Lunch = new System.Windows.Forms.Button();
            this.btn_Diner = new System.Windows.Forms.Button();
            this.btn_Dranken = new System.Windows.Forms.Button();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Tafelnaam);
            this.panel1.Location = new System.Drawing.Point(284, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bestelling overzicht";
            // 
            // lbl_Tafelnaam
            // 
            this.lbl_Tafelnaam.AutoSize = true;
            this.lbl_Tafelnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tafelnaam.Location = new System.Drawing.Point(56, 11);
            this.lbl_Tafelnaam.Name = "lbl_Tafelnaam";
            this.lbl_Tafelnaam.Size = new System.Drawing.Size(87, 29);
            this.lbl_Tafelnaam.TabIndex = 0;
            this.lbl_Tafelnaam.Text = "Tafel 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keuzemenu:";
            // 
            // btn_Lunch
            // 
            this.btn_Lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lunch.Location = new System.Drawing.Point(284, 246);
            this.btn_Lunch.Name = "btn_Lunch";
            this.btn_Lunch.Size = new System.Drawing.Size(200, 47);
            this.btn_Lunch.TabIndex = 2;
            this.btn_Lunch.Text = "Lunch";
            this.btn_Lunch.UseVisualStyleBackColor = true;
            this.btn_Lunch.Click += new System.EventHandler(this.btn_Lunch_Click);
            // 
            // btn_Diner
            // 
            this.btn_Diner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Diner.Location = new System.Drawing.Point(284, 336);
            this.btn_Diner.Name = "btn_Diner";
            this.btn_Diner.Size = new System.Drawing.Size(200, 47);
            this.btn_Diner.TabIndex = 3;
            this.btn_Diner.Text = "Diner";
            this.btn_Diner.UseVisualStyleBackColor = true;
            this.btn_Diner.Click += new System.EventHandler(this.btn_Diner_Click);
            // 
            // btn_Dranken
            // 
            this.btn_Dranken.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dranken.Location = new System.Drawing.Point(284, 426);
            this.btn_Dranken.Name = "btn_Dranken";
            this.btn_Dranken.Size = new System.Drawing.Size(200, 47);
            this.btn_Dranken.TabIndex = 4;
            this.btn_Dranken.Text = "Dranken";
            this.btn_Dranken.UseVisualStyleBackColor = true;
            this.btn_Dranken.Click += new System.EventHandler(this.btn_Dranken_Click);
            // 
            // btn_Terug
            // 
            this.btn_Terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Terug.Location = new System.Drawing.Point(12, 536);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(200, 47);
            this.btn_Terug.TabIndex = 5;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // Tafel_Geselecteerd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.btn_Dranken);
            this.Controls.Add(this.btn_Diner);
            this.Controls.Add(this.btn_Lunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Tafel_Geselecteerd_Form";
            this.Text = "Tafel_Geselecteerd_Form";
            this.Load += new System.EventHandler(this.Tafel_Geselecteerd_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Tafelnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Lunch;
        private System.Windows.Forms.Button btn_Diner;
        private System.Windows.Forms.Button btn_Dranken;
        private System.Windows.Forms.Button btn_Terug;
    }
}