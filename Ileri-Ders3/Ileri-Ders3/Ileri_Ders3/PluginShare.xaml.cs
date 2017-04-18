using Plugin.Share;
using Plugin.Share.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ileri_Ders3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginShare : ContentPage
    {
        public PluginShare()
        {
            InitializeComponent();
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }

        private void btnShare_Clicked(object sender, EventArgs e)
        {
            ShareMessage share = new ShareMessage();
            share.Title = txtTitle.Text;
            share.Url = txtUrl.Text;
            share.Text = txtMessage.Text;

            if (String.IsNullOrEmpty(share.Title))
                share.Url = "https://www.acikakademi.com";
            //CrossShare.Current.Share(share, null);
            CrossShare.Current.OpenBrowser(share.Url, new BrowserOptions
            {
                ChromeShowTitle = true,
                UseSafariReaderMode = true,
                UseSafariWebViewController = true
            });
        }

        private void btnCopy_Clicked(object sender, EventArgs e)
        {
            if (CrossShare.Current.SupportsClipboard)
            {
                CrossShare.Current.SetClipboardText(txtTitle.Text);
                DisplayAlert(txtTitle.Text, " kopyalandı.", "OK");
            }
        }
    }
}
