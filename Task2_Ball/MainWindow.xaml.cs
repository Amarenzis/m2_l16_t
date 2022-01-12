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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2_Ball
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLodedEvent(object sender, RoutedEventArgs e)
        {
            DoubleAnimation ballUpAnimation = new DoubleAnimation();
            ballUpAnimation.To = 50;
            ballUpAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            ballUpAnimation.DecelerationRatio = 0.8;
            ballUpAnimation.AutoReverse = true;
            ballUpAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromDays(1));
            Ball.BeginAnimation(Canvas.TopProperty, ballUpAnimation);
        }
    }
}
