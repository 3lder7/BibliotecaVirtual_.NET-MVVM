using bibliotecaVirtual_com_MVVM_.Models;
using bibliotecaVirtual_com_MVVM_.Services;
using System.Threading.Tasks;

namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class ViewLivros : ContentPage
{
    public ViewLivros()
    {
        InitializeComponent();
    }

    private async void Edit_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditarLivro());
    }

    private async void Remove_Clicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is Livros livro)
        {
            bool confirm = await DisplayAlert("Remover", $"Deseja remover '{livro.Titulo}'?", "Remover", "Cancelar");
            if (!confirm) return;

            LivroService.Instance.RemoverLivro(livro);
        }
    }
}