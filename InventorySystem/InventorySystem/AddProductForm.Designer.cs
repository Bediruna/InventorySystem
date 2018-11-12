namespace InventorySystem
{
    partial class AddProductForm
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
            this.addProductGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.allPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.allPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.addProductGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.allPartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductGroupBox
            // 
            this.addProductGroupBox.Controls.Add(this.groupBox1);
            this.addProductGroupBox.Controls.Add(this.allPartsGroupBox);
            this.addProductGroupBox.Controls.Add(this.minLabel);
            this.addProductGroupBox.Controls.Add(this.maxLabel);
            this.addProductGroupBox.Controls.Add(this.priceLabel);
            this.addProductGroupBox.Controls.Add(this.inventoryLabel);
            this.addProductGroupBox.Controls.Add(this.nameLabel);
            this.addProductGroupBox.Controls.Add(this.idLabel);
            this.addProductGroupBox.Controls.Add(this.minTextBox);
            this.addProductGroupBox.Controls.Add(this.maxTextBox);
            this.addProductGroupBox.Controls.Add(this.priceTextBox);
            this.addProductGroupBox.Controls.Add(this.inventoryTextBox);
            this.addProductGroupBox.Controls.Add(this.nameTextBox);
            this.addProductGroupBox.Controls.Add(this.idTextBox);
            this.addProductGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addProductGroupBox.Name = "addProductGroupBox";
            this.addProductGroupBox.Size = new System.Drawing.Size(660, 487);
            this.addProductGroupBox.TabIndex = 0;
            this.addProductGroupBox.TabStop = false;
            this.addProductGroupBox.Text = "Add Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.deleteProduct);
            this.groupBox1.Controls.Add(this.associatedPartsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(226, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 215);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts Associated with the Product";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(266, 186);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(347, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(347, 157);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 1;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.AllowUserToAddRows = false;
            this.associatedPartsDataGridView.AllowUserToDeleteRows = false;
            this.associatedPartsDataGridView.AllowUserToResizeColumns = false;
            this.associatedPartsDataGridView.AllowUserToResizeRows = false;
            this.associatedPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.RowHeadersVisible = false;
            this.associatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(416, 132);
            this.associatedPartsDataGridView.TabIndex = 0;
            // 
            // allPartsGroupBox
            // 
            this.allPartsGroupBox.Controls.Add(this.allPartsDataGridView);
            this.allPartsGroupBox.Controls.Add(this.searchTextBox);
            this.allPartsGroupBox.Controls.Add(this.searchButton);
            this.allPartsGroupBox.Controls.Add(this.addButton);
            this.allPartsGroupBox.Location = new System.Drawing.Point(226, 19);
            this.allPartsGroupBox.Name = "allPartsGroupBox";
            this.allPartsGroupBox.Size = new System.Drawing.Size(428, 241);
            this.allPartsGroupBox.TabIndex = 16;
            this.allPartsGroupBox.TabStop = false;
            this.allPartsGroupBox.Text = "All Parts";
            // 
            // allPartsDataGridView
            // 
            this.allPartsDataGridView.AllowUserToAddRows = false;
            this.allPartsDataGridView.AllowUserToDeleteRows = false;
            this.allPartsDataGridView.AllowUserToResizeColumns = false;
            this.allPartsDataGridView.AllowUserToResizeRows = false;
            this.allPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsDataGridView.Location = new System.Drawing.Point(6, 45);
            this.allPartsDataGridView.MultiSelect = false;
            this.allPartsDataGridView.Name = "allPartsDataGridView";
            this.allPartsDataGridView.ReadOnly = true;
            this.allPartsDataGridView.RowHeadersVisible = false;
            this.allPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsDataGridView.Size = new System.Drawing.Size(416, 156);
            this.allPartsDataGridView.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(282, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(140, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(201, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(347, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(127, 323);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 15;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(4, 323);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(24, 283);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(4, 243);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 12;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 203);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(37, 163);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.Color.Salmon;
            this.minTextBox.Location = new System.Drawing.Point(157, 320);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(65, 20);
            this.minTextBox.TabIndex = 9;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.BackColor = System.Drawing.Color.Salmon;
            this.maxTextBox.Location = new System.Drawing.Point(40, 320);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(65, 20);
            this.maxTextBox.TabIndex = 8;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.Salmon;
            this.priceTextBox.Location = new System.Drawing.Point(61, 280);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            this.inventoryTextBox.Location = new System.Drawing.Point(61, 240);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 6;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.nameTextBox.Location = new System.Drawing.Point(61, 200);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(61, 160);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.addProductGroupBox);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.addProductGroupBox.ResumeLayout(false);
            this.addProductGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.allPartsGroupBox.ResumeLayout(false);
            this.allPartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addProductGroupBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView allPartsDataGridView;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox allPartsGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteProduct;
    }
}