
namespace lab1
{
    partial class OperatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorForm));
            this.StatusMemo = new System.Windows.Forms.RichTextBox();
            this.ProjectsBox = new System.Windows.Forms.ComboBox();
            this.AllprgButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusMemo
            // 
            this.StatusMemo.Location = new System.Drawing.Point(278, 25);
            this.StatusMemo.Margin = new System.Windows.Forms.Padding(2);
            this.StatusMemo.Name = "StatusMemo";
            this.StatusMemo.Size = new System.Drawing.Size(230, 249);
            this.StatusMemo.TabIndex = 0;
            this.StatusMemo.Text = "";
            // 
            // ProjectsBox
            // 
            this.ProjectsBox.FormattingEnabled = true;
            this.ProjectsBox.Location = new System.Drawing.Point(23, 213);
            this.ProjectsBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectsBox.Name = "ProjectsBox";
            this.ProjectsBox.Size = new System.Drawing.Size(145, 21);
            this.ProjectsBox.TabIndex = 1;
            // 
            // AllprgButton
            // 
            this.AllprgButton.Location = new System.Drawing.Point(279, 278);
            this.AllprgButton.Margin = new System.Windows.Forms.Padding(2);
            this.AllprgButton.Name = "AllprgButton";
            this.AllprgButton.Size = new System.Drawing.Size(229, 24);
            this.AllprgButton.TabIndex = 2;
            this.AllprgButton.Text = "Show all projects";
            this.AllprgButton.UseVisualStyleBackColor = true;
            this.AllprgButton.Click += new System.EventHandler(this.AllprgButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projects";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(11, 250);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(70, 24);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 439);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(85, 250);
            this.DeclineButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(70, 24);
            this.DeclineButton.TabIndex = 7;
            this.DeclineButton.Text = "Decline";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(168, 250);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(70, 24);
            this.ShowButton.TabIndex = 8;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(512, 24);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(56, 21);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show account logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllprgButton);
            this.Controls.Add(this.ProjectsBox);
            this.Controls.Add(this.StatusMemo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OperatorForm";
            this.Text = "Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatusMemo;
        private System.Windows.Forms.ComboBox ProjectsBox;
        private System.Windows.Forms.Button AllprgButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button1;
    }
}