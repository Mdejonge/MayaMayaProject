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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Tafel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Tafel1
            // 
            this.btn_Tafel1.Location = new System.Drawing.Point(12, 12);
            this.btn_Tafel1.Name = "btn_Tafel1";
            this.btn_Tafel1.Size = new System.Drawing.Size(107, 96);
            this.btn_Tafel1.TabIndex = 0;
            this.btn_Tafel1.Text = "Tafel 1";
            this.btn_Tafel1.UseVisualStyleBackColor = true;
            this.btn_Tafel1.Click += new System.EventHandler(this.btn_Tafel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 488);
            this.Controls.Add(this.btn_Tafel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MayaMaya Bestelsysteem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Tafel1;
    }
}

