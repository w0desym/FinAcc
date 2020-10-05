using FinAcc.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinAcc.ViewModels
{
    class ItemViewModel : ViewModelBase
    {
        public int Id { get; set; }

        private string _name;
        private int _price;
        private int _count;

        public ItemViewModel(INavigationService navigationService) 
            : base(navigationService) { }

        public ItemViewModel(Item item, INavigationService navigationService) 
            : base(navigationService) {
            Id = item.Id;
            _name = item.Name;
            _price = item.Price;
            _count = item.Count;
        }

        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value);}
        }

        public int Price
        {
            get { return _price; }
            set { SetValue(ref _price, value); }
        }

        public int Count
        {
            get { return _count; }
            set { SetValue(ref _count, value); }
        }
    }
}
