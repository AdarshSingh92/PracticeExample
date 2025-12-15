string myName= "Adarsh Singh";
char[] arrayWithChar = myName.ToCharArray();

var left = 0;
var right = arrayWithChar.Length - 1;
while (left < right)
{
    // Swap characters
    var temp = arrayWithChar[left];
    arrayWithChar[left] = arrayWithChar[right];
    arrayWithChar[right] = temp;
    left++;
    right--;
}
Console.WriteLine(new string(arrayWithChar));
Console.ReadLine();

