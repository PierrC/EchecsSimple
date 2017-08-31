using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopUpTesting
{
    public class TestingObject
    {
        private String name;
        private int value;

        public TestingObject(String name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public String GetName()
        {
            return name;
        }

        public int GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            return name + " has a value of " + value.ToString();
        }
    }
}
