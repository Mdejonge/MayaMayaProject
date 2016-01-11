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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BedragBerekening = new System.Windows.Forms.ListBox();
            this.TabelPrijs = new System.Windows.Forms.ListBox();
            this.TabelProduct = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbDiner = new System.Windows.Forms.ComboBox();
            this.cmbDranken = new System.Windows.Forms.ComboBox();
            this.cmbLunch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 629);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Eindbedrag + fooi :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fooi : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(558, 505);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 39;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(456, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Fooi : Voeg toe";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(648, 722);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pinnen";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(648, 745);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contant";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(54, 787);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 75);
            this.button3.TabIndex = 35;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(54, 877);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 71);
            this.button2.TabIndex = 34;
            this.button2.Text = "Terug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(482, 787);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 75);
            this.button1.TabIndex = 33;
            this.button1.Text = "Comentaar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "TotaalBedrag : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "BTW : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Totaal : ";
            // 
            // BedragBerekening
            // 
            this.BedragBerekening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BedragBerekening.FormattingEnabled = true;
            this.BedragBerekening.Location = new System.Drawing.Point(559, 533);
            this.BedragBerekening.Name = "BedragBerekening";
            this.BedragBerekening.Size = new System.Drawing.Size(132, 121);
            this.BedragBerekening.TabIndex = 29;
            // 
            // TabelPrijs
            // 
            this.TabelPrijs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelPrijs.FormattingEnabled = true;
            this.TabelPrijs.Location = new System.Drawing.Point(558, 185);
            this.TabelPrijs.Name = "TabelPrijs";
            this.TabelPrijs.Size = new System.Drawing.Size(133, 303);
            this.TabelPrijs.TabIndex = 28;
            this.TabelPrijs.SelectedIndexChanged += new System.EventHandler(this.TabelPrijs_SelectedIndexChanged_1);
            // 
            // TabelProduct
            // 
            this.TabelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelProduct.FormattingEnabled = true;
            this.TabelProduct.Location = new System.Drawing.Point(64, 185);
            this.TabelProduct.Name = "TabelProduct";
            this.TabelProduct.Size = new System.Drawing.Size(488, 303);
            this.TabelProduct.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(482, 877);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(224, 71);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Afrekenen";
            this.btnClear.UseVisualStyleBackColor = true;
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
            this.cmbDiner.Location = new System.Drawing.Point(352, 41);
            this.cmbDiner.Name = "cmbDiner";
            this.cmbDiner.Size = new System.Drawing.Size(259, 21);
            this.cmbDiner.TabIndex = 24;
            this.cmbDiner.Text = "Diner";
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
            this.cmbDranken.Location = new System.Drawing.Point(62, 41);
            this.cmbDranken.Name = "cmbDranken";
            this.cmbDranken.Size = new System.Drawing.Size(272, 21);
            this.cmbDranken.TabIndex = 23;
            this.cmbDranken.Text = "Dranken";
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
            this.cmbLunch.Location = new System.Drawing.Point(62, 77);
            this.cmbLunch.Name = "cmbLunch";
            this.cmbLunch.Size = new System.Drawing.Size(272, 21);
            this.cmbLunch.TabIndex = 25;
            this.cmbLunch.Text = "Lunch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 986);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BedragBerekening);
            this.Controls.Add(this.TabelPrijs);
            this.Controls.Add(this.TabelProduct);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbDiner);
            this.Controls.Add(this.cmbDranken);
            this.Controls.Add(this.cmbLunch);
            this.Name = "Form1";
            this.Text = "Afrekeningscherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLunch;
        private System.Windows.Forms.ComboBox cmbDranken;
        private System.Windows.Forms.ComboBox cmbDiner;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox TabelProduct;
        private System.Windows.Forms.ListBox TabelPrijs;
        private System.Windows.Forms.ListBox BedragBerekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}