using System;
using Xamarin.Forms;
using XamarinCustomAlertDialog.Services;

namespace XamarinCustomAlertDialog
{
    public partial class MainPage : ContentPage
    {
        private readonly IAlertDialogService alertDialogService;

        public MainPage()
        {
            alertDialogService = DependencyService.Get<IAlertDialogService>();
            InitializeComponent();
        }

        private async void BtInformation_Clicked(object sender, EventArgs e)
        {
            await alertDialogService.ShowDialogAsync("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed venenatis.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque pulvinar imperdiet pharetra. Etiam id laoreet turpis. Sed a sodales nibh, a finibus ipsum. Phasellus nisl magna, congue ac risus in, rutrum faucibus tellus. Suspendisse non vestibulum felis, eget luctus nisi. Etiam efficitur tristique ipsum, eget blandit purus maximus eget. Vestibulum non elit magna. Cras dictum at enim sed hendrerit. Donec commodo diam eget mi commodo, sed consequat tellus iaculis. Pellentesque elementum enim odio, at ultrices nunc venenatis sit amet. Nulla venenatis felis id dui rutrum, et maximus nulla molestie. Aenean convallis, diam a aliquam porttitor, sapien turpis venenatis purus, ut cursus orci sapien sit amet orci. Nulla imperdiet lorem consectetur nunc congue accumsan", "Cerrar");
        }

        private async void BtConfirmation_Clicked(object sender, EventArgs e)
        {
            bool result = await alertDialogService.ShowDialogConfirmationAsync("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed venenatis.", $"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque pulvinar imperdiet pharetra. Etiam id laoreet turpis. Sed a sodales nibh, a finibus ipsum. Phasellus nisl magna, congue ac risus in, rutrum faucibus tellus. Suspendisse non vestibulum felis, eget luctus nisi. Etiam efficitur tristique ipsum, eget blandit purus maximus eget. Vestibulum non elit magna. Cras dictum at enim sed hendrerit. Donec commodo diam eget mi commodo, sed consequat tellus iaculis. Pellentesque elementum enim odio, at ultrices nunc venenatis sit amet. Nulla venenatis felis id dui rutrum, et maximus nulla molestie. Aenean convallis, diam a aliquam porttitor, sapien turpis venenatis purus, ut cursus orci sapien sit amet orci.{Environment.NewLine}¿Desea continuar?", "No", "Si");
            LbResult.Text = result ? "Resultado confirmación: Si" : "Resultado confirmación: No";
        }
    }
}
