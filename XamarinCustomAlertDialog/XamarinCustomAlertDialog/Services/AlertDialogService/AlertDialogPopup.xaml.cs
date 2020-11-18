using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCustomAlertDialog.Services.AlertDialogService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertDialogPopup
    {
        private Func<bool, Task> callback;

        public AlertDialogPopup(string title, string message, string cancel, string ok, Func<bool, Task> callback)
        {
            this.callback = callback;

            InitializeComponent();
            LbTitle.Text = title;
            LbMessage.Text = message;
            BtCancel.IsVisible = !string.IsNullOrWhiteSpace(cancel);
            BtOk.Text = ok;
            BtCancel.Text = cancel;            
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            FrContent.HeightRequest = LbMessage.Height + 100 + FrContent.Padding.HorizontalThickness + GrContent.Margin.HorizontalThickness;
            FrContent.Opacity = 1;
        }

        private async void BtCancel_Clicked(object sender, EventArgs e)
        {
            await callback.Invoke(false);
        }

        private async void BtOk_Clicked(object sender, EventArgs e)
        {
            await callback.Invoke(true);
        }

        private async void BtClose_Clicked(object sender, EventArgs e)
        {
            await callback.Invoke(false);
        }
    }
}