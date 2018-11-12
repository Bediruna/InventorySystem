using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            partDataGridView.DataSource = Inventory.getAllPartsDataTable();
            productDataGridView.DataSource = Inventory.getProductsDataTable();

        }

        private void addPart_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddPartForm addPartScreen = new AddPartForm();
            addPartScreen.ShowDialog();

        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            if (Inventory.allParts.Any())
            {
                int partSelected = Convert.ToInt32(partDataGridView.Rows[partDataGridView.CurrentCell.RowIndex].Cells[0].Value);//getting the integer value of the selected part's ID
                this.Hide();
                ModifyPartForm modifyPartScreen = new ModifyPartForm(partSelected);
                modifyPartScreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no parts to modify.", "Error");
            }

        }

        private void deletePart_Click(object sender, EventArgs e)
        {

            if (Inventory.allParts.Any())
            {
                DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

                if (deletePartDialogResult == DialogResult.Yes)
                {
                    int partSelected = Convert.ToInt32(partDataGridView.Rows[partDataGridView.CurrentCell.RowIndex].Cells[0].Value);//gets the part id number for the row selected
                    Inventory.deletePart(Inventory.lookupPart(partSelected));
                }
                else if (deletePartDialogResult == DialogResult.No)
                {
                    //do nothing
                }

            }
            else
            {
                MessageBox.Show("There are no parts to delete.", "Error");
            }

        }

        private void searchPartTextBox_TextChanged(object sender, EventArgs e)
        {
            //Only enable search button if a valid search text is entered.
            if (string.IsNullOrWhiteSpace(searchPartTextBox.Text) || !(int.TryParse(searchPartTextBox.Text, out int n)))
            {
                searchPartButton.Enabled = false;
                searchPartTextBox.BackColor = Color.Salmon;
            }
            else
            {
                searchPartButton.Enabled = true;
                searchPartTextBox.BackColor = Color.White;

            }
        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {

            int searchedPartID = Convert.ToInt32(searchPartTextBox.Text);

            if (Inventory.lookupPart(searchedPartID) != null)
            {
                partDataGridView.Rows[Inventory.lookupPart(searchedPartID).getPartID()].Selected = true;
            }
            else
            {
                MessageBox.Show("Could not find searched part ID.", "Not Found");
            }

        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {

            int searchedProductID = Convert.ToInt32(searchProductTextBox.Text);

            if (Inventory.lookupPart(searchedProductID) != null)
            {
                productDataGridView.Rows[Inventory.lookupProduct(searchedProductID).getProductID()].Selected = true;
            }
            else
            {
                MessageBox.Show("Could not find searched product ID.", "Not Found");
            }

        }

        //Exit button closes the application.
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addProductScreen = new AddProductForm();
            addProductScreen.ShowDialog();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult deleteProductDialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);

            if (deleteProductDialogResult == DialogResult.Yes)
            {
                int productSelected = Convert.ToInt32(productDataGridView.Rows[productDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                Inventory.removeProduct(productSelected);
            }
            else if (deleteProductDialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void partDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int partSelected = Convert.ToInt32(partDataGridView.Rows[partDataGridView.CurrentCell.RowIndex].Cells[0].Value);//gets the part id number for the row selected

            label1.Text = partSelected.ToString();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.products.Any())
            {

                int productSelected = Convert.ToInt32(productDataGridView.Rows[productDataGridView.CurrentCell.RowIndex].Cells[0].Value);//getting the integer value of the selected part's ID
                this.Hide();
                ModifyProductForm modifyProductScreen = new ModifyProductForm(productSelected);
                modifyProductScreen.ShowDialog();

            }
            else
            {
                MessageBox.Show("There are no products to modify.", "Error");
            }

        }

    }
}
