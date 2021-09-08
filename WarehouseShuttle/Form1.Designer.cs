
namespace WarehouseShuttle
{
    partial class MainFormScreen
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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.StorePackage = new System.Windows.Forms.GroupBox();
            this.StorePackageButton = new System.Windows.Forms.Button();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.EndDateInput = new System.Windows.Forms.TextBox();
            this.EndDateText = new System.Windows.Forms.Label();
            this.StartDateInput = new System.Windows.Forms.TextBox();
            this.StartDateText = new System.Windows.Forms.Label();
            this.OwnerInput = new System.Windows.Forms.TextBox();
            this.OwnerText = new System.Windows.Forms.Label();
            this.MassInput = new System.Windows.Forms.TextBox();
            this.MassText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnstoreOwnerInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnstorePackage = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PIN = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StorePackage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(778, 681);
            this.DrawPanel.TabIndex = 0;
            // 
            // StorePackage
            // 
            this.StorePackage.Controls.Add(this.StorePackageButton);
            this.StorePackage.Controls.Add(this.PriceInput);
            this.StorePackage.Controls.Add(this.PriceText);
            this.StorePackage.Controls.Add(this.EndDateInput);
            this.StorePackage.Controls.Add(this.EndDateText);
            this.StorePackage.Controls.Add(this.StartDateInput);
            this.StorePackage.Controls.Add(this.StartDateText);
            this.StorePackage.Controls.Add(this.OwnerInput);
            this.StorePackage.Controls.Add(this.OwnerText);
            this.StorePackage.Controls.Add(this.MassInput);
            this.StorePackage.Controls.Add(this.MassText);
            this.StorePackage.Location = new System.Drawing.Point(825, 12);
            this.StorePackage.Name = "StorePackage";
            this.StorePackage.Size = new System.Drawing.Size(218, 277);
            this.StorePackage.TabIndex = 1;
            this.StorePackage.TabStop = false;
            this.StorePackage.Text = "Store Package";
            // 
            // StorePackageButton
            // 
            this.StorePackageButton.BackColor = System.Drawing.Color.Transparent;
            this.StorePackageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StorePackageButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StorePackageButton.FlatAppearance.BorderSize = 5;
            this.StorePackageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StorePackageButton.Location = new System.Drawing.Point(27, 233);
            this.StorePackageButton.Name = "StorePackageButton";
            this.StorePackageButton.Size = new System.Drawing.Size(164, 38);
            this.StorePackageButton.TabIndex = 2;
            this.StorePackageButton.Text = "Store Package";
            this.StorePackageButton.UseVisualStyleBackColor = false;
            this.StorePackageButton.Click += new System.EventHandler(this.StorePackageButton_Click);
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(91, 186);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 22);
            this.PriceInput.TabIndex = 11;
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Location = new System.Drawing.Point(24, 189);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(31, 13);
            this.PriceText.TabIndex = 10;
            this.PriceText.Text = "Price";
            // 
            // EndDateInput
            // 
            this.EndDateInput.Location = new System.Drawing.Point(91, 140);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.Size = new System.Drawing.Size(100, 22);
            this.EndDateInput.TabIndex = 9;
            // 
            // EndDateText
            // 
            this.EndDateText.AutoSize = true;
            this.EndDateText.Location = new System.Drawing.Point(24, 140);
            this.EndDateText.Name = "EndDateText";
            this.EndDateText.Size = new System.Drawing.Size(51, 13);
            this.EndDateText.TabIndex = 8;
            this.EndDateText.Text = "EndDate";
            // 
            // StartDateInput
            // 
            this.StartDateInput.Location = new System.Drawing.Point(91, 111);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.Size = new System.Drawing.Size(100, 22);
            this.StartDateInput.TabIndex = 7;
            // 
            // StartDateText
            // 
            this.StartDateText.AutoSize = true;
            this.StartDateText.Location = new System.Drawing.Point(24, 114);
            this.StartDateText.Name = "StartDateText";
            this.StartDateText.Size = new System.Drawing.Size(55, 13);
            this.StartDateText.TabIndex = 6;
            this.StartDateText.Text = "StartDate";
            // 
            // OwnerInput
            // 
            this.OwnerInput.Location = new System.Drawing.Point(91, 71);
            this.OwnerInput.Name = "OwnerInput";
            this.OwnerInput.Size = new System.Drawing.Size(100, 22);
            this.OwnerInput.TabIndex = 3;
            // 
            // OwnerText
            // 
            this.OwnerText.AutoSize = true;
            this.OwnerText.Location = new System.Drawing.Point(24, 74);
            this.OwnerText.Name = "OwnerText";
            this.OwnerText.Size = new System.Drawing.Size(42, 13);
            this.OwnerText.TabIndex = 2;
            this.OwnerText.Text = "Owner";
            // 
            // MassInput
            // 
            this.MassInput.Location = new System.Drawing.Point(91, 35);
            this.MassInput.Name = "MassInput";
            this.MassInput.Size = new System.Drawing.Size(100, 22);
            this.MassInput.TabIndex = 1;
            // 
            // MassText
            // 
            this.MassText.AutoSize = true;
            this.MassText.Location = new System.Drawing.Point(24, 38);
            this.MassText.Name = "MassText";
            this.MassText.Size = new System.Drawing.Size(33, 13);
            this.MassText.TabIndex = 0;
            this.MassText.Text = "Mass";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PasswordInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UnstoreOwnerInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UnstorePackage);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.PIN);
            this.groupBox1.Location = new System.Drawing.Point(1072, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 202);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unstore package (get one)";
            // 
            // UnstoreOwnerInput
            // 
            this.UnstoreOwnerInput.Location = new System.Drawing.Point(128, 68);
            this.UnstoreOwnerInput.Name = "UnstoreOwnerInput";
            this.UnstoreOwnerInput.Size = new System.Drawing.Size(100, 22);
            this.UnstoreOwnerInput.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Owner";
            // 
            // UnstorePackage
            // 
            this.UnstorePackage.BackColor = System.Drawing.Color.Transparent;
            this.UnstorePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UnstorePackage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UnstorePackage.FlatAppearance.BorderSize = 5;
            this.UnstorePackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UnstorePackage.Location = new System.Drawing.Point(27, 158);
            this.UnstorePackage.Name = "UnstorePackage";
            this.UnstorePackage.Size = new System.Drawing.Size(201, 38);
            this.UnstorePackage.TabIndex = 2;
            this.UnstorePackage.Text = "Get Package";
            this.UnstorePackage.UseVisualStyleBackColor = false;
            this.UnstorePackage.Click += new System.EventHandler(this.UnstorePackageButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 1;
            // 
            // PIN
            // 
            this.PIN.AutoSize = true;
            this.PIN.Location = new System.Drawing.Point(24, 38);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(92, 13);
            this.PIN.TabIndex = 0;
            this.PIN.Text = "PIN (last 4 digits)";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(128, 104);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 22);
            this.PasswordInput.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // MainFormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StorePackage);
            this.Controls.Add(this.DrawPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainFormScreen";
            this.Text = "WarehouseShuttle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StorePackage.ResumeLayout(false);
            this.StorePackage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.GroupBox StorePackage;
        private System.Windows.Forms.TextBox MassInput;
        private System.Windows.Forms.Label MassText;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.TextBox EndDateInput;
        private System.Windows.Forms.Label EndDateText;
        private System.Windows.Forms.TextBox StartDateInput;
        private System.Windows.Forms.Label StartDateText;
        private System.Windows.Forms.TextBox OwnerInput;
        private System.Windows.Forms.Label OwnerText;
        private System.Windows.Forms.Button StorePackageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UnstorePackage;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label PIN;
        private System.Windows.Forms.TextBox UnstoreOwnerInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label2;
    }
}

