using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinAcc.ViewModels
{
    public class AddItemPageViewModel : ViewModelBase
    {
        public AddItemPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Adding Item";
        }
    }
}
