namespace bibliotecaVirtual_com_MVVM_.Views;

public partial class Inicial : ContentPage
{
	public Inicial()
	{
		InitializeComponent();
	}

	public class Livro 
	{
		public string Titulo { get; set; }
		public string Autor {  get; set; }
		public string ImagemUrl { get; set; }
		public string Status { get; set; }
		public int QtdPaginas { get; set; }

	}
}