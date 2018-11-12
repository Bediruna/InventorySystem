namespace InventorySystem
{
    partial class ModifyPartForm
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
            this.components = new System.ComponentModel.Container();
            this.modifyPartGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.inhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.companyNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.maxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.minToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.priceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inventoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modifyPartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyPartGroupBox
            // 
            this.modifyPartGroupBox.Controls.Add(this.cancelButton);
            this.modifyPartGroupBox.Controls.Add(this.saveButton);
            this.modifyPartGroupBox.Controls.Add(this.companyNameTextBox);
            this.modifyPartGroupBox.Controls.Add(this.minTextBox);
            this.modifyPartGroupBox.Controls.Add(this.maxTextBox);
            this.modifyPartGroupBox.Controls.Add(this.priceTextBox);
            this.modifyPartGroupBox.Controls.Add(this.inventoryTextBox);
            this.modifyPartGroupBox.Controls.Add(this.nameTextBox);
            this.modifyPartGroupBox.Controls.Add(this.idTextBox);
            this.modifyPartGroupBox.Controls.Add(this.companyNameLabel);
            this.modifyPartGroupBox.Controls.Add(this.minLabel);
            this.modifyPartGroupBox.Controls.Add(this.maxLabel);
            this.modifyPartGroupBox.Controls.Add(this.costLabel);
            this.modifyPartGroupBox.Controls.Add(this.inventoryLabel);
            this.modifyPartGroupBox.Controls.Add(this.nameLabel);
            this.modifyPartGroupBox.Controls.Add(this.idLabel);
            this.modifyPartGroupBox.Controls.Add(this.outsourcedRadioButton);
            this.modifyPartGroupBox.Controls.Add(this.inhouseRadioButton);
            this.modifyPartGroupBox.Location = new System.Drawing.Point(12, 12);
            this.modifyPartGroupBox.Name = "modifyPartGroupBox";
            this.modifyPartGroupBox.Size = new System.Drawing.Size(360, 287);
            this.modifyPartGroupBox.TabIndex = 0;
            this.modifyPartGroupBox.TabStop = false;
            this.modifyPartGroupBox.Text = "Modify Part";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(290, 251);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 30);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(224, 251);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 30);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(130, 210);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 15;
            this.companyNameToolTip.SetToolTip(this.companyNameTextBox, "Machine ID requires a number");
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.companyNameTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(285, 180);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(65, 20);
            this.minTextBox.TabIndex = 14;
            this.minToolTip.SetToolTip(this.minTextBox, "Min requires a number");
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(130, 180);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(65, 20);
            this.maxTextBox.TabIndex = 13;
            this.maxToolTip.SetToolTip(this.maxTextBox, "Max requires a number");
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(130, 150);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 12;
            this.priceToolTip.SetToolTip(this.priceTextBox, "Price requires a number");
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(130, 120);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 11;
            this.inventoryToolTip.SetToolTip(this.inventoryTextBox, "Inventory requires a number");
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 10;
            this.nameToolTip.SetToolTip(this.nameTextBox, "Name requires a value");
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(130, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(31, 213);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "Company Name";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(241, 183);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(86, 183);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 6;
            this.maxLabel.Text = "Max";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(50, 153);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(63, 13);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Price / Cost";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(62, 123);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 4;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(78, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(95, 63);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(190, 20);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadioButton.TabIndex = 1;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.outsourcedRadioButton_CheckedChanged);
            // 
            // inhouseRadioButton
            // 
            this.inhouseRadioButton.AutoSize = true;
            this.inhouseRadioButton.Location = new System.Drawing.Point(115, 19);
            this.inhouseRadioButton.Name = "inhouseRadioButton";
            this.inhouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadioButton.TabIndex = 0;
            this.inhouseRadioButton.TabStop = true;
            this.inhouseRadioButton.Text = "In-House";
            this.inhouseRadioButton.UseVisualStyleBackColor = true;
            this.inhouseRadioButton.CheckedChanged += new System.EventHandler(this.inhouseRadioButton_CheckedChanged);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.modifyPartGroupBox);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPartForm_Load);
            this.modifyPartGroupBox.ResumeLayout(false);
            this.modifyPartGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modifyPartGroupBox;
        private System.Windows.Forms.RadioButton inhouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolTip companyNameToolTip;
        private System.Windows.Forms.ToolTip maxToolTip;
        private System.Windows.Forms.ToolTip minToolTip;
        private System.Windows.Forms.ToolTip priceToolTip;
        private System.Windows.Forms.ToolTip inventoryToolTip;
        private System.Windows.Forms.ToolTip nameToolTip;
    }
}