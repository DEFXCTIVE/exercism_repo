using System.Runtime.InteropServices;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int distance = 0;
    private int battery = 100;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    public bool BatteryDrained() => this.battery < this.batteryDrain;

    public int DistanceDriven() => this.distance;

    public void Drive()
    {
        if (this.BatteryDrained()) return;
        this.distance += this.speed;
        this.battery = this.battery - batteryDrain;

    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() < this.distance)
        {
            car.Drive();
        }
        return car.DistanceDriven() >= this.distance;
    }
}
