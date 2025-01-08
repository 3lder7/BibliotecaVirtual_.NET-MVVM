namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string senha = SenhaEntry.Text;

        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            // adicionar l�gica para verificar as credenciais do usu�rio

            // mensagem tempor�ria de sucesso
            await DisplayAlert("Login", "Login realizado com sucesso!", "OK");
            await Navigation.PushAsync(new Inicial());
        }
        else
        {
            //mensagem de erro se o usu�rio n�o preencher todos os campos
            await DisplayAlert("Erro", "Por favor, insira o email e a senha.", "OK");
        }
    
    }
}
