namespace LoginBasico
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void logginBTN_Clicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            if(username == "TrAndroid" && password == "12345")
            {
                await DisplayAlert("Inicio de sesión", "¡Inicio de sesión exitoso!", "OK");
                await Navigation.PushAsync(new NewPage1());
            }
            else
            {
                await DisplayAlert("Inicio de sesión fallido", "Usuario o contraseña incorrectos.", "OK");
            }
           
        }
    }
}