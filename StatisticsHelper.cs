namespace apbd_cw1_git_s30717;
using System.Collections.Generic;

public class StatisticsHelper
{
    //prosta metoda
    public int Sum(List<int> digitz)
    {
        int sum = 0;
        foreach (var d in digitz)
        {
            sum += d;
        }
        return sum;
    }

    //ekstra metoda
    public double Average(List<int> valuez)
    {
        double sum = 0;
        foreach (var v in valuez)
        {
            sum += v;
        }

        return sum / valuez.Count;
    }
    //metoda (może powinnam była użyć int[] od początku, a nie List,,)
    public int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (var v in values)
        {
            if(v>max) max = v;
        }

        return max;
    }

    public int CalculateMin(int[] values)
    {
        int min = values[0];
        foreach (var v in values)
        {
            if(v<min) min = v;
        }
        return min;
    }
}