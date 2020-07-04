using LearningGround.Entities;
using LearningGround.Screens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace LearningGround
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

        private void WorkspaceClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Workspace();
        }

        private void InformationClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Information();
        }

        private void CollectionClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Collections();
        }
    }
}
