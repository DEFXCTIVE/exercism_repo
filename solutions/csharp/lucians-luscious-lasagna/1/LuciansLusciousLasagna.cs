class Lasagna
{
    static int defaultMinutes = 40;
    int remainingMinutes = defaultMinutes;
    static int layerTime = 2;
    public int ExpectedMinutesInOven()
    {
        return defaultMinutes;
    }
    public int RemainingMinutesInOven(int elapsedTime)
    {
        return remainingMinutes - elapsedTime;
    }
    public int PreparationTimeInMinutes(int layers){
        return layers * layerTime;
    }
    public int ElapsedTimeInMinutes(int layers ,int elapsedTime)
    {
        return this.PreparationTimeInMinutes(layers) + elapsedTime;
    }
}
