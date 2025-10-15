namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class Inicial : ContentPage
{
    public Inicial()
    {
        InitializeComponent();
    }

    private async void OnVisualizarLivrosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewLivros());
    }
}