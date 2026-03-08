public static class Darts
{

    public static double distanceFromCenter(double x,double y) => Math.Sqrt(((x-0)*(x-0)) + ((y-0)*(y-0)));
    public static int Score(double x, double y)
    {   
        var d = distanceFromCenter(x,y);
        if(distanceFromCenter(x,y) <= 1) return 10;
        if(distanceFromCenter(x,y) <= 5) return 5;
        if(distanceFromCenter(x,y) <= 10) return 1;
        else return 0;
       
    }
}
