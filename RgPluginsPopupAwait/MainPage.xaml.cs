using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace RgPluginsPopupAwait
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnMainPage2_Clicked(object sender, System.EventArgs e)
        {

            //If you uncomment the line below and comment out the next
            //2 lines - the execution will no longer pause before
            //opening MaingPage2.

            //await Navigation.PushPopupAsync(new MainPagePopup());

            var mainPagePopup = new MainPagePopup();
            await mainPagePopup.Show();

            //Execution will pause here waiting for mainPagePopup because show
            //is waiting for TaskCompletionSource to be set to true.

            Application.Current.MainPage = new NavigationPage(new MainPage2())
            {
                BackgroundColor = Color.Blue
            };
        }
    }
}
