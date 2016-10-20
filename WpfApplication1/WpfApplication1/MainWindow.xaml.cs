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
        private Client client;

        override public decimal costOfFlight()
        {
            return costOfFlight();
        }
    }

    public class GroupTicket: Flight
    {
        private List<Client> listOfClients;
        
         override public decimal costOfFlight()
        {
            return costOfFlight() * listOfClients.Count;
        }
    }

     public class Client
    {
        private string firstName;
        private string lastName;
        private int passportNumber;
        private string seatNumber;
        private double maxLuggageWeigth;
        private string nameOfClass;
        private string seatType;
        private int comfortLevel;
    }


     public class FirstClassClient : Client
    {
        private bool limusineToHotel;
        private bool hotelRoomReservation;
    }

     public class BusinessClassClient : Client
    {
        private bool shoppingCatalogues;
        private bool limusineToHotel;
    }

     public class DisabledClient : Client
    {
        private bool additionalSeat;
        private bool accompanimentNeed;
        private bool wheelchair;
        private string specialRequests;
    }

     public class ClientWithAnimal : Client
    {
        private bool baggageCage;
    } 
}


