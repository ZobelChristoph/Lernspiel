using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Invaders.Models
{
    class InvadersModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    
        private Player _player;

        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
                NotifyPropertyChanged("Player");
            }
        }

        private Bug _bug;

        public Bug Bug
        {
            get { return _bug; }
            set
            {
                _bug = value;
                NotifyPropertyChanged("Bug");
            }
        }

        public InvadersModel()
        {
            _player = new Player();
            _bug = new Bug();
        }

        //Methods
        public void Image_KeyDown(object sender, KeyEventArgs e)
        {
            Player.Move(sender, e);
        }


    }
}
