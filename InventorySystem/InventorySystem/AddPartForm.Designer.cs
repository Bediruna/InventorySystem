namespace InventorySystem
{
    partial class AddPartForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.outsourcedRButton = new System.Windows.Forms.RadioButton();
            this.inhouseRButton = new System.Windows.Forms.RadioButton();
            this.introLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.companyNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.maxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.minToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.priceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inventoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(290, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 30);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(219, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 30);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outsourcedRButton
            // 
            this.outsourcedRButton.AutoSize = true;
            this.outsourcedRButton.Location = new System.Drawing.Point(199, 12);
            this.outsourcedRButton.Name = "outsourcedRButton";
            this.outsourcedRButton.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRButton.TabIndex = 35;
            this.outsourcedRButton.Text = "Outsourced";
            this.outsourcedRButton.UseVisualStyleBackColor = true;
            this.outsourcedRButton.CheckedChanged += new System.EventHandler(this.outsourcedRButton_CheckedChanged);
            // 
            // inhouseRButton
            // 
            this.inhouseRButton.AutoSize = true;
            this.inhouseRButton.Checked = true;
            this.inhouseRButton.Location = new System.Drawing.Point(109, 12);
            this.inhouseRButton.Name = "inhouseRButton";
            this.inhouseRButton.Size = new System.Drawing.Size(68, 17);
            this.inhouseRButton.TabIndex = 34;
            this.inhouseRButton.TabStop = true;
            this.inhouseRButton.Text = "In-House";
            this.inhouseRButton.UseVisualStyleBackColor = true;
            this.inhouseRButton.CheckedChanged += new System.EventHandler(this.inhouseRButton_CheckedChanged);
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Location = new System.Drawing.Point(12, 9);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(48, 13);
            this.introLabel.TabIndex = 33;
            this.introLabel.Text = "Add Part";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(51, 213);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(62, 13);
            this.companyNameLabel.TabIndex = 32;
            this.companyNameLabel.Text = "Machine ID";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(241, 183);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 31;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(86, 183);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 30;
            this.maxLabel.Text = "Max";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(50, 153);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(63, 13);
            this.costLabel.TabIndex = 29;
            this.costLabel.Text = "Price / Cost";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(62, 123);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 28;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(78, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(95, 63);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 26;
            this.idLabel.Text = "ID";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.companyNameTextBox.Location = new System.Drawing.Point(130, 210);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 25;
            this.companyNameToolTip.SetToolTip(this.companyNameTextBox, "Machine ID require number");
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.companyNameTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.Color.Salmon;
            this.minTextBox.Location = new System.Drawing.Point(285, 180);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(65, 20);
            this.minTextBox.TabIndex = 24;
            this.minToolTip.SetToolTip(this.minTextBox, "Min requires number");
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.BackColor = System.Drawing.Color.Salmon;
            this.maxTextBox.Location = new System.Drawing.Point(130, 180);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(65, 20);
            this.maxTextBox.TabIndex = 23;
            this.maxToolTip.SetToolTip(this.maxTextBox, "Max requires number");
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.Salmon;
            this.priceTextBox.Location = new System.Drawing.Point(130, 150);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 22;
            this.priceToolTip.SetToolTip(this.priceTextBox, "Price requires number");
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            this.inventoryTextBox.Location = new System.Drawing.Point(130, 120);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 21;
            this.inventoryToolTip.SetToolTip(this.inventoryTextBox, "Inventory requires number");
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.nameTextBox.Location = new System.Drawing.Point(130, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 20;
            this.nameToolTip.SetToolTip(this.nameTextBox, "Name requires a value");
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(130, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 19;
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.outsourcedRButton);
            this.Controls.Add(this.inhouseRButton);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton outsourcedRButton;
        private System.Windows.Forms.RadioButton inhouseRButton;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
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
        private System.Windows.Forms.ToolTip companyNameToolTip;
        private System.Windows.Forms.ToolTip maxToolTip;
        private System.Windows.Forms.ToolTip minToolTip;
        private System.Windows.Forms.ToolTip priceToolTip;
        private System.Windows.Forms.ToolTip inventoryToolTip;
        private System.Windows.Forms.ToolTip nameToolTip;
    }
}