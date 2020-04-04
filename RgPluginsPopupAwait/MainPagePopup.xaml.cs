using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace RgPluginsPopupAwait
{
    public partial class MainPagePopup : PopupPage
    {
        TaskCompletionSource<bool> _tcs = null;
        public MainPagePopup()
        {
            InitializeComponent();
        }

        async void btnOpenMainPage2_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAllPopupAsync();
            _tcs?.SetResult(true);
        }

        public async Task<bool> Show()
        {
            _tcs = new TaskCompletionSource<bool>();
            await Navigation.PushPopupAsync(this);
            return await _tcs.Task;
        }
    }
}
