using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProyecto2.Utilities;
using System.Windows.Input;

namespace WPFProyecto2.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object currentView;
        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand TransactionsCommand { get; set; }
        public ICommand ShipmentsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Product(object obj) => CurrentView = new ProductVM();
        private void Order(object obj) => CurrentView = new OrderVM();
        private void Transaction(object obj) => CurrentView = new TransactionVM();
        private void Shipment(object obj) => CurrentView = new ShipmentVM();
        private void Setting(object obj) => CurrentView = new SettingVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            HomeCommand = new RelayCommand(Customer);
            HomeCommand = new RelayCommand(Product);
            HomeCommand = new RelayCommand(Order);
            HomeCommand = new RelayCommand(Transaction);
            HomeCommand = new RelayCommand(Shipment);
            HomeCommand = new RelayCommand(Setting);

            CurrentView = new HomeVM();
        }
    }
}
