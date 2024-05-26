using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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


namespace JourneysGUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        JourneyContext _context = new JourneyContext();
        public ObservableCollection<Vehicle> vehicles { get; set; }
        public ObservableCollection<Journey> journeys { get; set; }
        public ObservableCollection<string> vehicleString { get; set; }

        private ObservableCollection<Journey> filteredJourneyst;

        public ObservableCollection<Journey> FilteredJourneys
        {
            get { return  filteredJourneyst; }
            set {  filteredJourneyst = value; }
        }

        private Journey selectedJourney;

        public Journey SelectedJourney
        {
            get { return selectedJourney; }
            set { selectedJourney = value; }
        }




        public event PropertyChangedEventHandler PropertyChanged;  
        public void OnPropertyChanged(string tulajdonsagnev)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagnev));
        }


        public void fill()
        {
            vehicleString = new ObservableCollection<string>();
            foreach(var i in vehicles)
            {
                string text = "";
                text += i.type + " " + journeys.Where(x => x.Vehicle.type == i.type).Count();
                vehicleString.Add(text);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            _context.Vehicles.Load();
            _context.Journeys.Load();
            

            vehicles = _context.Vehicles.Local.ToObservableCollection();
            journeys = _context.Journeys.Local.ToObservableCollection();

            fill();
            
        }

        private void journeys_CBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(journeys_CBX.SelectedItem != null)
            {
                Journey nev = (Journey)journeys_CBX.SelectedItem;
                SelectedJourney = FilteredJourneys.First(x => x.Country == nev.Country && x.Departure == nev.Departure);
            }
        }

        private void vehicle_LBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            description_TBX.Text = "";
            if(vehicle_LBX.SelectedItem != null)
            {
                string vType = vehicle_LBX.SelectedItem.ToString().Split(' ')[0];
                FilteredJourneys = new ObservableCollection<Journey>(journeys.Where(x => x.Vehicle.type == vType));
            }
        }
    }
}
