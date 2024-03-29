namespace ClassyElectronics
{
    public class Speakanator3001 : ITurnTable, ISpeaker
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public int Volume { get; set; }

        public void Play()
        {
            IsPlaying = true;
        }

        public void Stop()
        {
            IsPlaying = false;
        }
        
        public void VolumeUp()
        {
            Volume++;
        }

        public void VolumeDown()
        {
            Volume--;
        }
    }
}