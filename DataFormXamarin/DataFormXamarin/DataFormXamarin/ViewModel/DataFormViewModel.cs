using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormViewModel : INotifyPropertyChanged
    {
        private DataFormModel formModel;
        public DataFormModel DataFormModel
        {
            get { return formModel; }
            set
            {
                formModel = value;
                this.RaisePropertychanged("DataFormModel");
            }
        }
        public DataFormViewModel()
        {
            formModel = new DataFormModel();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
