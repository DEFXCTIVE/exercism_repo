class Lasagna
{
    static int defaultMinutes = 40;
    int remainingMinutes = defaultMinutes;
    static int layerTime = 2;
    public int ExpectedMinutesInOven() =>  defaultMinutes;
    public int RemainingMinutesInOven(int elapsedTime) =>  remainingMinutes - elapsedTime;
    public int PreparationTimeInMinutes(int layers) =>  layers * layerTime;
    public int ElapsedTimeInMinutes(int layers ,int elapsedTime) =>  this.PreparationTimeInMinutes(layers) + elapsedTime;
}
