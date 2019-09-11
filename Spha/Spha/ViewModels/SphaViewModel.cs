using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TheWather.ViewModels;
using Xamarin.Forms;

namespace Spha.ViewModels
{
    public class SphaViewModel:BaseViewModel
    {
        private string counter;//Counter Text of spha
        private string textSpha;//Text of spha in Zahra spha
        /*
         string type is Type of spha
         "1" Means that Open spha
         "2" Means that Zahra spha
         "3" Means that One Hundred spha 
        */
        public string type;
        public int i = 0;//counter 1
        public int j = 0;//counter 2
        public int f = 0;//counter 3
        public ICommand AddSpha { get; }//Command of spha button (تسبيح)
        public ICommand ZeroSpha { get; }//Command of zero button (أعد)
        public SphaViewModel(INavigation navigation, string Ty) : base(navigation)
        {
            type = Ty;
            AddSpha = new Command(Tspeh);
            ZeroSpha = new Command(ZeroTspeh);
        }
        public string TextSpha
        {
            get => textSpha;
            set => SetProperty(ref textSpha, value);
        }
        public string Counter
        {
            get => counter;
            set => SetProperty(ref counter, value);
        }
        private void Tspeh()
        {
            if (type == "1")
            { 
                First_Therd_Type();
            }
            if (type == "3")
            {
                if (i < 100)
                {
                    First_Therd_Type();
                }
            }
            if (type == "2")
            {
                SecondType();
            }
        }
        private void First_Therd_Type()
        {
            i++;
            Counter = i.ToString();
        }
        private void SecondType()
        {
            if (i < 34)
            {
                TextSpha = "الله أكبر";
                i++;
                Counter = i.ToString();
            }
            if (i >= 33)
            {
                if (j < 33)
                {
                    TextSpha = "الحمد لله";
                    j++;
                    Counter = j.ToString();
                }
            }
            if ((i >= 33) && (j >= 32))
            {
                if (f < 33)
                {
                    TextSpha = "سبحان الله";
                    f++;
                    Counter = f.ToString();
                }
            }
        }
        private void ZeroTspeh()
        {
            if (type == "1" || type == "3")
            {
                i = 0;
                Counter = "0";
            }
            if (type == "2")
            {
                i = 0; j = 0; f = 0;
                TextSpha = "الله أكبر";
                Counter = "0";
            }
        }
    }
}
