int number = 7454; 

string intToString = number.ToString(); 

char[] numbers = intToString.ToArray(); 

int[] counter = new int[10];

foreach (char digit in numbers)
{
    if (digit == '0')
    {
        counter[0]++;
    }
    else if (digit == '1')
    {
        counter[1]++;
    }
    else if(digit == '2')
    {
        counter[2]++;
    }
    else if (digit == '3')
    {
        counter[3]++;
    }
    else if (digit == '4')
    {
        counter[4]++;
    }
    else if (digit == '5')
    {
        counter[5]++;
    }
    else if (digit == '6')
    {
        counter[6]++;
    }
    else if (digit == '7')
    {
        counter[7]++;
    }
    else if (digit == '8')
    {
        counter[8]++;
    }
    else if (digit == '9')
    {
        counter[9]++;
    }
}

for(int i = 0; i < counter.Length; i++)
{
    Console.WriteLine("Cyfra {0} => {1} razy", i, counter[i]);
}



