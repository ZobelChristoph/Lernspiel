using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invaders.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Invaders.ViewModels
{
    class InvadarsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

   
        private InvadersModel _model;
        
        public InvadersModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                NotifyPropertyChanged("Model");
            }
        }

        public InvadarsViewModel()
        {
           Model = new InvadersModel();
        }

        //Methods
        public void Image_KeyDown(object sender, KeyEventArgs e)
        {
           Model.Image_KeyDown(sender, e);
        }



    }
}
