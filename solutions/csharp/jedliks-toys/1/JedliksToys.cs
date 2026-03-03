class RemoteControlCar
{
    private int distance;
    private double battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {this.distance} meters";

    public string BatteryDisplay() => this.battery > 0 ? $"Battery at {battery}%" : "Battery empty";

    public void Drive() 
    { 
        if (this.battery > 0) 
        {
        this.battery -= 1;
        this.distance += 20;
       
        }
    }  
}
