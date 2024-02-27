using System.Globalization;
using System.Runtime.CompilerServices;

namespace testepedro
{
    public partial class MainPage : ContentPage
    {
        //Declarando variavel 
        int count = 0;
        string Nome = "";
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnNameclicked(object sender, EventArgs e)
        {
            Nome = NameEntry.Text;
            GreetingLabel.Text = Nome;
            SemanticScreenReader.Announce(GreetingLabel.Text);
        }
    }

}
