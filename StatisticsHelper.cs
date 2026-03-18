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
}