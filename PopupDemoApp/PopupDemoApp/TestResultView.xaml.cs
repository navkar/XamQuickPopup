using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupDemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestResultView
    {
        public TestResultView()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}