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
            FillComboBoxes(ref allColors);
           
           
            
        }
        private void ChoosingLabelColors(object sender, RoutedEventArgs e)
        {
        
            //
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                string selectedColor = comboBox.SelectedItem.ToString();
               
                SolidColorBrush colorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedColor));

                switch (comboBox.Name)
                {
                    case "firstComboBox":
                        firstLabel.Background = colorBrush;
/*                        firstLabel.Content = selectedColor;
*/
                        break;
                    case "secondComboBox":
                        secondLabel.Background = colorBrush;
/*                        secondLabel.Content = selectedColor;
*/                        break;
                    case "thirdComboBox":
                        thirdLabel.Background = colorBrush;
/*                        thirdLabel.Content = selectedColor;
*/                        break;
                    case "fourthComboBox":
                        fourthLabel.Background = colorBrush;
/*                        fourthLabel.Content = selectedColor;
*/                        break;
                }
            }

        }
        private void FillComboBoxes(ref string[] items)
        {
            foreach (var item in items)
            {
                firstComboBox.Items.Add(item);
                secondComboBox.Items.Add(item);
                thirdComboBox.Items.Add(item);
                fourthComboBox.Items.Add(item);
            }

          
        }

       

        private void controlButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}