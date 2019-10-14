using WGUPlanner.Views;
using Xamarin.Forms;

namespace WGUPlanner
{
    public partial class App : Application
    {
        public static PlannerRepository PlannerRepository { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            PlannerRepository = new PlannerRepository(dbPath);

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
