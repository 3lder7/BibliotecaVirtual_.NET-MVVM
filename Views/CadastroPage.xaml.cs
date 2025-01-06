namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class CadastroPage : ContentPage
{
    public CadastroPage()
    {
        InitializeComponent();
    }

    private List<string> usuariosCadastrados = new List<string>(); 

    private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string nome = NomeEntry.Text;
            string senha = SenhaEntry.Text;
            
            if (usuariosCadastrados.Contains(email))
            {
                await DisplayAlert("Erro", "Usuário já cadastrado.", "OK");
            }
            else
            {
                usuariosCadastrados.Add(email);
                await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso!", "OK");
                await Navigation.PushAsync(new ());
            }

            
        }
        

}