using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowMessageClicked(object sender, EventArgs e)
        {
            string inputText = numberEntry.Text;

            if (int.TryParse(inputText, out int number))
            {
                DisplayAlert("Повідомлення", $"Ви ввели число {number}", "OK");
            }
            else
            {
                DisplayAlert("Помилка", "Введено некоректне число", "OK");
            }
        }
    }
}
