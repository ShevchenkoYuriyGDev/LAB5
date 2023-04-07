using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_lab_5
{
    abstract class Kitchen_Device
    {
        public bool isClear { get; set; }
        public bool state { get; set; }
        public string position { get; set; }
        public virtual bool IsClear(bool isClear)
        {
            return isClear;
        }
        public virtual bool State(bool state) 
        {
            return state;
        }
        public virtual string Position(string position)
        {
            return position;
        }
    }
    class Plate : Kitchen_Device
    {
        public override bool IsClear(bool isClear)
        {
            return isClear;
        }
        public override bool State(bool state)
        {
            return state;
        }
        public override string Position(string position)
        {
            return position;
        }
    }
    class Cup : Kitchen_Device
    {
        public override bool IsClear(bool isClear)
        {
            return isClear;
        }
        public override bool State(bool state)
        {
            return state;
        }
        public override string Position(string position)
        {
            return position;
        }
    }
    class Spoon : Kitchen_Device
    {
        public override bool IsClear(bool isClear)
        {
            return isClear;
        }
        public override bool State(bool state)
        {
            return state;
        }
        public override string Position(string position)
        {
            return position;
        }
    }
    class Fork : Kitchen_Device
    {
        public override bool IsClear(bool isClear)
        {
            return isClear;
        }
        public override bool State(bool state)
        {
            return state;
        }
        public override string Position(string position)
        {
            return position;
        }
    }
}
