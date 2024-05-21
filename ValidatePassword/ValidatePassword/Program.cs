namespace ValidatePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password1 = "SalamPB201!";
            string password2 = "salamPB201!";
            string password3 = "SalamPB201";
            string password4 = "Salam2!";

            Console.WriteLine("Password1!: " + ValidatePassword(password1)); 
            Console.WriteLine("password1!: " + ValidatePassword(password2)); 
            Console.WriteLine("Password!: " + ValidatePassword(password3)); 
            Console.WriteLine("Password123: " + ValidatePassword(password4)); 

        }

        static bool ValidatePassword(string password) 
        {
        if (password.Length <8)
           return false;
           
        if (char.IsLower(password[0]))
           return false;

            bool containsNumber = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    containsNumber = true;
                    break;
                }
            }
            if (!containsNumber)
                return false;


            bool containsSpecialCharacter = false;
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    containsSpecialCharacter = true;
                    break;
                }
            }
            if (!containsSpecialCharacter)
                return false;


            return true;
        }
    }
}
