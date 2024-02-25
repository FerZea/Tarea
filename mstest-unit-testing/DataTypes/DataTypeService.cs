using System.Text;

namespace DataTypes;

public class DataTypeService
{
    public string TryFitString(string input)
    {
        StringBuilder result = new StringBuilder();

        try
        {
            long number = long.Parse(input); 
            result.Append($"{number} can be fitted in:");
            
            if(number>=-128 && number<=127)
                result.Append(" *byte");
            if (number >= -32768 && number <= 32767)
                result.Append(" *short");
            if (number >= -2147483648 && number <= 2147483647)
                result.Append(" *int");
             if (number >= -9223372036854775808 && number <= 9223372036854775807)
                result.Append(" *long");
            // TODO: Complete the code.
        }
        catch(Exception)
        {
            result.Append(input + " can't be fitted anywhere.");
        }

        return result.ToString();
    }
}
