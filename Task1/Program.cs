Console.WriteLine("************* Welcome To Our Program *************");

Console.WriteLine("- Enter Type of Client: ");
string clientType=Console.ReadLine().ToLower();

double discount = 0, extraDiscount = 0, totalDiscount, finalAmount;

if (clientType != "gold" && clientType != "silver" && clientType != "regular")
{
    Console.WriteLine("The Client Type is Unknown");
}
else
{
    Console.WriteLine("- Enter the Amount of Bill: ");
    double bill = Convert.ToDouble(Console.ReadLine());

    if (clientType == "gold")
    {
        discount = 0.20;
    }
    else if (clientType == "silver")
    {
        discount = 0.10;
    }
    else if (clientType == "regular")
    {
        discount = 0.05;
    }

    if (bill > 100)
    {
        if (clientType == "gold")
        {
            extraDiscount = 0.05;
        }
        else if (clientType == "silver")
        {
            extraDiscount = 0.03;
        }
        else 
        {
            extraDiscount = 0.02;
        }

    }
    
    totalDiscount = bill * (discount + extraDiscount);
    finalAmount = bill - totalDiscount;

    Console.WriteLine("- Results:");

    Console.WriteLine($"> Discount= {discount} JD");
    Console.WriteLine($"> Total Discount= {totalDiscount} JD");
    Console.WriteLine($"> Final Amount= {finalAmount} JD");

    Console.WriteLine("**** Thank You ****");


}

