using System.Collections.Generic;

namespace ClassyElectronics
{
    public class Radio : IRadio, ISpeaker // a radio with speakers
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }
        public bool IsRadioOn { get; set; }
        public int Volume { get; set; }

        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }

        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }

        public void TurnRadioOff()
        {
            IsRadioOn = false;
        }

        public void TurnRadioOn()
        {
            IsRadioOn = true;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeUp()
        {
            Volume++;
        }
    }
}