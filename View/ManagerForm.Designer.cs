﻿
namespace lab1
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.Status = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjB = new System.Windows.Forms.ComboBox();
            this.AllCrBut = new System.Windows.Forms.Button();
            this.AllInsBut = new System.Windows.Forms.Button();
            this.AllPrBut = new System.Windows.Forms.Button();
            this.ShowPrj = new System.Windows.Forms.Button();
            this.DeclPrj = new System.Windows.Forms.Button();
            this.ConfPrj = new System.Windows.Forms.Button();
            this.CredB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InstB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoutB = new System.Windows.Forms.Button();
            this.ShowCr = new System.Windows.Forms.Button();
            this.DeclCr = new System.Windows.Forms.Button();
            this.ConfCr = new System.Windows.Forms.Button();
            this.ShowInst = new System.Windows.Forms.Button();
            this.DeclInst = new System.Windows.Forms.Button();
            this.ConfInst = new System.Windows.Forms.Button();
            this.ClearM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(329, 38);
            this.Status.Margin = new System.Windows.Forms.Padding(2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(264, 240);
            this.Status.TabIndex = 0;
            this.Status.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projects";
            // 
            // ProjB
            // 
            this.ProjB.FormattingEnabled = true;
            this.ProjB.Location = new System.Drawing.Point(9, 212);
            this.ProjB.Margin = new System.Windows.Forms.Padding(2);
            this.ProjB.Name = "ProjB";
            this.ProjB.Size = new System.Drawing.Size(264, 21);
            this.ProjB.TabIndex = 2;
            // 
            // AllCrBut
            // 
            this.AllCrBut.Location = new System.Drawing.Point(9, 75);
            this.AllCrBut.Margin = new System.Windows.Forms.Padding(2);
            this.AllCrBut.Name = "AllCrBut";
            this.AllCrBut.Size = new System.Drawing.Size(80, 24);
            this.AllCrBut.TabIndex = 4;
            this.AllCrBut.Text = "Credits";
            this.AllCrBut.UseVisualStyleBackColor = true;
            this.AllCrBut.Click += new System.EventHandler(this.AllCrBut_Click);
            // 
            // AllInsBut
            // 
            this.AllInsBut.Location = new System.Drawing.Point(101, 75);
            this.AllInsBut.Margin = new System.Windows.Forms.Padding(2);
            this.AllInsBut.Name = "AllInsBut";
            this.AllInsBut.Size = new System.Drawing.Size(80, 24);
            this.AllInsBut.TabIndex = 5;
            this.AllInsBut.Text = "Installments";
            this.AllInsBut.UseVisualStyleBackColor = true;
            this.AllInsBut.Click += new System.EventHandler(this.AllInsBut_Click);
            // 
            // AllPrBut
            // 
            this.AllPrBut.Location = new System.Drawing.Point(193, 75);
            this.AllPrBut.Margin = new System.Windows.Forms.Padding(2);
            this.AllPrBut.Name = "AllPrBut";
            this.AllPrBut.Size = new System.Drawing.Size(80, 24);
            this.AllPrBut.TabIndex = 6;
            this.AllPrBut.Text = "Projects";
            this.AllPrBut.UseVisualStyleBackColor = true;
            this.AllPrBut.Click += new System.EventHandler(this.AllPrBut_Click);
            // 
            // ShowPrj
            // 
            this.ShowPrj.Location = new System.Drawing.Point(193, 254);
            this.ShowPrj.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPrj.Name = "ShowPrj";
            this.ShowPrj.Size = new System.Drawing.Size(80, 24);
            this.ShowPrj.TabIndex = 9;
            this.ShowPrj.Text = "Show";
            this.ShowPrj.UseVisualStyleBackColor = true;
            this.ShowPrj.Click += new System.EventHandler(this.ShowPrj_Click);
            // 
            // DeclPrj
            // 
            this.DeclPrj.Location = new System.Drawing.Point(101, 254);
            this.DeclPrj.Margin = new System.Windows.Forms.Padding(2);
            this.DeclPrj.Name = "DeclPrj";
            this.DeclPrj.Size = new System.Drawing.Size(80, 24);
            this.DeclPrj.TabIndex = 8;
            this.DeclPrj.Text = "Decline";
            this.DeclPrj.UseVisualStyleBackColor = true;
            this.DeclPrj.Click += new System.EventHandler(this.DeclPrj_Click);
            // 
            // ConfPrj
            // 
            this.ConfPrj.Location = new System.Drawing.Point(9, 254);
            this.ConfPrj.Margin = new System.Windows.Forms.Padding(2);
            this.ConfPrj.Name = "ConfPrj";
            this.ConfPrj.Size = new System.Drawing.Size(80, 24);
            this.ConfPrj.TabIndex = 7;
            this.ConfPrj.Text = "Confirm";
            this.ConfPrj.UseVisualStyleBackColor = true;
            this.ConfPrj.Click += new System.EventHandler(this.ConfPrj_Click);
            // 
            // CredB
            // 
            this.CredB.FormattingEnabled = true;
            this.CredB.Location = new System.Drawing.Point(9, 361);
            this.CredB.Margin = new System.Windows.Forms.Padding(2);
            this.CredB.Name = "CredB";
            this.CredB.Size = new System.Drawing.Size(264, 21);
            this.CredB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Credits";
            // 
            // InstB
            // 
            this.InstB.FormattingEnabled = true;
            this.InstB.Location = new System.Drawing.Point(392, 329);
            this.InstB.Margin = new System.Windows.Forms.Padding(2);
            this.InstB.Name = "InstB";
            this.InstB.Size = new System.Drawing.Size(264, 21);
            this.InstB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Installments";
            // 
            // LogoutB
            // 
            this.LogoutB.Location = new System.Drawing.Point(602, 432);
            this.LogoutB.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(80, 24);
            this.LogoutB.TabIndex = 20;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = true;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // ShowCr
            // 
            this.ShowCr.Location = new System.Drawing.Point(193, 386);
            this.ShowCr.Margin = new System.Windows.Forms.Padding(2);
            this.ShowCr.Name = "ShowCr";
            this.ShowCr.Size = new System.Drawing.Size(80, 24);
            this.ShowCr.TabIndex = 23;
            this.ShowCr.Text = "Show";
            this.ShowCr.UseVisualStyleBackColor = true;
            this.ShowCr.Click += new System.EventHandler(this.ShowCr_Click);
            // 
            // DeclCr
            // 
            this.DeclCr.Location = new System.Drawing.Point(101, 386);
            this.DeclCr.Margin = new System.Windows.Forms.Padding(2);
            this.DeclCr.Name = "DeclCr";
            this.DeclCr.Size = new System.Drawing.Size(80, 24);
            this.DeclCr.TabIndex = 22;
            this.DeclCr.Text = "Decline";
            this.DeclCr.UseVisualStyleBackColor = true;
            this.DeclCr.Click += new System.EventHandler(this.DeclCr_Click);
            // 
            // ConfCr
            // 
            this.ConfCr.Location = new System.Drawing.Point(11, 386);
            this.ConfCr.Margin = new System.Windows.Forms.Padding(2);
            this.ConfCr.Name = "ConfCr";
            this.ConfCr.Size = new System.Drawing.Size(80, 24);
            this.ConfCr.TabIndex = 21;
            this.ConfCr.Text = "Confirm";
            this.ConfCr.UseVisualStyleBackColor = true;
            this.ConfCr.Click += new System.EventHandler(this.ConfCr_Click);
            // 
            // ShowInst
            // 
            this.ShowInst.Location = new System.Drawing.Point(576, 354);
            this.ShowInst.Margin = new System.Windows.Forms.Padding(2);
            this.ShowInst.Name = "ShowInst";
            this.ShowInst.Size = new System.Drawing.Size(80, 24);
            this.ShowInst.TabIndex = 26;
            this.ShowInst.Text = "Show";
            this.ShowInst.UseVisualStyleBackColor = true;
            this.ShowInst.Click += new System.EventHandler(this.ShowInst_Click);
            // 
            // DeclInst
            // 
            this.DeclInst.Location = new System.Drawing.Point(492, 354);
            this.DeclInst.Margin = new System.Windows.Forms.Padding(2);
            this.DeclInst.Name = "DeclInst";
            this.DeclInst.Size = new System.Drawing.Size(80, 24);
            this.DeclInst.TabIndex = 25;
            this.DeclInst.Text = "Decline";
            this.DeclInst.UseVisualStyleBackColor = true;
            this.DeclInst.Click += new System.EventHandler(this.DeclInst_Click);
            // 
            // ConfInst
            // 
            this.ConfInst.Location = new System.Drawing.Point(392, 354);
            this.ConfInst.Margin = new System.Windows.Forms.Padding(2);
            this.ConfInst.Name = "ConfInst";
            this.ConfInst.Size = new System.Drawing.Size(80, 24);
            this.ConfInst.TabIndex = 24;
            this.ConfInst.Text = "Confirm";
            this.ConfInst.UseVisualStyleBackColor = true;
            this.ConfInst.Click += new System.EventHandler(this.ConfInst_Click);
            // 
            // ClearM
            // 
            this.ClearM.Location = new System.Drawing.Point(545, 38);
            this.ClearM.Margin = new System.Windows.Forms.Padding(2);
            this.ClearM.Name = "ClearM";
            this.ClearM.Size = new System.Drawing.Size(48, 24);
            this.ClearM.TabIndex = 27;
            this.ClearM.Text = "Clear";
            this.ClearM.UseVisualStyleBackColor = true;
            this.ClearM.Click += new System.EventHandler(this.ClearM_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(707, 467);
            this.Controls.Add(this.ClearM);
            this.Controls.Add(this.ShowInst);
            this.Controls.Add(this.DeclInst);
            this.Controls.Add(this.ConfInst);
            this.Controls.Add(this.ShowCr);
            this.Controls.Add(this.DeclCr);
            this.Controls.Add(this.ConfCr);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.InstB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CredB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowPrj);
            this.Controls.Add(this.DeclPrj);
            this.Controls.Add(this.ConfPrj);
            this.Controls.Add(this.AllPrBut);
            this.Controls.Add(this.AllInsBut);
            this.Controls.Add(this.AllCrBut);
            this.Controls.Add(this.ProjB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjB;
        private System.Windows.Forms.Button AllCrBut;
        private System.Windows.Forms.Button AllInsBut;
        private System.Windows.Forms.Button AllPrBut;
        private System.Windows.Forms.Button ShowPrj;
        private System.Windows.Forms.Button DeclPrj;
        private System.Windows.Forms.Button ConfPrj;
        private System.Windows.Forms.ComboBox CredB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InstB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.Button ShowCr;
        private System.Windows.Forms.Button DeclCr;
        private System.Windows.Forms.Button ConfCr;
        private System.Windows.Forms.Button ShowInst;
        private System.Windows.Forms.Button DeclInst;
        private System.Windows.Forms.Button ConfInst;
        private System.Windows.Forms.Button ClearM;
    }
}