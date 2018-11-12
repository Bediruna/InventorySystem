using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Inventory
    {

        //Inventory is made up of products and parts array lists.
        public static List<Product> products = new List<Product>();
        public static List<Part> allParts = new List<Part>();

        //Count parts regardless of size of list. This persists regardless of deleted items.
        public static int partCount = 0;
        public static int productCount = 0;

        private static DataTable allPartsDataTable = new DataTable();
        private static DataTable productsDataTable = new DataTable();


        public static DataTable getAllPartsDataTable()
        {
            //If column does not exist, add column.
            if (!allPartsDataTable.Columns.Contains("Part ID")) { allPartsDataTable.Columns.Add("Part ID", typeof(int)); }
            if (!allPartsDataTable.Columns.Contains("Name")) { allPartsDataTable.Columns.Add("Name", typeof(string)); }
            if (!allPartsDataTable.Columns.Contains("Price")) { allPartsDataTable.Columns.Add("Price", typeof(double)); }
            if (!allPartsDataTable.Columns.Contains("In Stock")) { allPartsDataTable.Columns.Add("In Stock", typeof(int)); }

            return allPartsDataTable;

        }

        public static DataTable getProductsDataTable()
        {
            //If column does not exist, add column.
            if (!productsDataTable.Columns.Contains("Part ID")) { productsDataTable.Columns.Add("Part ID", typeof(int)); }
            if (!productsDataTable.Columns.Contains("Name")) { productsDataTable.Columns.Add("Name", typeof(string)); }
            if (!productsDataTable.Columns.Contains("Price")) { productsDataTable.Columns.Add("Price", typeof(double)); }
            if (!productsDataTable.Columns.Contains("In Stock")) { productsDataTable.Columns.Add("In Stock", typeof(int)); }

            return productsDataTable;

        }

        //Adds product to products ArrayList.
        public static void addProduct(Product product)
        {

            product.setProductID(productCount);
            products.Add(product);

            productsDataTable.Rows.Add(
                product.getProductID(),
                product.getName(),
                product.getPrice(),
                product.getInStock()
                );

            productCount++;
        }

        //Removes product if the element at index is not null, then returns true.
        public static bool removeProduct(int searchedProductID)
        {

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].getProductID() == searchedProductID)
                {
                    productsDataTable.Rows[products[i].getProductID()].Delete();
                    products.Remove(products[i]);
                    return true;
                }

            }

            return false;

        }

        //Returns product being searched based on product ID.
        public static Product lookupProduct(int productID)
        {

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].getProductID() == productID)
                {

                    return products[i];

                }

            }

            //If product is not found, return null.
            return null;

        }

        //Product at index is updated.
        public static void updateProduct(int index, Product product)
        {
            productsDataTable.Rows[index][0] = product.getProductID();
            productsDataTable.Rows[index][1] = product.getName();
            productsDataTable.Rows[index][2] = product.getPrice();
            productsDataTable.Rows[index][3] = product.getInStock();

            products[index] = product;
        }

        //Adds part to allParts ArrayList.
        public static void addPart(Part part)
        {

            part.setPartID(partCount);
            allParts.Add(part);

            allPartsDataTable.Rows.Add(
                part.getPartID(),
                part.getName(),
                part.getPrice(),
                part.getInStock()
                );

            partCount++;

        }

        //If allParts arrayList contains part, part is deleted.
        public static bool deletePart(Part part)
        {

            if (allParts.Contains(part) == false)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < allPartsDataTable.Rows.Count; i++)
                {
                    if (allPartsDataTable.Rows[i][0].ToString() == part.getPartID().ToString())
                    {
                        allPartsDataTable.Rows[i].Delete();
                    }
                }
                allParts.Remove(part);
                return true;
            }

            
        }

        //Returns part based on part ID
        public static Part lookupPart(int searchedPartID)
        {
            for (int i = 0; i < allParts.Count(); i++)
            {
                if (allParts[i].getPartID() == searchedPartID)
                {

                    return allParts[i];

                }

            }
            
            //If part is not found, return null.
            return null;

        }

        //Sets item at index to part.
        public static void updatePart(int index, Part part)
        {
            allPartsDataTable.Rows[index][0] = part.getPartID();
            allPartsDataTable.Rows[index][1] = part.getName();
            allPartsDataTable.Rows[index][2] = part.getPrice();
            allPartsDataTable.Rows[index][3] = part.getInStock();

            allParts[index] = part;
        }
    }
}
