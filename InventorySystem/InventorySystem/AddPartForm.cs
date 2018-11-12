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
    public partial class AddPartForm : Form
    {

        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            this.Hide();
            mainScreen.ShowDialog();
        }

        //Error checking for text boxes
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || int.TryParse(nameTextBox.Text, out int n)) //Turns textbox salmon if empty or if integer.
            {
                nameTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
                nameToolTip.Active = true; //If field is incorrect, display tooltip
            }
            else
            {
                nameTextBox.BackColor = Color.White;
                nameToolTip.Active = false;
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
                inventoryToolTip.Active = true;
            }
            else
            {
                inventoryTextBox.BackColor = Color.White;
                inventoryToolTip.Active = false;
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
                priceToolTip.Active = true;
            }

            else
            {
                priceTextBox.BackColor = Color.White;
                priceToolTip.Active = false;
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
                maxToolTip.Active = true;
            }
            else
            {
                maxTextBox.BackColor = Color.White;
                maxToolTip.Active = false;
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
                minToolTip.Active = true;
            }
            else
            {
                minTextBox.BackColor = Color.White;
                minToolTip.Active = false;
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

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //In house parts only accept integer machine ids.
            if (string.IsNullOrWhiteSpace(companyNameTextBox.Text) ||
                (inhouseRButton.Checked && !(int.TryParse(companyNameTextBox.Text, out int n))) ||
                (outsourcedRButton.Checked && int.TryParse(nameTextBox.Text, out int s)))
            {

                companyNameTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;

                
                if (inhouseRButton.Checked)
                {
                    companyNameToolTip.SetToolTip(companyNameTextBox, "Machine ID requires number");
                }
                else if (outsourcedRButton.Checked)
                {
                    companyNameToolTip.SetToolTip(companyNameTextBox, "Company Name requires value");
                }
                companyNameToolTip.Active = true;

            }
            else
            {
                companyNameTextBox.BackColor = Color.White;
                companyNameToolTip.Active = false;
            }

            if (nameTextBox.BackColor == Color.White &&
                inventoryTextBox.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                companyNameTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            MainScreen mainScreenObj = new MainScreen();

            Inhouse inhousePart;
            Outsourced outsourcedPart;
            if (Convert.ToInt32(maxTextBox.Text) > Convert.ToInt32(minTextBox.Text))
            {


                if (inhouseRButton.Checked)
                {
                    inhousePart = new Inhouse();
                    inhousePart.setName(nameTextBox.Text);
                    inhousePart.setPrice(Convert.ToDouble(priceTextBox.Text));
                    inhousePart.setInStock(Convert.ToInt32(inventoryTextBox.Text));
                    inhousePart.setMin(Convert.ToInt32(minTextBox.Text));
                    inhousePart.setMax(Convert.ToInt32(maxTextBox.Text));
                    inhousePart.setMachineID(Convert.ToInt32(companyNameTextBox.Text));

                    Inventory.addPart(inhousePart);
                }

                else if (outsourcedRButton.Checked)
                {
                    outsourcedPart = new Outsourced();
                    outsourcedPart.setName(nameTextBox.Text.ToString());
                    outsourcedPart.setPrice(Convert.ToDouble(priceTextBox.Text));
                    outsourcedPart.setInStock(Convert.ToInt32(inventoryTextBox.Text));
                    outsourcedPart.setMin(Convert.ToInt32(minTextBox.Text));
                    outsourcedPart.setMax(Convert.ToInt32(maxTextBox.Text));
                    outsourcedPart.setCompanyName(companyNameTextBox.Text);

                    Inventory.addPart(outsourcedPart);
                }

                this.Hide();
                mainScreenObj.ShowDialog();

            }
            else
            {
                MessageBox.Show("Your min value is greater than the max value.", "Error");
            }

        }

        private void inhouseRButton_CheckedChanged(object sender, EventArgs e)
        {

            companyNameLabel.Text = "Machine ID";
            companyNameLabel.Location = new Point(51, 213);
            companyNameToolTip.SetToolTip(companyNameTextBox, "Machine ID requires number");

            if (string.IsNullOrWhiteSpace(companyNameTextBox.Text) ||
                (inhouseRButton.Checked && !(int.TryParse(companyNameTextBox.Text, out int n))))
            {

                companyNameTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
                companyNameToolTip.Active = true;

            }
            else
            {
                companyNameTextBox.BackColor = Color.White;
                companyNameToolTip.Active = false;
            }

        }

        private void outsourcedRButton_CheckedChanged(object sender, EventArgs e)
        {

            companyNameLabel.Text = "Company Name";
            companyNameLabel.Location = new Point(31, 213);
            companyNameToolTip.SetToolTip(companyNameTextBox, "Company Name requires value");

            if (string.IsNullOrWhiteSpace(companyNameTextBox.Text) || int.TryParse(nameTextBox.Text, out int s))
            {
                companyNameTextBox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
                companyNameToolTip.Active = true;

            }
            else
            {
                companyNameTextBox.BackColor = Color.White;
                companyNameToolTip.Active = false;
            }

        }

    }

}
