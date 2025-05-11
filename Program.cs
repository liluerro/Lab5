using System;

interface IParent
{
    string Info();           
    void Metod();            
}

class Child1 : IParent 
{
    private double speed;       
    private double costPrice;  
    private double price;      

    public Child1(double speed, double costPrice)
    {
        this.speed = speed;
        this.costPrice = costPrice;
    }

    public void Metod()
    {
        if (speed != 0)
            price = costPrice / speed;
        else
            price = 0;
    }

    public string Info()
    {
        return $"[Морський транспорт] Швидкiсть: {speed}, Собiвартiсть: {costPrice}, Вартiсть: {price}";
    }
}

class Child2 : IParent
{
    private double speed;         
    private double costPrice;    
    private double price;      
    private double roadTax;   

    public Child2(double speed, double costPrice, double roadTax)
    {
        this.speed = speed;
        this.costPrice = costPrice;
        this.roadTax = roadTax;
    }

    public void Metod()
    {
        if (speed != 0)
            price = (costPrice / speed) + roadTax;
        else
            price = roadTax;
    }

    public string Info()
    {
        return $"[Наземний транспорт] Швидкiсть: {speed}, Собiвартiсть: {costPrice}, Дорожнiй збiр: {roadTax}, Вартiсть: {price}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        for (int i = 0; i < 5; i++)
        {
            double speed = rand.Next(10, 101);
            double costPrice = rand.Next(1000, 10001); 

            IParent transport;

            if (rand.Next(2) == 0) 
            {
                transport = new Child1(speed, costPrice);
            }
            else 
            {
                double roadTax = rand.Next(50, 201); 
                transport = new Child2(speed, costPrice, roadTax);
            }

            transport.Metod();
            Console.WriteLine(transport.Info()); 
        }
    }
}
