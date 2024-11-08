using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mastermind_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
            string[] allColors = { "white", "green", "blue", "red", "orange", "yellow" };
        
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            string[] chosenColor = new string[4];

            for(int i = 0; i< 4; i++)
            {
                int color = rnd.Next(allColors.Length);
                chosenColor[i] = allColors[color];


            }
            Mastermind.Title = "MasterMind (" + string.Join(",", chosenColor) + ")";

        }

        private void controlButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}