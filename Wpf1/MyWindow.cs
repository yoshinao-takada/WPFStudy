using System;
using System.Windows;
using System.Windows.Controls;

namespace Wpf1
{
    class MyWindow : Window
    {
        public MyWindow()
        {
            Width = 300;
            Height = 200;
            Title = "My simple Window";
            Button btn = new Button()
            {
                Content = "Click Me",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            Content = btn;
        }
    }
}
