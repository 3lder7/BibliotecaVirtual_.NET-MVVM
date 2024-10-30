using bibliotecaVirtual_com_MVVM_.Views;

namespace bibliotecaVirtual_com_MVVM_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
