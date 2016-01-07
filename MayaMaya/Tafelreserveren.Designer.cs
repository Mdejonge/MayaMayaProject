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
            this.SuspendLayout();
            // 
            // reserveerTafelButton
            // 
            this.reserveerTafelButton.Location = new System.Drawing.Point(102, 167);
            this.reserveerTafelButton.Name = "reserveerTafelButton";
            this.reserveerTafelButton.Size = new System.Drawing.Size(75, 23);
            this.reserveerTafelButton.TabIndex = 0;
            this.reserveerTafelButton.Text = "Reserveer Tafel";
            this.reserveerTafelButton.UseVisualStyleBackColor = true;
            // 
            // TafelSelectBox
            // 
            this.TafelSelectBox.DisplayMember = "Tafel1";
            this.TafelSelectBox.FormattingEnabled = true;
            this.TafelSelectBox.Location = new System.Drawing.Point(102, 79);
            this.TafelSelectBox.Name = "TafelSelectBox";
            this.TafelSelectBox.Size = new System.Drawing.Size(121, 21);
            this.TafelSelectBox.TabIndex = 1;
            // 
            // Tafelreserveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TafelSelectBox);
            this.Controls.Add(this.reserveerTafelButton);
            this.Name = "Tafelreserveren";
            this.Text = "Tafelreserveren";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reserveerTafelButton;
        private System.Windows.Forms.ComboBox TafelSelectBox;
    }
}