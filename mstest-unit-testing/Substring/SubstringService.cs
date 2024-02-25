namespace Substring;

public class SubstringService
{
    public Tuple<string, string> SplitInput(string input)
    {
        // TODO: Complete the code
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input string cannot be null or empty."); //es como un exit failure??

            string []parts = input.Split(' ');
            
            return Tuple.Create("myString is: "+ parts[0],"myInt is: " + parts[1]);
    }
}
