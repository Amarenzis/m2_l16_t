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

namespace Task1_Animation
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

        private void ButtonAnimationClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            //doubleAnimation.From = 150;
            doubleAnimation.To = 300;
            //doubleAnimation.By = 10;
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(6));
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(3);
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
            //doubleAnimation.AccelerationRatio = 0.5;
            //doubleAnimation.SpeedRatio = 0.5;
            //doubleAnimation.AutoReverse = true;
            //doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
            ButtonForAnimation.BeginAnimation(Button.WidthProperty, doubleAnimation);
            ButtonForAnimation.BeginAnimation(Button.HeightProperty, doubleAnimation);

            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red;
            colorAnimation.To = Colors.Blue;
            colorAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
            ButtonForAnimation.Background = new SolidColorBrush(Colors.Red);
            ButtonForAnimation.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
    }
}
