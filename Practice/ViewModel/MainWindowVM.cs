using Practice.DbEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice.ViewModel
{
    public class MainWindowVM : BaseViewModel
    {
        private UserInfo _SelectedItem;
        private ObservableCollection<UserInfo> _userinfot;

        public ObservableCollection<UserInfo> userinfo
        {
            get => _userinfot;
            set
            {
                _userinfot = value;
                OnPropertyChanged(nameof(userinfo));
            }
        }
        public UserInfo SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public MainWindowVM()
        {
            userinfo = new ObservableCollection<UserInfo>();

            LoadData();
        }

        public void LoadData()
        {
            if (userinfo.Count != 0)
            {
                userinfo.Clear();
            }

            var result = DbShopAnimal.Dd.UserInfo.ToList();
            result.ForEach(elem => userinfo?.Add(elem));
        }
        public void DeleteItenData()
        {
            if (!(SelectedItem is null))
            {
                using (var db = new TradeEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить этот элемент?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var ItemForDelete = db.UserInfo.Where(elem => elem.Id == SelectedItem.Id).FirstOrDefault();
                            db.UserInfo.Remove(ItemForDelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Данные успешно удалены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }
            }
        }
    }
}
