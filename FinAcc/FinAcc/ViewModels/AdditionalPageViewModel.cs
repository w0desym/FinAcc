using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace FinAcc.ViewModels
{
    public class AdditionalPageViewModel : ViewModelBase
    {
        public AdditionalPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Additional Page";
        }

        public ICommand AddItem { private set; get; }
        async void AddItem()
        {
            
        }
    }
}
