string thing = "      Trimm me       ";
Console.WriteLine($"{thing}");

string trimmablething = thing.TrimStart();
Console.WriteLine($"{trimmablething}");

trimmablething = thing.TrimEnd();
Console.WriteLine($"{trimmablething}");

trimmablething = thing.Trim();
Console.WriteLine($"{trimmablething}");
