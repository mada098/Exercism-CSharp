public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        //    New York prefix check
        string nyPrefix = phoneNumber.Substring(0,3);
        bool nyCheck = false;
        if(nyPrefix == "212")
        {
            nyCheck = true;
        }

        //    Fake number check
        string fakePrefix = phoneNumber.Substring(4,3);
        bool fakeCheck = false;
        if(fakePrefix == "555")
        {
            fakeCheck = true;
        }

        //    Add the last 4 digits of the number directly when returning the tuple
        return (nyCheck, fakeCheck, phoneNumber.Substring(phoneNumber.Length - 4, 4));
        
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
