using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Spha.Views

{
    public class SplashView : ContentPage
    {
       public Image SplashImage;
        public SplashView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "icon1.png",
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage,AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, 
                new Rectangle(0.1, 0.1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SplashImage);
            this.BackgroundColor =Color.White;
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await SplashImage.ScaleTo(1, 2000);
            await SplashImage.ScaleTo(0.9, 1500,Easing.BounceOut);
            await SplashImage.ScaleTo(500, 1200, Easing.BounceOut);
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.HomeView());
        }
    }
}
