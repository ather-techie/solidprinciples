// Applying OCP: Use an abstract class for discount strategies
public interface IDiscount
{
    double Apply(double amount);
}

public class RegularDiscount : IDiscount
{
    public double Apply(double amount) => amount;
}

public class PremiumDiscount : IDiscount
{
    public double Apply(double amount) => amount * 0.9;
}

public class InvoiceOCP
{
    private readonly IDiscount _discount;

    public InvoiceOCP(IDiscount discount) => _discount = discount;

    public double CalculateTotal(double amount) => _discount.Apply(amount);
}






// Violates OCP: Direct modification is needed to add new discounts
public class Invoice
{
    // customer type: Regular, Premium
    public double CalculateTotal(double amount, string type)
    {
        if (type == "Regular") return amount;
        if (type == "Premium") return amount * 0.9; // 10% discount
        return amount;
    }
}


