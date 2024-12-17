using PatkoStefaniaLab11.Data;

namespace PatkoStefaniaLab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

        }
    }
}
