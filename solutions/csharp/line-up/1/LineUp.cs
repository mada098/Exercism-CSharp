public static class LineUp
{
    public static string Format(string name, int number)
    {
        if((number % 100 == 11) || (number % 100 == 12) || (number % 100 == 13))
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }

        var lastDigit = number % 10;
        switch(lastDigit){
            case 1:
                return $"{name}, you are the {number}st customer we serve today. Thank you!";           

            case 2:
                return $"{name}, you are the {number}nd customer we serve today. Thank you!";           

            case 3:
                return $"{name}, you are the {number}rd customer we serve today. Thank you!";           

            default:
                return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
        
    }
}
