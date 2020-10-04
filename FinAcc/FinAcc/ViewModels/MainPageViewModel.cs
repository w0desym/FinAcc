using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinAcc.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }

        private DelegateCommand navigateToItems;
        public DelegateCommand ShowItemsCommand =>
            navigateToItems ?? (navigateToItems = new DelegateCommand(ShowItems));

        private DelegateCommand navigateToAddItem;
        public DelegateCommand AddItemCommand =>
            navigateToAddItem ?? (navigateToAddItem = new DelegateCommand(AddItem));


        async void ShowItems()
        {
            await _navigationService.NavigateAsync("ItemsPage");
        }

        async void AddItem()
        {
            await _navigationService.NavigateAsync("AddItemPage");
        }

        async void ClearTable()
        {
            //clear the table;
        }
    }
}
