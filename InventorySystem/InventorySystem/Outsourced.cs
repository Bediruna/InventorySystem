using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    //Outsourced class is a subclass of part.
    public class Outsourced : Part
    {
        //Property
        private string companyName;

        public Outsourced()
        {
            this.setType("outsourced");
        }

        //Getter and setter
        public string getCompanyName()
        {
            return companyName;
        }

        public void setCompanyName(string value)
        {
            companyName = value;
            this.setTypeInfo(value);
        }
    }
}
