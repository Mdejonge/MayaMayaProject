namespace MayaMaya
{
    partial class Tafelreserveren
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
            this.reserveerTafelButton = new System.Windows.Forms.Button();
            this.TafelSelectBox = new System.Windows.Forms.ComboBox();
            this.terugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reserveerTafelButton
            // 
            this.reserveerTafelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveerTafelButton.Location = new System.Drawing.Point(195, 413);
            this.reserveerTafelButton.Name = "reserveerTafelButton";
            this.reserveerTafelButton.Size = new System.Drawing.Size(356, 73);
            this.reserveerTafelButton.TabIndex = 0;
            this.reserveerTafelButton.Text = "Reserveer Tafel";
            this.reserveerTafelButton.UseVisualStyleBackColor = true;
            this.reserveerTafelButton.Click += new System.EventHandler(this.reserveerTafelButton_Click);
            // 
            // TafelSelectBox
            // 
            this.TafelSelectBox.FormattingEnabled = true;
            this.TafelSelectBox.Location = new System.Drawing.Point(195, 251);
            this.TafelSelectBox.Name = "TafelSelectBox";
            this.TafelSelectBox.Size = new System.Drawing.Size(356, 21);
            this.TafelSelectBox.TabIndex = 1;
            this.TafelSelectBox.SelectedIndexChanged += new System.EventHandler(this.TafelSelectBox_SelectedIndexChanged);
            // 
            // terugButton
            // 
            this.terugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terugButton.Location = new System.Drawing.Point(195, 791);
            this.terugButton.Name = "terugButton";
            this.terugButton.Size = new System.Drawing.Size(356, 72);
            this.terugButton.TabIndex = 2;
            this.terugButton.Text = "Terug";
            this.terugButton.UseVisualStyleBackColor = true;
            this.terugButton.Click += new System.EventHandler(this.terugButton_Click);
            // 
            // Tafelreserveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.terugButton);
            this.Controls.Add(this.TafelSelectBox);
            this.Controls.Add(this.reserveerTafelButton);
            this.Name = "Tafelreserveren";
            this.Text = "Tafelreserveren";
            this.Load += new System.EventHandler(this.Tafelreserveren_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reserveerTafelButton;
        private System.Windows.Forms.ComboBox TafelSelectBox;
        private System.Windows.Forms.Button terugButton;
    }
}