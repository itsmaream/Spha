using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spha.NotUsed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SphaPage : ContentPage
    {
        public SphaPage()
        {
            InitializeComponent();
        }
        public string Type;
        public SphaPage(string T)
        {
            Type = T;
            InitializeComponent();
        }

        private void Bustart_Clicked(object sender, EventArgs e)
        {
            if(Type=="1"||Type=="3")
            {
                i = 0;
                laC.Text = "0";
            }
            if(Type=="2")
            {
                i = 0;j = 0;f = 0;
                laL.Text = "الله أكبر";
                laC.Text = "0";
            }
        }

        private void BuFirst_Clicked(object sender, EventArgs e)
        {
            if(Type=="1")
            laC.Text = First_Therd_Type();
            if (Type == "3")
            {
                if (i < 100)
                {
                    laC.Text = First_Therd_Type();
                }
            }
            if(Type=="2")
            {
                SecondType();
            }
        }
        public int i = 0;
        public int j = 0;
        public int f = 0;
        public string First_Therd_Type()
        {
            i++;
            return i.ToString();
        }
        public void SecondType()
        {
            laL.IsVisible = true;
            if (i < 34)
            {
                laL.Text = "الله أكبر";
                i++;
                laC.Text = i.ToString();
            }
            if (i >= 33)
            {
                if (j < 33)
                {
                    laL.Text = "الحمد لله";
                    j++;
                    laC.Text = j.ToString();
                }
            }
            if ((i >= 33) && (j >= 32))
            {
                if (f < 33)
                {
                    laL.Text = "سبحان الله";
                    f++;
                    laC.Text = f.ToString();
                }
            }
        }
    }
}