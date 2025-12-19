namespace bibliotecaVirtual_com_MVVM_.Views;
using bibliotecaVirtual_com_MVVM_.Models;
using bibliotecaVirtual_com_MVVM_.Services;
public partial class EditarLivro : ContentPage
{
	public EditarLivro()
	{
		InitializeComponent();
	}

    private string? _imagemLocalPath;

    private async void OnPickImageClicked(object sender, EventArgs e)
    {
        try
        {
            // pede ao usuário para selecionar uma foto 
            FileResult photo = await MediaPicker.PickPhotoAsync();

            if (photo != null)
            {
                // copia a foto para o diretório local do app
                string localPath = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);

                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(localPath))
                {
                    await stream.CopyToAsync(newStream);
                }

                // guarda o caminho local
                _imagemLocalPath = localPath;

                // exibe a imagem
                Imagem.Source = ImageSource.FromFile(localPath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao selecionar a foto: {ex.Message}");
            await DisplayAlert("Erro", "Não foi possível carregar a imagem.", "OK");
        }
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
       
    }
}