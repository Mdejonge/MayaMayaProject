namespace MayaMaya
{
    partial class LoginScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScherm));
            this.NaamLabel = new System.Windows.Forms.Label();
            this.WwLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.textboxNaam = new System.Windows.Forms.TextBox();
            this.textboxWw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaamLabel.Location = new System.Drawing.Point(12, 349);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.Size = new System.Drawing.Size(300, 51);
            this.NaamLabel.TabIndex = 0;
            this.NaamLabel.Text = "WerknemerID:";
            // 
            // WwLabel
            // 
            this.WwLabel.AutoSize = true;
            this.WwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WwLabel.Location = new System.Drawing.Point(12, 428);
            this.WwLabel.Name = "WwLabel";
            this.WwLabel.Size = new System.Drawing.Size(274, 51);
            this.WwLabel.TabIndex = 1;
            this.WwLabel.Text = "Wachtwoord:";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(21, 540);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(684, 85);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // textboxNaam
            // 
            this.textboxNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNaam.Location = new System.Drawing.Point(347, 349);
            this.textboxNaam.Name = "textboxNaam";
            this.textboxNaam.Size = new System.Drawing.Size(358, 56);
            this.textboxNaam.TabIndex = 3;
            // 
            // textboxWw
            // 
            this.textboxWw.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxWw.Location = new System.Drawing.Point(347, 439);
            this.textboxWw.Name = "textboxWw";
            this.textboxWw.Size = new System.Drawing.Size(358, 56);
            this.textboxWw.TabIndex = 4;
            // 
            // LoginScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.textboxWw);
            this.Controls.Add(this.textboxNaam);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.WwLabel);
            this.Controls.Add(this.NaamLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScherm";
            this.Text = "MayaMaya Bestelsysteem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaamLabel;
        private System.Windows.Forms.Label WwLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox textboxNaam;
        private System.Windows.Forms.TextBox textboxWw;
    }
}

