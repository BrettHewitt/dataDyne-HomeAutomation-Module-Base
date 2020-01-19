using System;
using System.Collections.Generic;
using System.Windows;
using DataDyneIntentLibrary;

namespace ModuleBase
{
    public abstract class ModuleBaseClass
    {
        public abstract string Description
        {
            get;
        }

        public abstract string GUID
        {
            get;
        }

        public abstract string ModuleName
        {
            get;
        }

        public abstract string ResourceDictionaryName
        {
            get;
        }

        public abstract string AssemblyName
        {
            get;
        }

        public abstract string DataTemplateName
        {
            get;
        }
        
        public Dictionary<string, string> SettingsCollection
        {
            get;
            set;
        }

        protected Dictionary<string, Func<DataDyneIntent, Response>> IntentMappings
        {
            get;
            set;
        }

        protected Command[] Commands
        {
            get;
            set;
        }

        protected ModuleBaseClass()
        {
            SettingsCollection = GetDefaultSettings();
            Commands = CreateCommands();
            IntentMappings = CreateMappings();
        }

        protected abstract Dictionary<string, string> GetDefaultSettings();

        public Response Execute(string intentName, DataDyneIntent intent)
        {
            return IntentMappings[intentName](intent);
        }

        protected abstract Command[] CreateCommands();
        protected abstract Dictionary<string, Func<DataDyneIntent, Response>> CreateMappings();

        public Command[] GetCommands()
        {
            return Commands;
        }

        public System.Windows.DataTemplate GetView()
        {
            ResourceDictionary rd = new ResourceDictionary() { Source = new Uri($"pack://application:,,,/{AssemblyName};component/{ResourceDictionaryName}.xaml", UriKind.Absolute) };
            return rd[DataTemplateName] as DataTemplate;
        }
        
        public abstract ModuleViewModelBase GetViewModel();

        public virtual void OnConnect()
        {
            
        }

        public virtual void OnDisconnect()
        {
            
        }

        public virtual string GetCurrentStatus()
        {
            return string.Empty;
        }
    }
}
