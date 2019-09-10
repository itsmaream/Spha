using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SphaView : ContentPage
    {
        public SphaView()
        {
            InitializeComponent();
        }
        public string type;
        public SphaView(string Ty)
        {
            InitializeComponent();
            type = Ty;
            BindingContext = new ViewModels.SphaViewModel(Navigation,type);
        }
    }
}