using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Solitaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btndeal_Click(object sender, RoutedEventArgs e)
        {
            //creating list and adding images to it
            List<string> listofcards = new List<string>();
            listofcards.Add("spades1");
            listofcards.Add("spades2");
            listofcards.Add("spades3");
            listofcards.Add("spades4");
            listofcards.Add("spades5");
            listofcards.Add("spades6");
            listofcards.Add("spades7");
            listofcards.Add("spades8");
            listofcards.Add("spades9");
            listofcards.Add("spades10");
            listofcards.Add("spades11");
            listofcards.Add("spades12");
            listofcards.Add("spades13");
            listofcards.Add("hearts1");
            listofcards.Add("hearts2");
            listofcards.Add("hearts3");
            listofcards.Add("hearts4");
            listofcards.Add("hearts5");
            listofcards.Add("hearts6");
            listofcards.Add("hearts7");
            listofcards.Add("hearts8");
            listofcards.Add("hearts9");
            listofcards.Add("hearts10");
            listofcards.Add("hearts11");
            listofcards.Add("hearts12");
            listofcards.Add("hearts13");
            listofcards.Add("clubs1");
            listofcards.Add("clubs2");
            listofcards.Add("clubs3");
            listofcards.Add("clubs4");
            listofcards.Add("clubs5");
            listofcards.Add("clubs6");
            listofcards.Add("clubs7");
            listofcards.Add("clubs8");
            listofcards.Add("clubs9");
            listofcards.Add("clubs10");
            listofcards.Add("clubs11");
            listofcards.Add("clubs12");
            listofcards.Add("clubs13");
            listofcards.Add("diamonds1");
            listofcards.Add("diamonds2");
            listofcards.Add("diamonds3");
            listofcards.Add("diamonds4");
            listofcards.Add("diamonds5");
            listofcards.Add("diamonds6");
            listofcards.Add("diamonds7");
            listofcards.Add("diamonds8");
            listofcards.Add("diamonds9");
            listofcards.Add("diamonds10");
            listofcards.Add("diamonds11");
            listofcards.Add("diamonds12");
            listofcards.Add("diamonds13");
 
            List<string> listofimages = new List<string>();

            //randomly generate cards to deal out
            var random = new Random();

            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(listofcards.Count);
                listofimages.Add(@"C:\Users\14052\source\repos\kvu2016\Kelly-s-Final-Project\Solitaire\Solitaire\Images\" + listofcards[index].ToString() + ".gif");
            }
            //setting images to image box
            Card0.Source = new BitmapImage(new Uri(listofimages[0]));
            Card1.Source = new BitmapImage(new Uri(listofimages[1]));
            Card2.Source = new BitmapImage(new Uri(listofimages[2]));
            Card3.Source = new BitmapImage(new Uri(listofimages[3]));
            Card4.Source = new BitmapImage(new Uri(listofimages[4]));
            Card5.Source = new BitmapImage(new Uri(listofimages[5]));
            Card6.Source = new BitmapImage(new Uri(listofimages[6]));
            Card7.Source = new BitmapImage(new Uri(listofimages[7]));

            Card1.Visibility = Visibility.Visible;
        }
    }
}
