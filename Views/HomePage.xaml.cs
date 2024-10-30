using Microsoft.Maui.Controls;

namespace bibliotecaVirtual_com_MVVM_.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            //associa os eventos de clique aos botões
            LoginButton.Clicked += LoginButton_Clicked;
            CadastroButton.Clicked += CadastroButton_Clicked;
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void CadastroButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());
        }
    }
}
