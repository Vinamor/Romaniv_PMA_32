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

namespace WpfApplication1
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
    }

    public abstract class Flight
    {
        private int flightNumber;
        private string destination;
        private string departure;
        private DateTime departureTime;
        private DateTime landingTime;
        private bool isMultyStop;
        private string multyStop;
        private string planeType;
        private int seatAmount;
        private decimal cost;



      abstract public decimal costOfFlight()
       {
           return cost;
       }
    }

    public class SingleTicket : Flight
    {
        private string passangerName;
        private string passangerSurname;
        private int passengersAmount;
        private string seatNumber;
     
    }

    public class GroupTicket: SingleTicket
    {
        private int passengersAmount;

       override public decimal costOfFlight()
        {
            return costOfFlight() * passengersAmount;
        }

    }
}
