﻿
namespace lab1
{
    partial class CreditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.RequestButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BankBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(330, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit";
            // 
            // MonthsBox
            // 
            this.MonthsBox.FormattingEnabled = true;
            this.MonthsBox.Location = new System.Drawing.Point(279, 170);
            this.MonthsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(147, 21);
            this.MonthsBox.TabIndex = 1;
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(313, 272);
            this.RequestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(82, 22);
            this.RequestButton.TabIndex = 3;
            this.RequestButton.Text = "Request";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sum";
            // 
            // SumEdit
            // 
            this.SumEdit.Location = new System.Drawing.Point(279, 236);
            this.SumEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(147, 20);
            this.SumEdit.TabIndex = 7;
            this.SumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumEdit_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(11, 430);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(60, 22);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bank";
            // 
            // BankBox
            // 
            this.BankBox.FormattingEnabled = true;
            this.BankBox.Location = new System.Drawing.Point(279, 114);
            this.BankBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(147, 21);
            this.BankBox.TabIndex = 11;
            this.BankBox.SelectedIndexChanged += new System.EventHandler(this.BankBox_SelectedIndexChanged);
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SumEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.MonthsBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MonthsBox;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BankBox;
    }
}