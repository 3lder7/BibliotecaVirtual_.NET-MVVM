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
                await DisplayAlert("Erro", "Usu�rio j� cadastrado.", "OK");
            }
            else
            {
                usuariosCadastrados.Add(email);
                await DisplayAlert("Sucesso", "Usu�rio cadastrado com sucesso!", "OK");
                await Navigation.PushAsync(new ());
            }

            
        }
        

}