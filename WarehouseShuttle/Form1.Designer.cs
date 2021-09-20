
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
            this.EndDateInput = new System.Windows.Forms.MonthCalendar();
            this.StartDateInput = new System.Windows.Forms.MonthCalendar();
            this.StorePackageButton = new System.Windows.Forms.Button();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.EndDateText = new System.Windows.Forms.Label();
            this.StartDateText = new System.Windows.Forms.Label();
            this.OwnerInput = new System.Windows.Forms.TextBox();
            this.OwnerText = new System.Windows.Forms.Label();
            this.MassInput = new System.Windows.Forms.TextBox();
            this.MassText = new System.Windows.Forms.Label();
            this.UnStoreGroup = new System.Windows.Forms.GroupBox();
            this.UnStorePasswordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnstoreOwnerInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnstorePackage = new System.Windows.Forms.Button();
            this.UnStorePinInput = new System.Windows.Forms.TextBox();
            this.PIN = new System.Windows.Forms.Label();
            this.ShowPackagesButton = new System.Windows.Forms.Button();
            this.FloorText = new System.Windows.Forms.Label();
            this.ShowFloorInput = new System.Windows.Forms.TextBox();
            this.ShowFloor = new System.Windows.Forms.Button();
            this.TestShuttleButton = new System.Windows.Forms.Button();
            this.TestInput = new System.Windows.Forms.TextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrawGroup = new System.Windows.Forms.GroupBox();
            this.CommonGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalPackagesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StorePackage.SuspendLayout();
            this.UnStoreGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DrawGroup.SuspendLayout();
            this.CommonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Location = new System.Drawing.Point(26, 71);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(676, 653);
            this.DrawPanel.TabIndex = 0;
            // 
            // StorePackage
            // 
            this.StorePackage.Controls.Add(this.EndDateInput);
            this.StorePackage.Controls.Add(this.StartDateInput);
            this.StorePackage.Controls.Add(this.StorePackageButton);
            this.StorePackage.Controls.Add(this.PriceInput);
            this.StorePackage.Controls.Add(this.PriceText);
            this.StorePackage.Controls.Add(this.EndDateText);
            this.StorePackage.Controls.Add(this.StartDateText);
            this.StorePackage.Controls.Add(this.OwnerInput);
            this.StorePackage.Controls.Add(this.OwnerText);
            this.StorePackage.Controls.Add(this.MassInput);
            this.StorePackage.Controls.Add(this.MassText);
            this.StorePackage.Location = new System.Drawing.Point(22, 31);
            this.StorePackage.Name = "StorePackage";
            this.StorePackage.Size = new System.Drawing.Size(338, 555);
            this.StorePackage.TabIndex = 1;
            this.StorePackage.TabStop = false;
            this.StorePackage.Text = "Store Package";
            // 
            // EndDateInput
            // 
            this.EndDateInput.Location = new System.Drawing.Point(91, 287);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.TabIndex = 18;
            // 
            // StartDateInput
            // 
            this.StartDateInput.Location = new System.Drawing.Point(91, 107);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.TabIndex = 17;
            // 
            // StorePackageButton
            // 
            this.StorePackageButton.BackColor = System.Drawing.Color.Transparent;
            this.StorePackageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StorePackageButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StorePackageButton.FlatAppearance.BorderSize = 5;
            this.StorePackageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StorePackageButton.Location = new System.Drawing.Point(27, 496);
            this.StorePackageButton.Name = "StorePackageButton";
            this.StorePackageButton.Size = new System.Drawing.Size(164, 38);
            this.StorePackageButton.TabIndex = 2;
            this.StorePackageButton.Text = "Store Package";
            this.StorePackageButton.UseVisualStyleBackColor = false;
            this.StorePackageButton.Click += new System.EventHandler(this.StorePackageButton_Click);
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(91, 461);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 22);
            this.PriceInput.TabIndex = 11;
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Location = new System.Drawing.Point(24, 464);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(31, 13);
            this.PriceText.TabIndex = 10;
            this.PriceText.Text = "Price";
            // 
            // EndDateText
            // 
            this.EndDateText.AutoSize = true;
            this.EndDateText.Location = new System.Drawing.Point(28, 288);
            this.EndDateText.Name = "EndDateText";
            this.EndDateText.Size = new System.Drawing.Size(51, 13);
            this.EndDateText.TabIndex = 8;
            this.EndDateText.Text = "EndDate";
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
            // UnStoreGroup
            // 
            this.UnStoreGroup.Controls.Add(this.UnStorePasswordInput);
            this.UnStoreGroup.Controls.Add(this.label2);
            this.UnStoreGroup.Controls.Add(this.UnstoreOwnerInput);
            this.UnStoreGroup.Controls.Add(this.label1);
            this.UnStoreGroup.Controls.Add(this.UnstorePackage);
            this.UnStoreGroup.Controls.Add(this.UnStorePinInput);
            this.UnStoreGroup.Controls.Add(this.PIN);
            this.UnStoreGroup.Location = new System.Drawing.Point(384, 41);
            this.UnStoreGroup.Name = "UnStoreGroup";
            this.UnStoreGroup.Size = new System.Drawing.Size(252, 202);
            this.UnStoreGroup.TabIndex = 12;
            this.UnStoreGroup.TabStop = false;
            this.UnStoreGroup.Text = "Unstore package (get one)";
            // 
            // UnStorePasswordInput
            // 
            this.UnStorePasswordInput.Location = new System.Drawing.Point(128, 104);
            this.UnStorePasswordInput.Name = "UnStorePasswordInput";
            this.UnStorePasswordInput.Size = new System.Drawing.Size(100, 22);
            this.UnStorePasswordInput.TabIndex = 15;
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
            // UnStorePinInput
            // 
            this.UnStorePinInput.Location = new System.Drawing.Point(128, 35);
            this.UnStorePinInput.Name = "UnStorePinInput";
            this.UnStorePinInput.Size = new System.Drawing.Size(100, 22);
            this.UnStorePinInput.TabIndex = 1;
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
            // ShowPackagesButton
            // 
            this.ShowPackagesButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowPackagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowPackagesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowPackagesButton.FlatAppearance.BorderSize = 5;
            this.ShowPackagesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowPackagesButton.Location = new System.Drawing.Point(411, 262);
            this.ShowPackagesButton.Name = "ShowPackagesButton";
            this.ShowPackagesButton.Size = new System.Drawing.Size(201, 38);
            this.ShowPackagesButton.TabIndex = 16;
            this.ShowPackagesButton.Text = "All packages";
            this.ShowPackagesButton.UseVisualStyleBackColor = false;
            this.ShowPackagesButton.Click += new System.EventHandler(this.ShowPackagesButton_Click);
            // 
            // FloorText
            // 
            this.FloorText.AutoSize = true;
            this.FloorText.Location = new System.Drawing.Point(26, 33);
            this.FloorText.Name = "FloorText";
            this.FloorText.Size = new System.Drawing.Size(46, 13);
            this.FloorText.TabIndex = 19;
            this.FloorText.Text = "Floor: 1";
            // 
            // ShowFloorInput
            // 
            this.ShowFloorInput.Location = new System.Drawing.Point(95, 30);
            this.ShowFloorInput.Name = "ShowFloorInput";
            this.ShowFloorInput.Size = new System.Drawing.Size(100, 22);
            this.ShowFloorInput.TabIndex = 19;
            // 
            // ShowFloor
            // 
            this.ShowFloor.BackColor = System.Drawing.Color.Transparent;
            this.ShowFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowFloor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowFloor.FlatAppearance.BorderSize = 5;
            this.ShowFloor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowFloor.Location = new System.Drawing.Point(201, 20);
            this.ShowFloor.Name = "ShowFloor";
            this.ShowFloor.Size = new System.Drawing.Size(164, 38);
            this.ShowFloor.TabIndex = 19;
            this.ShowFloor.Text = "Show floor";
            this.ShowFloor.UseVisualStyleBackColor = false;
            this.ShowFloor.Click += new System.EventHandler(this.ShowFloor_Click);
            // 
            // TestShuttleButton
            // 
            this.TestShuttleButton.BackColor = System.Drawing.Color.Transparent;
            this.TestShuttleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TestShuttleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TestShuttleButton.FlatAppearance.BorderSize = 5;
            this.TestShuttleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TestShuttleButton.Location = new System.Drawing.Point(708, 655);
            this.TestShuttleButton.Name = "TestShuttleButton";
            this.TestShuttleButton.Size = new System.Drawing.Size(100, 66);
            this.TestShuttleButton.TabIndex = 20;
            this.TestShuttleButton.Text = "Test the shuttle";
            this.TestShuttleButton.UseVisualStyleBackColor = false;
            this.TestShuttleButton.Click += new System.EventHandler(this.TestShuttleButton_Click);
            // 
            // TestInput
            // 
            this.TestInput.Location = new System.Drawing.Point(708, 627);
            this.TestInput.Name = "TestInput";
            this.TestInput.Size = new System.Drawing.Size(100, 22);
            this.TestInput.TabIndex = 19;
            this.TestInput.Text = "640";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearAllButton.FlatAppearance.BorderSize = 5;
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearAllButton.Location = new System.Drawing.Point(501, 25);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(201, 38);
            this.ClearAllButton.TabIndex = 21;
            this.ClearAllButton.Text = "Clear all packages";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10 km/h";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "20 km/h";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "30 km/h";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 93);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(66, 17);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "40 km/h";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(10, 116);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(66, 17);
            this.radioButton5.TabIndex = 26;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "50 km/h";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(708, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 193);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // DrawGroup
            // 
            this.DrawGroup.Controls.Add(this.TotalPackagesBox);
            this.DrawGroup.Controls.Add(this.label3);
            this.DrawGroup.Controls.Add(this.DrawPanel);
            this.DrawGroup.Controls.Add(this.FloorText);
            this.DrawGroup.Controls.Add(this.groupBox1);
            this.DrawGroup.Controls.Add(this.ShowFloorInput);
            this.DrawGroup.Controls.Add(this.TestInput);
            this.DrawGroup.Controls.Add(this.ClearAllButton);
            this.DrawGroup.Controls.Add(this.TestShuttleButton);
            this.DrawGroup.Controls.Add(this.ShowFloor);
            this.DrawGroup.Location = new System.Drawing.Point(12, 12);
            this.DrawGroup.Name = "DrawGroup";
            this.DrawGroup.Size = new System.Drawing.Size(837, 754);
            this.DrawGroup.TabIndex = 29;
            this.DrawGroup.TabStop = false;
            this.DrawGroup.Text = "AdminPanel";
            this.DrawGroup.Enter += new System.EventHandler(this.DrawGroup_Enter);
            // 
            // CommonGroup
            // 
            this.CommonGroup.Controls.Add(this.button2);
            this.CommonGroup.Controls.Add(this.button1);
            this.CommonGroup.Controls.Add(this.StorePackage);
            this.CommonGroup.Controls.Add(this.UnStoreGroup);
            this.CommonGroup.Controls.Add(this.ShowPackagesButton);
            this.CommonGroup.Location = new System.Drawing.Point(871, 22);
            this.CommonGroup.Name = "CommonGroup";
            this.CommonGroup.Size = new System.Drawing.Size(684, 744);
            this.CommonGroup.TabIndex = 30;
            this.CommonGroup.TabStop = false;
            this.CommonGroup.Text = "Shuttling";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(501, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalPackagesBox
            // 
            this.TotalPackagesBox.Location = new System.Drawing.Point(718, 89);
            this.TotalPackagesBox.Name = "TotalPackagesBox";
            this.TotalPackagesBox.ReadOnly = true;
            this.TotalPackagesBox.Size = new System.Drawing.Size(100, 22);
            this.TotalPackagesBox.TabIndex = 20;
            this.TotalPackagesBox.TextChanged += new System.EventHandler(this.TotalPackagesBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total packages:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(411, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Generate report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainFormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 771);
            this.Controls.Add(this.CommonGroup);
            this.Controls.Add(this.DrawGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainFormScreen";
            this.Text = "WarehouseShuttle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StorePackage.ResumeLayout(false);
            this.StorePackage.PerformLayout();
            this.UnStoreGroup.ResumeLayout(false);
            this.UnStoreGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DrawGroup.ResumeLayout(false);
            this.DrawGroup.PerformLayout();
            this.CommonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.GroupBox StorePackage;
        private System.Windows.Forms.TextBox MassInput;
        private System.Windows.Forms.Label MassText;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label EndDateText;
        private System.Windows.Forms.Label StartDateText;
        private System.Windows.Forms.TextBox OwnerInput;
        private System.Windows.Forms.Label OwnerText;
        private System.Windows.Forms.Button StorePackageButton;
        private System.Windows.Forms.GroupBox UnStoreGroup;
        private System.Windows.Forms.Button UnstorePackage;
        private System.Windows.Forms.TextBox UnStorePinInput;
        private System.Windows.Forms.Label PIN;
        private System.Windows.Forms.TextBox UnstoreOwnerInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnStorePasswordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowPackagesButton;
        private System.Windows.Forms.MonthCalendar StartDateInput;
        private System.Windows.Forms.MonthCalendar EndDateInput;
        private System.Windows.Forms.Label FloorText;
        private System.Windows.Forms.TextBox ShowFloorInput;
        private System.Windows.Forms.Button ShowFloor;
        private System.Windows.Forms.Button TestShuttleButton;
        private System.Windows.Forms.TextBox TestInput;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox DrawGroup;
        private System.Windows.Forms.GroupBox CommonGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TotalPackagesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

