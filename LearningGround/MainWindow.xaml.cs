using LearningGround.Entities;
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
        ObservableCollection<Record> records;

        public MainWindow()
        {
            InitializeComponent();
            FillData();
        }

        public void OpenRecord(object sender, SelectionChangedEventArgs e)
        {
            tabControl.Items.Add("123");
        }

        private void FillData()
        {
            tv_menu.ItemsSource = new[] { "Детское", "Подростковое", "Взрослое" };

            records = new ObservableCollection<Record>
            {
                new Record("Заголовок 1", "Животные", "Абвгд"),
                new Record("Заголовок 2", "Животные", "Абвгд"),
                new Record("Заголовок 3", "Животные", "Абвгд"),
                new Record("Заголовок 4", "Фрукты", "Абвгд"),
                new Record("Заголовок 5", "Фрукты", "Абвгд"),
                new Record("Заголовок 6", "Цветы", "Абвгд"),
                new Record("Заголовок 7", "Цветы", "Абвгд"),
            };

            lv_search_result.ItemsSource = records;
        }
    }
}
