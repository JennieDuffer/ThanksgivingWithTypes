using ThanksgivingWithTypes;

var thxgvng = new Thanksgiving();

var thxgvngDay = Thanksgiving.Day.Thursday;

thxgvng.Turkey = "Mr. Gobbleton";

thxgvng.Food = new string[3] { "Green beans", "Mashed Potatoes", "Rolls" };

thxgvng.TurkeyWeight = 12;

Console.WriteLine($" Thanksgiving is always on {thxgvngDay}. \n");
Console.WriteLine($"The turkey weighs {thxgvng.TurkeyWeight}lbs this year! \n");
Console.WriteLine($"A few sides we will have with the turkey include: ");

foreach (var item in thxgvng.Food)
{
    Console.WriteLine($" {item}");
}
Console.WriteLine($" \n We are calling the turkey, { thxgvng.Turkey}.");    