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
        public ICommand OpenSpha { get; }//Command for go to Open Spha (التسبيح المفتوح)
        public ICommand ZahraSpha { get; }//Command for go to Zahra Spha (تسبيح الزهراء)
        public ICommand OneHundredSpha { get; }//Command for go to One Hundred Spha (تسبيح مئة مرة)

        public HomeViewModel(INavigation navigation) : base(navigation)
        {
            OpenSpha = new Command(GoToOpenSpha);
            ZahraSpha = new Command(GoToZahraSpha);
            OneHundredSpha = new Command(GoToOneHundredSpha);
        }
        private async void GoToOpenSpha()
        {
            await Navigation.PushModalAsync( new Views.SphaView("1"));//Spha.ViewModels.SphaViewModel.Type="1"
        }
        private async void GoToZahraSpha()
        {
            await Navigation.PushModalAsync(new Views.SphaView("2"));//Spha.ViewModels.SphaViewModel.Type="2"
        }
        private async void GoToOneHundredSpha()
        {
            await Navigation.PushModalAsync(new Views.SphaView("3"));//Spha.ViewModels.SphaViewModel.Type="3"
        }
    }
}
