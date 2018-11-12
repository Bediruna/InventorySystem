using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Product
    {

        /*Properties*/
        private List<Part> associatedParts = new List<Part>();
        private int productID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        private DataTable associatedPartsDataTable = new DataTable();

        /*Getters and Setters*/

        public bool isAssocPartsEmpty()
        {
            if (!associatedParts.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public DataTable getAssociatedPartsDataTable()
        {
            //If column does not exist, add column.
            if (!associatedPartsDataTable.Columns.Contains("Part ID")) { associatedPartsDataTable.Columns.Add("Part ID", typeof(int)); }
            if (!associatedPartsDataTable.Columns.Contains("Name")) { associatedPartsDataTable.Columns.Add("Name", typeof(string)); }
            if (!associatedPartsDataTable.Columns.Contains("Price")) { associatedPartsDataTable.Columns.Add("Price", typeof(double)); }
            if (!associatedPartsDataTable.Columns.Contains("In Stock")) { associatedPartsDataTable.Columns.Add("In Stock", typeof(int)); }

            return associatedPartsDataTable;

        }

        public int getProductID()
        {
            return productID;
        }

        public void setProductID(int value)
        {
            productID = value;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string value)
        {
            name = value;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double value)
        {
            price = value;
        }

        public int getInStock()
        {
            return inStock;
        }

        public void setInStock(int value)
        {
            inStock = value;
        }

        public int getMin()
        {
            return min;
        }

        public void setMin(int value)
        {
            min = value;
        }

        public int getMax()
        {
            return max;
        }

        public void setMax(int value)
        {
            max = value;
        }


        public void addAssociatedPart(Part part)
        {

            associatedPartsDataTable.Rows.Add(
                part.getPartID(),
                part.getName(),
                part.getPrice(),
                part.getInStock()
                );

            associatedParts.Add(part);

        }

        //Remove part based on PartID and return flag based on success.
        public bool removeAssociatedPart(int searchedPartID)
        {

            for (int i = 0; i < associatedPartsDataTable.Rows.Count; i++)
            {
                if (associatedPartsDataTable.Rows[i][0].ToString() == searchedPartID.ToString())
                {
                    associatedPartsDataTable.Rows[i].Delete();
                }
            }

            for (int i = 0; i < associatedParts.Count(); i++)
            {
                if (associatedParts[i].getPartID() == searchedPartID)
                {

                    associatedParts.Remove(associatedParts[i]);
                    return true;
                }

            }

            return false;

        }

        //Searches Parts list based on partID
        public Part lookupAssociatedPart(int searchedPartID)
        {

            for (int i = 0; i < associatedParts.Count(); i++)
            {
                if (associatedParts[i].getPartID() == searchedPartID)
                {

                    return associatedParts[i];

                }

            }

            //If part is not found, return null.
            return null;

        }
    }
}
