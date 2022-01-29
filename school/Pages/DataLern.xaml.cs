using System;
using System.Collections.Generic;
using System.IO;
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

namespace school.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataLern.xaml
    /// </summary>
    public partial class DataLern : Page
    {
        public DataLern()
        {
            InitializeComponent();
            ListView.ItemsSource = schoolEntities.GetContext().Services.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameWindow.MainFrame.Navigate(new AddService((sender as Button).DataContext as Service));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update((SortBox.SelectedItem as ComboBoxItem).Content.ToString(), TypeBox.Text);
        }

        private void TypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update(SortBox.Text, (TypeBox.SelectedItem as string).ToString());
        }


        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update(SortBox.Text, TypeBox.Text, SearchBox.Text);
            if (ListView.Items.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        public void Update(string sort = "", string filt = "", string searh = "")
        {
            var data = schoolEntities.GetContext().Services.ToList();
            if (!string.IsNullOrEmpty(searh) && !string.IsNullOrWhiteSpace(searh))
            {
                data = data.Where(p => p.Title.ToLower().Contains(searh.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(filt) && !string.IsNullOrWhiteSpace(filt))
            {
                if (filt != "Все")
                {
                    if (filt == "Скидка (0% - 15%)")
                    {
                        
                        
                    }    
                }
            }
            if (!string.IsNullOrWhiteSpace(sort) && !string.IsNullOrEmpty(sort))
            {
                if (sort == "Стоимость (по возрастанию)")
                {
                    data = data.OrderBy(p => p.Cost).ToList();
                }
                if (sort == "Стоимость (по убыванию)")
                {
                    data = data.OrderByDescending(p => p.Cost).ToList();
                }
                if (sort == "Размер скидки (по возрастанию)")
                {
                    data = data.OrderBy(p => p.Discount).ToList();
                }
                if (sort == "Размер скидки (по убыванию)")
                {
                    data = data.OrderByDescending(p => p.Discount).ToList();
                }
            }
            ListView.ItemsSource = data;
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
