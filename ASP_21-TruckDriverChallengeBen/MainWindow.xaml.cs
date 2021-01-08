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

namespace ASP_Challenge_21
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rslt.Content = "";
            
            //Comments stink, this is where i am doing everything at once, formating and putting them in to a variable and intstantiation
            //doing this for the optional extra pay
            double ext = 0;
            //getting days
            DateTime /*it means you didn't pick a date*/day1 = cld2.SelectedDate.Value, day2 = cld1.SelectedDate.Value;
            TimeSpan days = day1 - day2;
            string tDays = days.TotalDays.ToString();
            int totalDays = int.Parse(tDays);
            //converting numbers
            long phn = long.Parse(tx3.Text);
            int sscn = int.Parse(tx2.Text);
            if (cbx.IsChecked == true) {ext = .12; }
            long tMiles = int.Parse(tx3_Copy.Text) - int.Parse(tx3_Copy1.Text);

            //Comments stink, this is where i am doing everything at once, formating and putting them in to a variable and intstantiation

            string result = string.Format("Driver Name - {0}\n\n", tx1.Text);
            result += string.Format("Social Security Number: {0:000-00-0000}\n\n",sscn);
            result += string.Format("Phone Number: {0:(000)000-0000\n\n}", phn);
            result += string.Format("Total Miles: {0}\n\n", tMiles);
            result += string.Format("Total Dates Out: {0}\n\n", totalDays);
            result += string.Format("Total Pay (before taxes of 52%): {0:c}\n\n",tMiles*(.25+ext));
            result += string.Format("Vacation Days Earned: {0}", ((totalDays/5)-(totalDays%5)/10)*2);
            
            //i am aware i could do this faster with more variables, but isnt the point to do it the hardest way so i can learn?
            rslt.Content = result;
        }
    }
}
