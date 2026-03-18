class Program
{
    static void main(String[] args)
    {
        //pierwsza instrukcja/print
        Console.WriteLine("Please enter digits separated by commas: ");
        
        string inputs = Console.ReadLine();
        List<int> digits = inputs.Split(',')
            .Select(x => int.Parse(x)).ToList();
        
        
        
        
        
    }
}