using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageTestApp1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Im1.Source= "https://www.beiz.jp/images_M/sky/sky_00001.jpg";

            Image im = new Image { Source = "https://www.beiz.jp/images_M/sky/sky_00001.jpg" };
            st1.Children.Add(im);
        }
    }
}
