class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => this.birdsPerDay[6];

    public void IncrementTodaysCount() => this.birdsPerDay[6]+=1;

    public bool HasDayWithoutBirds()
    {
        bool emptyDay = false;
       foreach (int dayCount in this.birdsPerDay)
       {
           if (dayCount == 0) 
           {
               emptyDay = true;
               return emptyDay;
            }
       }
        return emptyDay;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        int i;
        for (i=0;i<numberOfDays;i++) 
        {
            sum += this.birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
     int sum = 0;
    {
        int i = 0;
        for (i=0;i<7;i++) 
        {
            sum += this.birdsPerDay[i] >= 5 ? 1:0 ;
        }
    }
    return sum;
    }
}
