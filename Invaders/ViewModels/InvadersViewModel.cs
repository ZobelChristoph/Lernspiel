using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invaders.Models;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;

namespace Invaders.ViewModels
{
    class InvadarsViewModel : INotifyPropertyChanged
    {
        #region Notifyhandler
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        #endregion


        #region Properties and Attributes

        private DispatcherTimer timer;


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


        //Sprites in a list
        private  ObservableCollection<Bug>
                 _sprites = new ObservableCollection<Bug>();

        public ObservableCollection<Bug> Sprite
        {
            get { return _sprites; }
            set
            {
                _sprites = value;
                NotifyPropertyChanged("Sprites");
            }
        }

        #endregion
        public InvadarsViewModel()
        {
            Model = new InvadersModel();
            Bug b1 = new Bug();
            Sprite.Add(b1);

            startTimer();
        }
        #region Constuctor


        #endregion


        #region Methods
        //Methods
        public void Image_KeyDown(object sender, KeyEventArgs e)
        {
            Model.Image_KeyDown(sender, e);
        }

        public void startTimer()
        { 
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {   
            foreach(Bug tempBug in _sprites)
            {
                tempBug.Move();
            }

            //Debug: Singlebugtest
            Model.Bug.Move();
        }

        #endregion


    }
}
