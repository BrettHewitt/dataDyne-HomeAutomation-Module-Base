using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBase
{
    public class CommandSlot
    {
        public string Name
        {
            get;
            set;
        }

        public string Identifier
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }

        public CommandSlot(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
