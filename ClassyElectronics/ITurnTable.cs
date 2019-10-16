namespace ClassyElectronics
{
    public interface ITurnTable
    {
        // Public is assumed in an interface. You don't have to mention it in the properties
        double CurrentSpeed { get; set; }        
        bool IsPlaying { get; set; }
        void Play();        
        void Stop();
    }
}