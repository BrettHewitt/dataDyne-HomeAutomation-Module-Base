using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBase
{
    public class Command
    {
        public string CommandIdentifier
        {
            get;
            set;
        }

        public string CommandName
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public CommandSlot[] Slots
        {
            get;
            set;
        }
    }
}
