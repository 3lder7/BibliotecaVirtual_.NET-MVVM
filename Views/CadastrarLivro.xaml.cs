namespace bibliotecaVirtual_com_MVVM_.Views;
using Microsoft.Maui.Media;

public partial class CadastrarLivro : ContentPage
{
	public CadastrarLivro()
	{
		InitializeComponent();
	}
    private async void OnPickImageClicked(object sender, EventArgs e)
    {
        try
        {
        // pede ao usuário para selecionar uma foto
        FileResult photo = await MediaPicker.PickPhotoAsync();

            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                Imagem.Source = ImageSource.FromStream(() => stream);
            }
        }
        catch (Exception ex)
        {
        Console.WriteLine($"Erro ao selecionar a foto: {ex.Message}");
        }
    }
}