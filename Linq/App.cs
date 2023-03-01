public class App
{
    //Test

    // Test for code review

    //sadsad






    //asdfsdfsdfsadadadsasdasdasd
    public int RabbatPercent()
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            return 10;
        return 0;
    }
    
    public void Lab1()
    {
        var annons = new
        {
            Seller = "Stewe Berggren",
            Title = "Playstation 5",
            Description = "Nästan oanvänd",
            Price = 100m,
            Created = DateTime.Now,
            EndDate = DateTime.Now.AddDays(30),
            Rabatt = RabbatPercent(),
            Bids = new []
            {
                new
                {
                    Name="Kalle",
                    Date =new DateTime(2022,11,5),
                    Price=2100
                },
                new
                {
                    Name="Lisa",
                    Date =new DateTime(2022,11,6),
                    Price=2200
                }
            } 
        };
        Console.WriteLine($"Hej {annons.Seller}\n {annons.Title}");
        foreach (var bids in annons.Bids)
        {
            Console.WriteLine($"{bids.Name} {bids.Date} {bids.Price}");

        }
    }


    public void Run()
    {
        Lab1();
    }
}

