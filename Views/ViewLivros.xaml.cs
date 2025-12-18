using bibliotecaVirtual_com_MVVM_.Models;
using bibliotecaVirtual_com_MVVM_.Services;

namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class ViewLivros : ContentPage
{
    public ViewLivros()
    {
        InitializeComponent();
    }

    private void Edit_Clicked(object sender, EventArgs e)
    {

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