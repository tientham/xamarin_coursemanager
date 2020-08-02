using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prism.Mvvm;
using Prism.Navigation;

namespace coursemanager.ViewModels
{
    public abstract class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                SetProperty(ref title, value);
            }
        }

        public virtual void Destroy()
        {
            ;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            Debug.WriteLine("--> BaseViewModel OnNavigatedFrom");
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            Debug.WriteLine("--> BaseViewModel OnNavigatedTo");
        }
    }
}
