using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ModuleBase
{
    public abstract class ModuleViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        protected void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event EventHandler SaveClicked;

        protected void RaiseSaveClicked()
        {
            SaveClicked(this, EventArgs.Empty);
        }

        public event EventHandler SettingsLoaded;

        public void RaiseSettingsLoaded()
        {
            if (SettingsLoaded != null)
            {
                SettingsLoaded(this, EventArgs.Empty);
            }
        }
    }
}
