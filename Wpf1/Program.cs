using System;
using System.Windows;
using System.Windows.Controls;

namespace Wpf1
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            MyWindow win = new MyWindow()
            {
                WindowStyle = WindowStyle.None
            };
            win.Show();
            Application app = new Application();
            app.Run();
        }
    }
}
