
namespace lab1
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.StatusMemo = new System.Windows.Forms.RichTextBox();
            this.AccountsButton = new System.Windows.Forms.Button();
            this.CreditButton = new System.Windows.Forms.Button();
            this.InstallmentButton = new System.Windows.Forms.Button();
            this.OpenAccountButton = new System.Windows.Forms.Button();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BankBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TakeCreditButton = new System.Windows.Forms.Button();
            this.TakeInsButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.StatButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salprgEdit = new System.Windows.Forms.TextBox();
            this.salprgButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusMemo
            // 
            this.StatusMemo.Location = new System.Drawing.Point(382, 140);
            this.StatusMemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusMemo.Name = "StatusMemo";
            this.StatusMemo.Size = new System.Drawing.Size(262, 227);
            this.StatusMemo.TabIndex = 0;
            this.StatusMemo.Text = "";
            // 
            // AccountsButton
            // 
            this.AccountsButton.Location = new System.Drawing.Point(11, 76);
            this.AccountsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(92, 31);
            this.AccountsButton.TabIndex = 1;
            this.AccountsButton.Text = "Show account";
            this.AccountsButton.UseVisualStyleBackColor = true;
            this.AccountsButton.Click += new System.EventHandler(this.AccountsButton_Click);
            // 
            // CreditButton
            // 
            this.CreditButton.Location = new System.Drawing.Point(469, 388);
            this.CreditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(77, 31);
            this.CreditButton.TabIndex = 2;
            this.CreditButton.Text = "Show credits";
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // InstallmentButton
            // 
            this.InstallmentButton.Location = new System.Drawing.Point(550, 388);
            this.InstallmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InstallmentButton.Name = "InstallmentButton";
            this.InstallmentButton.Size = new System.Drawing.Size(102, 31);
            this.InstallmentButton.TabIndex = 3;
            this.InstallmentButton.Text = "Show installments";
            this.InstallmentButton.UseVisualStyleBackColor = true;
            this.InstallmentButton.Click += new System.EventHandler(this.InstallmentButton_Click);
            // 
            // OpenAccountButton
            // 
            this.OpenAccountButton.Location = new System.Drawing.Point(274, 92);
            this.OpenAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenAccountButton.Name = "OpenAccountButton";
            this.OpenAccountButton.Size = new System.Drawing.Size(92, 31);
            this.OpenAccountButton.TabIndex = 4;
            this.OpenAccountButton.Text = "Open account";
            this.OpenAccountButton.UseVisualStyleBackColor = true;
            this.OpenAccountButton.Click += new System.EventHandler(this.OpenAccountButton_Click);
            // 
            // SumEdit
            // 
            this.SumEdit.Location = new System.Drawing.Point(274, 65);
            this.SumEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SumEdit.Multiline = true;
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(120, 23);
            this.SumEdit.TabIndex = 5;
            this.SumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumEdit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sum";
            // 
            // BankBox
            // 
            this.BankBox.FormattingEnabled = true;
            this.BankBox.Location = new System.Drawing.Point(274, 27);
            this.BankBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(120, 21);
            this.BankBox.TabIndex = 11;
            this.BankBox.SelectedIndexChanged += new System.EventHandler(this.BankBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bank";
            // 
            // AccountsBox
            // 
            this.AccountsBox.FormattingEnabled = true;
            this.AccountsBox.Location = new System.Drawing.Point(11, 51);
            this.AccountsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AccountsBox.Name = "AccountsBox";
            this.AccountsBox.Size = new System.Drawing.Size(120, 21);
            this.AccountsBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Accounts";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(601, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TakeCreditButton
            // 
            this.TakeCreditButton.Location = new System.Drawing.Point(21, 222);
            this.TakeCreditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TakeCreditButton.Name = "TakeCreditButton";
            this.TakeCreditButton.Size = new System.Drawing.Size(92, 31);
            this.TakeCreditButton.TabIndex = 16;
            this.TakeCreditButton.Text = "Take credit";
            this.TakeCreditButton.UseVisualStyleBackColor = true;
            this.TakeCreditButton.Click += new System.EventHandler(this.TakeCreditButton_Click);
            // 
            // TakeInsButton
            // 
            this.TakeInsButton.Location = new System.Drawing.Point(21, 257);
            this.TakeInsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TakeInsButton.Name = "TakeInsButton";
            this.TakeInsButton.Size = new System.Drawing.Size(92, 31);
            this.TakeInsButton.TabIndex = 17;
            this.TakeInsButton.Text = "Take installment";
            this.TakeInsButton.UseVisualStyleBackColor = true;
            this.TakeInsButton.Click += new System.EventHandler(this.TakeInsButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(30, 405);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(71, 23);
            this.LogOut.TabIndex = 18;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // StatButton
            // 
            this.StatButton.Location = new System.Drawing.Point(392, 388);
            this.StatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatButton.Name = "StatButton";
            this.StatButton.Size = new System.Drawing.Size(73, 31);
            this.StatButton.TabIndex = 19;
            this.StatButton.Text = "Client stat";
            this.StatButton.UseVisualStyleBackColor = true;
            this.StatButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sum";
            // 
            // salprgEdit
            // 
            this.salprgEdit.Location = new System.Drawing.Point(438, 24);
            this.salprgEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salprgEdit.Multiline = true;
            this.salprgEdit.Name = "salprgEdit";
            this.salprgEdit.Size = new System.Drawing.Size(120, 23);
            this.salprgEdit.TabIndex = 21;
            this.salprgEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salprgEdit_KeyPress);
            // 
            // salprgButton
            // 
            this.salprgButton.Location = new System.Drawing.Point(438, 51);
            this.salprgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salprgButton.Name = "salprgButton";
            this.salprgButton.Size = new System.Drawing.Size(119, 31);
            this.salprgButton.TabIndex = 20;
            this.salprgButton.Text = "Take salary project";
            this.salprgButton.UseVisualStyleBackColor = true;
            this.salprgButton.Click += new System.EventHandler(this.salprgButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salprgEdit);
            this.Controls.Add(this.salprgButton);
            this.Controls.Add(this.StatButton);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.TakeInsButton);
            this.Controls.Add(this.TakeCreditButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumEdit);
            this.Controls.Add(this.OpenAccountButton);
            this.Controls.Add(this.InstallmentButton);
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.AccountsButton);
            this.Controls.Add(this.StatusMemo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatusMemo;
        private System.Windows.Forms.Button AccountsButton;
        private System.Windows.Forms.Button CreditButton;
        private System.Windows.Forms.Button InstallmentButton;
        private System.Windows.Forms.Button OpenAccountButton;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BankBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AccountsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TakeCreditButton;
        private System.Windows.Forms.Button TakeInsButton;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button StatButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salprgEdit;
        private System.Windows.Forms.Button salprgButton;
    }
}