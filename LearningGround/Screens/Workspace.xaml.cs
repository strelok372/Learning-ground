﻿using System;
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

namespace LearningGround
{
    /// <summary>
    /// Логика взаимодействия для Workspace.xaml
    /// </summary>
    public partial class Workspace : UserControl
    {
        public Workspace()
        {
            InitializeComponent();
        }

        private void mouseLeftUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("hello");
        }
    }
}
