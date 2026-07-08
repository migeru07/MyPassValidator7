using System.Linq;

namespace PassValidator.Core;

public class PassValidatorService
{
    public bool Validate(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }
        if (!password.Any(char.IsDigit))
        {
            return false;
        }
        return true; 
    }
}