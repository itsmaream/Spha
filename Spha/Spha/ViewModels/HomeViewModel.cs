using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TheWather.ViewModels;
using Xamarin.Forms;

namespace Spha.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public ICommand ZahraSpha { get; }
        public ICommand OneHundredSpha { get; }
        public ICommand OpenSpha { get; }
        public HomeViewModel(INavigation navigation) : base(navigation)
        {
            OpenSpha = new Command(GoToOpenSpha);
            ZahraSpha = new Command(GoToZahraSpha);
            OneHundredSpha = new Command(GoToOneHundredSpha);
        }
        private async void GoToOpenSpha()
        {
            await Navigation.PushModalAsync( new Views.SphaView("1"));
        }
        private async void GoToZahraSpha()
        {
            await Navigation.PushModalAsync(new Views.SphaView("2"));
        }
        private async void GoToOneHundredSpha()
        {
            await Navigation.PushModalAsync(new Views.SphaView("3"));
        }
    }
}
