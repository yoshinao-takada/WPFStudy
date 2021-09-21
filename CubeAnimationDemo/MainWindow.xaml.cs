
using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace CubeAnimationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Trackball _trackball;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // setup trackball for moving the model around
            _trackball = new Trackball();
            _trackball.Attach(this);
            _trackball.Slaves.Add(myViewport3D);
            _trackball.Enabled = true;

        }

        private void OnImage1Animate(object sender, RoutedEventArgs e)
        {
            var s = (Storyboard)FindResource("RotateStoryboard");
            BeginStoryboard(s);
        }
    }
}
