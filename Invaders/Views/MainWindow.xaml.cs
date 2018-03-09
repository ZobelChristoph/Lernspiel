using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Invaders.ViewModels;

namespace Invaders
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InvadarsViewModel myViewModel;

        public MainWindow()
        {
            InitializeComponent();
            myViewModel = new InvadarsViewModel();
            this.DataContext = myViewModel;


            //TODO:
            //Remember: Bind on Property!
            //Then: Create some bugs, which moves by the event of a timer, the bugs should be in a observable list (Maybe two things?)
        }

        private void Image_KeyDown(object sender, KeyEventArgs e)
        {
            myViewModel.Image_KeyDown(sender, e);
        }
    }
}
