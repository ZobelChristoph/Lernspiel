﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Invaders.Models
{
    class Bug : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        private int directionMovement = -20;

        //private string _ImagePath = "@/Assets/player.png";
        private string _ImagePath = "C:/Users/X230t/Documents/Meine Unterlagen/Informatik/Datenbanken/20112012 Datenbanken/06 WPF und Serious Games/Invaders/Invaders/Assets/bug.png";

        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
                NotifyPropertyChanged("ImagePath");
            }
        }

        private int _ImageFromTop = 30;

        public int ImageFromTop
        {
            get { return _ImageFromTop; }
            set
            {
                _ImageFromTop = value;
                NotifyPropertyChanged("ImageFromTop");
            }
        }

        private int _ImageFromLeft = 200;

        public int ImageFromLeft
        {
            get { return _ImageFromLeft; }
            set
            {
                _ImageFromLeft = value;
                NotifyPropertyChanged("ImageFromLeft");
            }
        }

        public void Move()
        {
           if(ImageFromLeft ==0)
           {
                directionMovement = 20;
                ImageFromTop += 50;
           }
           if(ImageFromLeft ==780)
           {
                directionMovement = -20;
                ImageFromTop += 50;
           }
           //General Movement in Dependancy of the before choosen direction
           ImageFromLeft += directionMovement;
        }

    }
}
