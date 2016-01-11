namespace MayaMaya
{
    partial class succesafgerondscherm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Met succes afgerekend!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Naar tafeloverzicht";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // succesafgerondscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 986);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "succesafgerondscherm";
            this.Text = "succesafgerondscherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}