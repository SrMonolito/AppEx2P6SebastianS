using AppEx2P6SebastianS.Views;

namespace AppEx2P6SebastianS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BienvenidaPage());
        }
    }
}
