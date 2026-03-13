using System.Collections;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        phoneNumber = new string(phoneNumber.Where(x => char.IsDigit(x)).ToArray());
        if (phoneNumber.Length == 11 && phoneNumber[0] == '1')
        {
            phoneNumber = phoneNumber.Remove(0, 1);
        }
        if (phoneNumber.Length == 10)
        {
            int i;
            for (i = 0; i < phoneNumber.Length; i++)
            {
                switch (i)
                {
                    case 0:
                    case 3:
                        char element = phoneNumber[i];
                        List<char> chars = new List<char>
                        {
                            {'0'},
                            {'1'}
                        };
                        if (chars.Contains(element)) throw new ArgumentException();
                        break;
                    default:
                        break;
                }
            }
            return phoneNumber;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}