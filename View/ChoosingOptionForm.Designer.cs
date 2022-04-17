
namespace lab1
{
    partial class ChoosingOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosingOptionForm));
            this.SignIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignIn.Location = new System.Drawing.Point(515, 360);
            this.SignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(193, 30);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Sign in";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignUp.Location = new System.Drawing.Point(515, 448);
            this.SignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(193, 30);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(486, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome! Choose the option";
            // 
            // ChoosingOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1195, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignIn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChoosingOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online-Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label1;
    }
}

