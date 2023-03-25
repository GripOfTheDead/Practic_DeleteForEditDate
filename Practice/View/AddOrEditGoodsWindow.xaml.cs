using Practice.DbEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для AddOrEditGoodsWindow.xaml
    /// </summary>
    public partial class AddOrEditGoodsWindow : Window
    {
        private UserInfo _userinfo;
        public AddOrEditGoodsWindow(UserInfo userinfo)
        {
            InitializeComponent();

           
            foreach (var item in App.Current.Windows)
            {
                if (item is AddingDeletingAndEditingData)
                {
                    this.Owner = item as Window;
                }
            }

            if (userinfo is null)
            {
                _userinfo = userinfo = new UserInfo();
            }
            else
            {
                _userinfo = userinfo;
            }
            this.DataContext = _userinfo;
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new TradeEntities())
            {
                try
                {


                    db.UserInfo.AddOrUpdate(_userinfo);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    (Owner as AddingDeletingAndEditingData)?.refres();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private StringBuilder ValidateEntities()
        {
            var result = new StringBuilder();
            if (_userinfo != null)
            {
                if (string.IsNullOrEmpty(_userinfo.UserSurname))
                {
                    result.AppendLine("Поле Фамилия не может быть пустым");
                }
                if (string.IsNullOrEmpty(_userinfo.UserName))
                {
                    result.AppendLine("Поле Имя не может быть пустым");
                }
            }
            return result;
        }
    }
}
