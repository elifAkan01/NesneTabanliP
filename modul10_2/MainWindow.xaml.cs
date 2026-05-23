using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace modul10_2 // XAML'deki local:clr-namespace ile aynı olmalı
{
    public partial class MainWindow : Window
    {
        // DBML dosyanın adı Northwind ise bu sınıf oluşur
        NorthwindDataContext context = new NorthwindDataContext();

        public MainWindow()
        {
            InitializeComponent();

            // Verileri yükle
            dataGrid1.ItemsSource = context.Categories.ToList();

            // Seçim değiştiğinde çalışacak olay
            dataGrid1.SelectionChanged += DataGrid1_SelectionChanged;
        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Seçilen satırı alttaki TextBox'ların bağlı olduğu Grid'e aktarır
            grid1.DataContext = dataGrid1.SelectedItem;
        }
    }
}