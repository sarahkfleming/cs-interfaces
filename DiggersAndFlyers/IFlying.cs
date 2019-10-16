namespace DiggersAndFlyers
{
    public interface IFlying
    {
        double WindSpeed { get; set; }
        void Fly();
        void Land();
    }
}