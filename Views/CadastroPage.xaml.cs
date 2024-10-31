namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class CadastroPage : ContentPage
{
    public CadastroPage()
    {
        InitializeComponent();
    }
    private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string nome = NomeEntry.Text;
            string senha = SenhaEntry.Text;

            DisplayAlert("Cadastro", "Cadastro realizado com sucesso!", "OK");
            
        
        }
        

}