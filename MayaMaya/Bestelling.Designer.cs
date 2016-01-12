﻿namespace MayaMaya
{
    partial class Bestelling
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
            this.ListViewLunch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lunch = new System.Windows.Forms.TabPage();
            this.Diner = new System.Windows.Forms.TabPage();
            this.ListViewDiner = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dranken = new System.Windows.Forms.TabPage();
            this.ListViewDranken = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewBestellijst = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotaalPrijs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_BestellingOverzicht = new System.Windows.Forms.Label();
            this.lbl_Tafelnummer = new System.Windows.Forms.Label();
            this.btn_Opslaan = new System.Windows.Forms.Button();
            this.lbl_Terug = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Lunch.SuspendLayout();
            this.Diner.SuspendLayout();
            this.Dranken.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewLunch
            // 
            this.ListViewLunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader9});
            this.ListViewLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewLunch.FullRowSelect = true;
            this.ListViewLunch.GridLines = true;
            this.ListViewLunch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewLunch.Location = new System.Drawing.Point(0, 0);
            this.ListViewLunch.Name = "ListViewLunch";
            this.ListViewLunch.Size = new System.Drawing.Size(719, 436);
            this.ListViewLunch.TabIndex = 0;
            this.ListViewLunch.UseCompatibleStateImageBehavior = false;
            this.ListViewLunch.View = System.Windows.Forms.View.Details;
            this.ListViewLunch.SelectedIndexChanged += new System.EventHandler(this.ListViewLunch_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 555;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voorraad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prijs";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lunch);
            this.tabControl1.Controls.Add(this.Diner);
            this.tabControl1.Controls.Add(this.Dranken);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 472);
            this.tabControl1.TabIndex = 1;
            // 
            // Lunch
            // 
            this.Lunch.Controls.Add(this.ListViewLunch);
            this.Lunch.Location = new System.Drawing.Point(4, 33);
            this.Lunch.Name = "Lunch";
            this.Lunch.Padding = new System.Windows.Forms.Padding(3);
            this.Lunch.Size = new System.Drawing.Size(719, 435);
            this.Lunch.TabIndex = 0;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = true;
            // 
            // Diner
            // 
            this.Diner.Controls.Add(this.ListViewDiner);
            this.Diner.Location = new System.Drawing.Point(4, 33);
            this.Diner.Name = "Diner";
            this.Diner.Padding = new System.Windows.Forms.Padding(3);
            this.Diner.Size = new System.Drawing.Size(719, 435);
            this.Diner.TabIndex = 1;
            this.Diner.Text = "Diner";
            this.Diner.UseVisualStyleBackColor = true;
            // 
            // ListViewDiner
            // 
            this.ListViewDiner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10});
            this.ListViewDiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewDiner.FullRowSelect = true;
            this.ListViewDiner.GridLines = true;
            this.ListViewDiner.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewDiner.Location = new System.Drawing.Point(0, 0);
            this.ListViewDiner.Name = "ListViewDiner";
            this.ListViewDiner.Size = new System.Drawing.Size(719, 436);
            this.ListViewDiner.TabIndex = 4;
            this.ListViewDiner.UseCompatibleStateImageBehavior = false;
            this.ListViewDiner.View = System.Windows.Forms.View.Details;
            this.ListViewDiner.SelectedIndexChanged += new System.EventHandler(this.ListViewDiner_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Product";
            this.columnHeader5.Width = 555;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Voorraad";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Prijs";
            // 
            // Dranken
            // 
            this.Dranken.Controls.Add(this.ListViewDranken);
            this.Dranken.Location = new System.Drawing.Point(4, 33);
            this.Dranken.Name = "Dranken";
            this.Dranken.Padding = new System.Windows.Forms.Padding(3);
            this.Dranken.Size = new System.Drawing.Size(719, 435);
            this.Dranken.TabIndex = 2;
            this.Dranken.Text = "Dranken";
            this.Dranken.UseVisualStyleBackColor = true;
            // 
            // ListViewDranken
            // 
            this.ListViewDranken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11});
            this.ListViewDranken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewDranken.FullRowSelect = true;
            this.ListViewDranken.GridLines = true;
            this.ListViewDranken.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewDranken.Location = new System.Drawing.Point(0, 0);
            this.ListViewDranken.Name = "ListViewDranken";
            this.ListViewDranken.Size = new System.Drawing.Size(719, 436);
            this.ListViewDranken.TabIndex = 4;
            this.ListViewDranken.UseCompatibleStateImageBehavior = false;
            this.ListViewDranken.View = System.Windows.Forms.View.Details;
            this.ListViewDranken.SelectedIndexChanged += new System.EventHandler(this.ListViewDranken_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Product";
            this.columnHeader7.Width = 555;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Voorraad";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Prijs";
            // 
            // ListViewBestellijst
            // 
            this.ListViewBestellijst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewBestellijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewBestellijst.FullRowSelect = true;
            this.ListViewBestellijst.GridLines = true;
            this.ListViewBestellijst.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewBestellijst.Location = new System.Drawing.Point(17, 586);
            this.ListViewBestellijst.Name = "ListViewBestellijst";
            this.ListViewBestellijst.Size = new System.Drawing.Size(719, 197);
            this.ListViewBestellijst.TabIndex = 1;
            this.ListViewBestellijst.UseCompatibleStateImageBehavior = false;
            this.ListViewBestellijst.View = System.Windows.Forms.View.Details;
            this.ListViewBestellijst.SelectedIndexChanged += new System.EventHandler(this.ListViewBestellijst_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            this.columnHeader3.Width = 551;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prijs";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 790);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Totaalprijs:";
            // 
            // lbl_TotaalPrijs
            // 
            this.lbl_TotaalPrijs.AutoSize = true;
            this.lbl_TotaalPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotaalPrijs.Location = new System.Drawing.Point(691, 790);
            this.lbl_TotaalPrijs.Name = "lbl_TotaalPrijs";
            this.lbl_TotaalPrijs.Size = new System.Drawing.Size(35, 24);
            this.lbl_TotaalPrijs.TabIndex = 3;
            this.lbl_TotaalPrijs.Text = "0,0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_BestellingOverzicht);
            this.panel1.Controls.Add(this.lbl_Tafelnummer);
            this.panel1.Location = new System.Drawing.Point(292, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // lbl_BestellingOverzicht
            // 
            this.lbl_BestellingOverzicht.AutoSize = true;
            this.lbl_BestellingOverzicht.Location = new System.Drawing.Point(50, 53);
            this.lbl_BestellingOverzicht.Name = "lbl_BestellingOverzicht";
            this.lbl_BestellingOverzicht.Size = new System.Drawing.Size(95, 13);
            this.lbl_BestellingOverzicht.TabIndex = 1;
            this.lbl_BestellingOverzicht.Text = "Bestellingoverzicht";
            // 
            // lbl_Tafelnummer
            // 
            this.lbl_Tafelnummer.AutoSize = true;
            this.lbl_Tafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tafelnummer.Location = new System.Drawing.Point(60, 16);
            this.lbl_Tafelnummer.Name = "lbl_Tafelnummer";
            this.lbl_Tafelnummer.Size = new System.Drawing.Size(122, 24);
            this.lbl_Tafelnummer.TabIndex = 0;
            this.lbl_Tafelnummer.Text = "Tafelnummer";
            // 
            // btn_Opslaan
            // 
            this.btn_Opslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Opslaan.Location = new System.Drawing.Point(559, 843);
            this.btn_Opslaan.Name = "btn_Opslaan";
            this.btn_Opslaan.Size = new System.Drawing.Size(177, 63);
            this.btn_Opslaan.TabIndex = 5;
            this.btn_Opslaan.Text = "Order Plaatsen";
            this.btn_Opslaan.UseVisualStyleBackColor = true;
            // 
            // lbl_Terug
            // 
            this.lbl_Terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Terug.Location = new System.Drawing.Point(17, 843);
            this.lbl_Terug.Name = "lbl_Terug";
            this.lbl_Terug.Size = new System.Drawing.Size(177, 63);
            this.lbl_Terug.TabIndex = 6;
            this.lbl_Terug.Text = "Terug";
            this.lbl_Terug.UseVisualStyleBackColor = true;
            this.lbl_Terug.Click += new System.EventHandler(this.lbl_Terug_Click);
            // 
            // Bestelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.lbl_Terug);
            this.Controls.Add(this.btn_Opslaan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_TotaalPrijs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewBestellijst);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bestelling";
            this.Text = "Bestelling";
            this.Load += new System.EventHandler(this.Bestelling_Load);
            this.tabControl1.ResumeLayout(false);
            this.Lunch.ResumeLayout(false);
            this.Diner.ResumeLayout(false);
            this.Dranken.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewLunch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lunch;
        private System.Windows.Forms.TabPage Diner;
        private System.Windows.Forms.TabPage Dranken;
        private System.Windows.Forms.ListView ListViewBestellijst;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TotaalPrijs;
        private System.Windows.Forms.ListView ListViewDiner;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView ListViewDranken;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Tafelnummer;
        private System.Windows.Forms.Label lbl_BestellingOverzicht;
        private System.Windows.Forms.Button btn_Opslaan;
        private System.Windows.Forms.Button lbl_Terug;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}