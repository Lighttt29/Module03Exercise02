using Microsoft.Maui.Controls;
using Module03Exercise01.Services;

namespace Module03Exercise01.View
{
    public partial class LoginPage : ContentPage
    {
        private readonly IMYService _myService; // Field for the service

        // Default constructor (if needed)
        public LoginPage()
        {
            InitializeComponent();
        }

        // Constructor with the service as a parameter
        public LoginPage(IMYService myService)
        {
            InitializeComponent(); // Initialize the components (like MyLabel)
            _myService = myService;

            // Use the service to set the text for MyLabel
            var message = _myService.GetMessage();
            MyLabel.Text = message; // Display the message in MyLabel
        }

        // Event handler for the login button click event
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Assuming EmployeePage is a valid page
            await Navigation.PushAsync(new EmployeePage());
        }
    }
}
