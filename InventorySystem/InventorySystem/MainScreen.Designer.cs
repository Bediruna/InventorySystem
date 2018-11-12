namespace InventorySystem
{
    partial class MainScreen
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
            this.partGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPartTextBox = new System.Windows.Forms.TextBox();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            this.deletePart = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.partGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partGroupBox
            // 
            this.partGroupBox.Controls.Add(this.label1);
            this.partGroupBox.Controls.Add(this.searchPartTextBox);
            this.partGroupBox.Controls.Add(this.searchPartButton);
            this.partGroupBox.Controls.Add(this.partDataGridView);
            this.partGroupBox.Controls.Add(this.deletePart);
            this.partGroupBox.Controls.Add(this.addPart);
            this.partGroupBox.Controls.Add(this.modifyPart);
            this.partGroupBox.Location = new System.Drawing.Point(12, 32);
            this.partGroupBox.Name = "partGroupBox";
            this.partGroupBox.Size = new System.Drawing.Size(466, 342);
            this.partGroupBox.TabIndex = 4;
            this.partGroupBox.TabStop = false;
            this.partGroupBox.Text = "Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // searchPartTextBox
            // 
            this.searchPartTextBox.Location = new System.Drawing.Point(320, 17);
            this.searchPartTextBox.Name = "searchPartTextBox";
            this.searchPartTextBox.Size = new System.Drawing.Size(140, 20);
            this.searchPartTextBox.TabIndex = 5;
            this.searchPartTextBox.TextChanged += new System.EventHandler(this.searchPartTextBox_TextChanged);
            // 
            // searchPartButton
            // 
            this.searchPartButton.Location = new System.Drawing.Point(239, 15);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(75, 23);
            this.searchPartButton.TabIndex = 4;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.searchPartButton_Click);
            // 
            // partDataGridView
            // 
            this.partDataGridView.AllowUserToAddRows = false;
            this.partDataGridView.AllowUserToDeleteRows = false;
            this.partDataGridView.AllowUserToResizeColumns = false;
            this.partDataGridView.AllowUserToResizeRows = false;
            this.partDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.Location = new System.Drawing.Point(6, 46);
            this.partDataGridView.MultiSelect = false;
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.ReadOnly = true;
            this.partDataGridView.RowHeadersVisible = false;
            this.partDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView.Size = new System.Drawing.Size(454, 250);
            this.partDataGridView.TabIndex = 0;
            this.partDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partDataGridView_CellContentClick);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(385, 302);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 3;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(223, 302);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 23);
            this.addPart.TabIndex = 1;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(304, 302);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(75, 23);
            this.modifyPart.TabIndex = 2;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.AddProduct);
            this.productGroupBox.Controls.Add(this.modifyProduct);
            this.productGroupBox.Controls.Add(this.deleteProduct);
            this.productGroupBox.Controls.Add(this.searchProductButton);
            this.productGroupBox.Controls.Add(this.searchProductTextBox);
            this.productGroupBox.Controls.Add(this.productDataGridView);
            this.productGroupBox.Location = new System.Drawing.Point(484, 32);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(466, 342);
            this.productGroupBox.TabIndex = 6;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(223, 302);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 5;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(304, 302);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 23);
            this.modifyProduct.TabIndex = 4;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(385, 302);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 3;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(239, 15);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(75, 23);
            this.searchProductButton.TabIndex = 2;
            this.searchProductButton.Text = "Search";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Location = new System.Drawing.Point(320, 17);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(140, 20);
            this.searchProductTextBox.TabIndex = 1;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(6, 46);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(454, 250);
            this.productDataGridView.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(875, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 413);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.partGroupBox);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.partGroupBox.ResumeLayout(false);
            this.partGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox partGroupBox;
        private System.Windows.Forms.DataGridView partDataGridView;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.TextBox searchPartTextBox;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.TextBox searchProductTextBox;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Label label1;
    }
}