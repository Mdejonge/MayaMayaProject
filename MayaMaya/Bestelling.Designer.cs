namespace MayaMaya
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lunch = new System.Windows.Forms.TabPage();
            this.Diner = new System.Windows.Forms.TabPage();
            this.Dranken = new System.Windows.Forms.TabPage();
            this.ListViewBestellijst = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotaalPrijs = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Lunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewLunch
            // 
            this.ListViewLunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListViewLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewLunch.FullRowSelect = true;
            this.ListViewLunch.GridLines = true;
            this.ListViewLunch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewLunch.Location = new System.Drawing.Point(0, 0);
            this.ListViewLunch.Name = "ListViewLunch";
            this.ListViewLunch.Size = new System.Drawing.Size(719, 450);
            this.ListViewLunch.TabIndex = 0;
            this.ListViewLunch.UseCompatibleStateImageBehavior = false;
            this.ListViewLunch.View = System.Windows.Forms.View.Details;
            this.ListViewLunch.SelectedIndexChanged += new System.EventHandler(this.ListViewLunch_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 615;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voorraad";
            this.columnHeader2.Width = 100;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lunch);
            this.tabControl1.Controls.Add(this.Diner);
            this.tabControl1.Controls.Add(this.Dranken);
            this.tabControl1.Location = new System.Drawing.Point(13, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // Lunch
            // 
            this.Lunch.Controls.Add(this.ListViewLunch);
            this.Lunch.Location = new System.Drawing.Point(4, 22);
            this.Lunch.Name = "Lunch";
            this.Lunch.Padding = new System.Windows.Forms.Padding(3);
            this.Lunch.Size = new System.Drawing.Size(719, 450);
            this.Lunch.TabIndex = 0;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = true;
            // 
            // Diner
            // 
            this.Diner.Location = new System.Drawing.Point(4, 22);
            this.Diner.Name = "Diner";
            this.Diner.Padding = new System.Windows.Forms.Padding(3);
            this.Diner.Size = new System.Drawing.Size(719, 450);
            this.Diner.TabIndex = 1;
            this.Diner.Text = "Diner";
            this.Diner.UseVisualStyleBackColor = true;
            // 
            // Dranken
            // 
            this.Dranken.Location = new System.Drawing.Point(4, 22);
            this.Dranken.Name = "Dranken";
            this.Dranken.Padding = new System.Windows.Forms.Padding(3);
            this.Dranken.Size = new System.Drawing.Size(719, 450);
            this.Dranken.TabIndex = 2;
            this.Dranken.Text = "Dranken";
            this.Dranken.UseVisualStyleBackColor = true;
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
            this.ListViewBestellijst.Location = new System.Drawing.Point(17, 557);
            this.ListViewBestellijst.Name = "ListViewBestellijst";
            this.ListViewBestellijst.Size = new System.Drawing.Size(719, 197);
            this.ListViewBestellijst.TabIndex = 1;
            this.ListViewBestellijst.UseCompatibleStateImageBehavior = false;
            this.ListViewBestellijst.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            this.columnHeader3.Width = 615;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aantal";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 757);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Totaalprijs:";
            // 
            // lbl_TotaalPrijs
            // 
            this.lbl_TotaalPrijs.AutoSize = true;
            this.lbl_TotaalPrijs.Location = new System.Drawing.Point(648, 757);
            this.lbl_TotaalPrijs.Name = "lbl_TotaalPrijs";
            this.lbl_TotaalPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_TotaalPrijs.TabIndex = 3;
            // 
            // Bestelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.lbl_TotaalPrijs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewBestellijst);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bestelling";
            this.Text = "Bestelling";
            this.tabControl1.ResumeLayout(false);
            this.Lunch.ResumeLayout(false);
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
    }
}