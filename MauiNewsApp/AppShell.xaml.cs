namespace MauiNewsApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            home.Command = new Command(async () => await Launcher.Default.OpenAsync("sewnet://launch"));
        }
    }
}
