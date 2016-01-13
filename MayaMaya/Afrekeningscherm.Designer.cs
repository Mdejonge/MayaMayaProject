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
            this.cmbDranken = new System.Windows.Forms.ComboBox();
            this.cmbDiner = new System.Windows.Forms.ComboBox();
            this.cmbLunch = new System.Windows.Forms.ComboBox();
            this.afrondenbutton = new System.Windows.Forms.Button();
            this.TabelProduct = new System.Windows.Forms.ListBox();
            this.TabelPrijs = new System.Windows.Forms.ListBox();
            this.BedragBerekening = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.commentaarbutton = new System.Windows.Forms.Button();
            this.terugbuttonAS = new System.Windows.Forms.Button();
            this.wisitemsbutton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.fooiBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fooiberekening = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbDranken
            // 
            this.cmbDranken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDranken.FormattingEnabled = true;
            this.cmbDranken.Items.AddRange(new object[] {
            "Glas Frisdrank €2,50",
            "Hertog Jan €3 ",
            "Whiskey €5",
            "Mineral Water €2,95",
            "Melk €1,50"});
            this.cmbDranken.Location = new System.Drawing.Point(8, 12);
            this.cmbDranken.Name = "cmbDranken";
            this.cmbDranken.Size = new System.Drawing.Size(272, 21);
            this.cmbDranken.TabIndex = 0;
            this.cmbDranken.Text = "Dranken";
            this.cmbDranken.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // cmbDiner
            // 
            this.cmbDiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiner.FormattingEnabled = true;
            this.cmbDiner.Items.AddRange(new object[] {
            "Paté van fazant met Monegaskische uitjes € 8,50",
            "Krab-zalm\tkoekjes met zoetzure-chilisaus € 9,-",
            "Chicken Alfredo €13,95",
            "Chicken Picatta €13,95",
            "Turkey Club €11,95",
            "Prime Rib €20,95",
            "Shrimp Scampi €18,95",
            "Turkey Dinner €13,95",
            "Stuffed Chicken €14,95",
            "Seafood Alfredo €15,95"});
            this.cmbDiner.Location = new System.Drawing.Point(298, 12);
            this.cmbDiner.Name = "cmbDiner";
            this.cmbDiner.Size = new System.Drawing.Size(259, 21);
            this.cmbDiner.TabIndex = 1;
            this.cmbDiner.Text = "Diner";
            this.cmbDiner.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // cmbLunch
            // 
            this.cmbLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLunch.FormattingEnabled = true;
            this.cmbLunch.Items.AddRange(new object[] {
            "Steak tartaar, truffelmayonaisse €7,50",
            "Paté van fazant, monegaskische uitjes €8,50",
            "Buffalo Wings €5,95",
            "Buffalo Fingers €6,95",
            "Potato Skins €8,95 ",
            "Nachos €8,95",
            "Mushroom Caps €10,95",
            "Shrimp Cocktail €12,95",
            "Chips and Salsa €6,95"});
            this.cmbLunch.Location = new System.Drawing.Point(8, 48);
            this.cmbLunch.Name = "cmbLunch";
            this.cmbLunch.Size = new System.Drawing.Size(272, 21);
            this.cmbLunch.TabIndex = 3;
            this.cmbLunch.Text = "Lunch";
            this.cmbLunch.SelectedIndexChanged += new System.EventHandler(this.changingDropdown);
            // 
            // afrondenbutton
            // 
            this.afrondenbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.afrondenbutton.Location = new System.Drawing.Point(435, 378);
            this.afrondenbutton.Name = "afrondenbutton";
            this.afrondenbutton.Size = new System.Drawing.Size(134, 35);
            this.afrondenbutton.TabIndex = 4;
            this.afrondenbutton.Text = "Afrekenen";
            this.afrondenbutton.UseVisualStyleBackColor = true;
            this.afrondenbutton.Click += new System.EventHandler(this.afrondenbutton_Click);
            // 
            // TabelProduct
            // 
            this.TabelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelProduct.FormattingEnabled = true;
            this.TabelProduct.Location = new System.Drawing.Point(8, 92);
            this.TabelProduct.Name = "TabelProduct";
            this.TabelProduct.Size = new System.Drawing.Size(272, 160);
            this.TabelProduct.TabIndex = 5;
            // 
            // TabelPrijs
            // 
            this.TabelPrijs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelPrijs.FormattingEnabled = true;
            this.TabelPrijs.Location = new System.Drawing.Point(298, 92);
            this.TabelPrijs.Name = "TabelPrijs";
            this.TabelPrijs.Size = new System.Drawing.Size(55, 160);
            this.TabelPrijs.TabIndex = 6;
            // 
            // BedragBerekening
            // 
            this.BedragBerekening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BedragBerekening.FormattingEnabled = true;
            this.BedragBerekening.Location = new System.Drawing.Point(297, 288);
            this.BedragBerekening.Name = "BedragBerekening";
            this.BedragBerekening.Size = new System.Drawing.Size(55, 43);
            this.BedragBerekening.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Totaal EX-BTW: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "BTW : ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TotaalBedrag : ";
            // 
            // commentaarbutton
            // 
            this.commentaarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.commentaarbutton.Location = new System.Drawing.Point(435, 337);
            this.commentaarbutton.Name = "commentaarbutton";
            this.commentaarbutton.Size = new System.Drawing.Size(134, 35);
            this.commentaarbutton.TabIndex = 12;
            this.commentaarbutton.Text = "Comentaar";
            this.commentaarbutton.UseVisualStyleBackColor = true;
            this.commentaarbutton.Click += new System.EventHandler(this.commentaarbutton_Click);
            // 
            // terugbuttonAS
            // 
            this.terugbuttonAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.terugbuttonAS.Location = new System.Drawing.Point(12, 378);
            this.terugbuttonAS.Name = "terugbuttonAS";
            this.terugbuttonAS.Size = new System.Drawing.Size(134, 35);
            this.terugbuttonAS.TabIndex = 13;
            this.terugbuttonAS.Text = "Terug";
            this.terugbuttonAS.UseVisualStyleBackColor = true;
            this.terugbuttonAS.Click += new System.EventHandler(this.terugbuttonAS_Click_1);
            // 
            // wisitemsbutton
            // 
            this.wisitemsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wisitemsbutton.Location = new System.Drawing.Point(12, 337);
            this.wisitemsbutton.Name = "wisitemsbutton";
            this.wisitemsbutton.Size = new System.Drawing.Size(134, 35);
            this.wisitemsbutton.TabIndex = 14;
            this.wisitemsbutton.Text = "Clear";
            this.wisitemsbutton.UseVisualStyleBackColor = true;
            this.wisitemsbutton.Click += new System.EventHandler(this.wisitemsbutton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(351, 395);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contant";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(351, 372);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pinnen";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(359, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Fooi : Voeg toe";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fooiBox
            // 
            this.fooiBox.Location = new System.Drawing.Point(298, 260);
            this.fooiBox.Name = "fooiBox";
            this.fooiBox.Size = new System.Drawing.Size(55, 20);
            this.fooiBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fooi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Eindbedrag + fooi :";
            // 
            // Fooiberekening
            // 
            this.Fooiberekening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Fooiberekening.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Fooiberekening.FormattingEnabled = true;
            this.Fooiberekening.Location = new System.Drawing.Point(297, 333);
            this.Fooiberekening.Name = "Fooiberekening";
            this.Fooiberekening.Size = new System.Drawing.Size(55, 30);
            this.Fooiberekening.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 420);
            this.Controls.Add(this.Fooiberekening);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fooiBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.wisitemsbutton);
            this.Controls.Add(this.terugbuttonAS);
            this.Controls.Add(this.commentaarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BedragBerekening);
            this.Controls.Add(this.TabelPrijs);
            this.Controls.Add(this.TabelProduct);
            this.Controls.Add(this.afrondenbutton);
            this.Controls.Add(this.cmbDiner);
            this.Controls.Add(this.cmbDranken);
            this.Controls.Add(this.cmbLunch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 459);
            this.MinimumSize = new System.Drawing.Size(597, 459);
            this.Name = "Form1";
            this.Text = "Afrekening";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDranken;
        private System.Windows.Forms.ComboBox cmbDiner;
        private System.Windows.Forms.ComboBox cmbLunch;
        private System.Windows.Forms.Button afrondenbutton;
        private System.Windows.Forms.ListBox TabelProduct;
        private System.Windows.Forms.ListBox TabelPrijs;
        private System.Windows.Forms.ListBox BedragBerekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button commentaarbutton;
        private System.Windows.Forms.Button terugbuttonAS;
        private System.Windows.Forms.Button wisitemsbutton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox fooiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Fooiberekening;
    }
}