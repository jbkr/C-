interface IRunnable
{
    void Run();
}

interface IFlyable
{
    void Fly();
}

class FlyingCar : IRunnable, IFlyable
{
    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        FlyingCar car = new FlyingCar();
        car.Run();
        car.Fly();

        IRunnable runnable = car as IRunnable;
        runnable.Run();
        IFlyable flyable = car as IFlyable;
        flyable.Fly();
    }
}