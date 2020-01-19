using DataDyneIntentLibrary;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleBase
{
    public interface IModule
    {
        string ModuleName
        {
            get;
        }

        string GUID
        {
            get;
        }

        string Description
        {
            get;
        }

        Dictionary<string, string> SettingsCollection
        {
            get;
            set;
        }

        Command[] GetCommands();
        Response Execute(string intentName, DataDyneIntent intent);
        DataTemplate GetView();
        ModuleViewModelBase GetViewModel();
    }
}
