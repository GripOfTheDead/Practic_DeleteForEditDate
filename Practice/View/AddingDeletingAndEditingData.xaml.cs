using Practice.ViewModel;
using Practice.DbEntity;
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
using System.Windows.Shapes;

namespace Practice.View
{
    /// <summary>
    /// Логика взаимодействия для AddingDeletingAndEditingData.xaml
    /// </summary>
    public partial class AddingDeletingAndEditingData : Window
    {
        private User user;

        public AddingDeletingAndEditingData()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        public AddingDeletingAndEditingData(User user)
        {
            this.user = user;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowVM).DeleteItenData();
        }
        public void refres()
        {
            (DataContext as MainWindowVM).LoadData();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var AddWindows = new AddOrEditGoodsWindow((DataContext as MainWindowVM).SelectedItem);
            AddWindows.ShowDialog();
        }
        
        private void BtnAddToDb_Click(object sender, RoutedEventArgs e)
        {
            var AddWindows = new AddOrEditGoodsWindow(null);
            AddWindows.ShowDialog();
        }
    }
}
