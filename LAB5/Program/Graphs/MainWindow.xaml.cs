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

namespace Graphs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Ellipse ellipse = new Ellipse();
            //SolidColorBrush solid = new SolidColorBrush();
            //solid.Color = Color.FromArgb(255, 255, 255, 0);
            //ellipse.Width = ellipse.Height = 100;
            //
            //
            //ellipse.Fill = solid;


            GraphicTop A = new GraphicTop();


            Grid.Children.Add(A.Rectangle);
        }
    }
}
