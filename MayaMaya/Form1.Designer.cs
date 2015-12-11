namespace MayaMaya
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
            this.listviewItems = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listviewItems
            // 
            this.listviewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Voorraad,
            this.Prijs,
            this.BTW});
            this.listviewItems.Enabled = false;
            this.listviewItems.FullRowSelect = true;
            this.listviewItems.HoverSelection = true;
            this.listviewItems.Location = new System.Drawing.Point(12, 12);
            this.listviewItems.Name = "listviewItems";
            this.listviewItems.Size = new System.Drawing.Size(644, 464);
            this.listviewItems.TabIndex = 0;
            this.listviewItems.UseCompatibleStateImageBehavior = false;
            this.listviewItems.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 400;
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.Width = 63;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            // 
            // BTW
            // 
            this.BTW.Text = "BTW heffing";
            this.BTW.Width = 81;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 488);
            this.Controls.Add(this.listviewItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewItems;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader BTW;
    }
}

