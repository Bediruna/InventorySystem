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
    public partial class ModifyProductForm : Form
    {

        public int productNumber;

        public ModifyProductForm(int rowSelected)
        {

            InitializeComponent();

            idTextBox.Text = rowSelected.ToString();

            productNumber = rowSelected;

        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            allPartsDataGridView.DataSource = Inventory.getAllPartsDataTable();

            associatedPartsDataGridView.DataSource = Inventory.products[productNumber].getAssociatedPartsDataTable();

            nameTextBox.Text = Inventory.products[productNumber].getName();
            inventoryTextBox.Text = Inventory.products[productNumber].getInStock().ToString();
            priceTextBox.Text = Inventory.products[productNumber].getPrice().ToString();
            maxTextBox.Text = Inventory.products[productNumber].getMax().ToString();
            minTextBox.Text = Inventory.products[productNumber].getMin().ToString();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            MainScreen mainScreenObj = new MainScreen();

            if (Convert.ToInt32(maxTextBox.Text) < Convert.ToInt32(minTextBox.Text))
            {

                MessageBox.Show("Your min value needs to be less than the max value.", "Error");

            }
            else if (Inventory.products[productNumber].isAssocPartsEmpty())
            {
                MessageBox.Show("You must add at least one associated part.", "Error");
            }
            else
            {

                Inventory.products[productNumber].setName(nameTextBox.Text);
                Inventory.products[productNumber].setPrice(Convert.ToDouble(priceTextBox.Text));
                Inventory.products[productNumber].setInStock(Convert.ToInt32(inventoryTextBox.Text));
                Inventory.products[productNumber].setMin(Convert.ToInt32(minTextBox.Text));
                Inventory.products[productNumber].setMax(Convert.ToInt32(maxTextBox.Text));

                Inventory.updateProduct(productNumber, Inventory.products[productNumber]);

                this.Hide();
                mainScreenObj.ShowDialog();

            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            this.Hide();
            mainScreen.ShowDialog();
        }

        private void delAssocPart_Click(object sender, EventArgs e)
        {

            DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

            if (deletePartDialogResult == DialogResult.Yes)
            {
                int partSelected = Convert.ToInt32(associatedPartsDataGridView.Rows[associatedPartsDataGridView.CurrentCell.RowIndex].Cells[0].Value);//gets the part id number for the row selected
                Inventory.products[productNumber].removeAssociatedPart(partSelected);
            }
            else if (deletePartDialogResult == DialogResult.No)
            {
                //do nothing
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            int partSelected = Convert.ToInt32(allPartsDataGridView.Rows[allPartsDataGridView.CurrentCell.RowIndex].Cells[0].Value);
            Inventory.products[productNumber].addAssociatedPart(Inventory.lookupPart(partSelected));

        }

        //Validation
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || int.TryParse(nameTextBox.Text, out int n)) //Turns textbox salmon if empty or if integer.
            {
                nameTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
            }


            //Textbox background color is also used to check if all boxes have correct content. If so, save button is enabled.
            if (nameTextBox.BackColor == Color.White &&
                inventoryTextBox.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }

        }
        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(inventoryTextBox.Text) || !(int.TryParse(inventoryTextBox.Text, out int n)))
            {
                inventoryTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                inventoryTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White &&
                inventoryTextBox.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || !(double.TryParse(priceTextBox.Text, out double n)))
            {
                priceTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }

            else
            {
                priceTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White &&
                inventoryTextBox.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }

        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(maxTextBox.Text) || !(int.TryParse(maxTextBox.Text, out int n)))
            {
                maxTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                maxTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White &&
                inventoryTextBox.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox.Text) || !(int.TryParse(minTextBox.Text, out int n)))
            {
                minTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                minTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White &&
                inventoryTextBox.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            int searchedPartID = Convert.ToInt32(searchTextBox.Text);

            if (Inventory.lookupPart(searchedPartID) != null)
            {
                allPartsDataGridView.Rows[Inventory.lookupPart(searchedPartID).getPartID()].Selected = true;
            }
            else
            {
                MessageBox.Show("Could not find searched part ID.", "Not Found");
            }

        }
    }
}
