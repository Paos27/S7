using S7.Models;

namespace S7
{
    public partial class App : Application
    {
        public static PersonRepository personRepo { get; set; }
        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new Vista.vPersona();
            personRepo = personRepository;

        }
    }
}
