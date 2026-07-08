namespace PassValidator.Core;

public class PassValidatorService
{
    public bool Validate(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }
        return true; 
    }
}