Random coin = new Random();
int theFlip = coin.Next(0,2);
Console.WriteLine((theFlip == 0) ? "heads" : "tails");