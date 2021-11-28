void PrintIntArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }

    Console.WriteLine();
}


string[] Deck(string[] whatIsCard)
{
    whatIsCard = new string[312];

    for (int i = 0; i < 311; i++)
    {
        if (i >= 0 && i <= 23) whatIsCard[i] = "2";
        if (i >= 24 && i <= 47) whatIsCard[i] = "3";
        if (i >= 48 && i <= 71) whatIsCard[i] = "4";
        if (i >= 72 && i <= 95) whatIsCard[i] = "5";
        if (i >= 96 && i <= 119) whatIsCard[i] = "6";
        if (i >= 120 && i <= 143) whatIsCard[i] = "7";
        if (i >= 144 && i <= 167) whatIsCard[i] = "8";
        if (i >= 168 && i <= 191) whatIsCard[i] = "9";
        if (i >= 192 && i <= 215) whatIsCard[i] = "10";
        if (i >= 216 && i <= 239) whatIsCard[i] = "Валет";
        if (i >= 240 && i <= 263) whatIsCard[i] = "Дама";
        if (i >= 264 && i <= 287) whatIsCard[i] = "Король";
        if (i >= 288 && i <= 311) whatIsCard[i] = "Туз";

    }
    return whatIsCard;
}
string[] DeckOfCard = new string[312];
PrintIntArray(Deck(DeckOfCard));
System.Console.WriteLine("***********************");

string[] Shuffle(string[] array)
{
   
    for (int i = array.Length - 1; i >= 1; i--)
    {
        Random rand = new Random();
        int j = rand.Next(i + 1);
        string temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}
PrintIntArray(Shuffle(Deck(DeckOfCard))); 

string[,] Distribution(string[] array, int countOfPlayers)
{
    string[,] card = new string[countOfPlayers, 2];
}
PrintIntArray(Distribution(Shuffle(Deck(DeckOfCard))));







// int CardValue()
// {
//     int value = 0;
//     string[] result = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };
//     for (int i = 0; i < result.Length; i++)
//     {
//         if (result[i] == "2") value = 2;
//         if (result[i] == "3") value = 3;
//         if (result[i] == "4") value = 4;
//         if (result[i] == "5") value = 5;
//         if (result[i] == "6") value = 6;
//         if (result[i] == "7") value = 7;
//         if (result[i] == "8") value = 8;
//         if (result[i] == "9") value = 9;
//         if (result[i] == "10") value = 10;
//         if (result[i] == "Валет") value = 10;
//         if (result[i] == "Дама") value = 10;
//         if (result[i] == "Король") value = 10;
//         if (result[i] == "Туз") value = 11;
//     }
//     return value;
// }