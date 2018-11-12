using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    //Inhouse class is a subclass of part.
    public class Inhouse : Part
    {

        //Property
        private int machineID;

        public Inhouse()
        {
            this.setType("inhouse");
        }

        //Getter and setter
        public int setMachineID()
        {
            return machineID;
        }

        public void setMachineID(int value)
        {
            machineID = value;
            this.setTypeInfo(value.ToString());
        }
    }
}
