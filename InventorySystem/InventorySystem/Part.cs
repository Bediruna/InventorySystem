using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public abstract class Part
    {
        
        //Properties
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        private string type;//Type variable is to know whether the part is inhouse or outsourced.
        private string typeInfo;//TypeInfo variable contains machine or company name depending on type.

        //Getters and setters

        public string getType()
        {
            return type;
        }

        public void setType(string value)
        {
            type = value;
        }

        public string getTypeInfo()
        {
            return typeInfo;
        }

        public void setTypeInfo(string value)
        {
            typeInfo = value;
        }

        public int getPartID()
        {
            return partID;
        }

        public void setPartID(int value)
        {
            partID = value;
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
    }
}
