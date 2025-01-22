// Общий интерфейс для всех аккаунтов
public interface IAccount
{
    double Balance { get; set; }
    double Interest { get; set; }
    void CalculateInterest();
}

// Базовый класс 
public abstract class AccountBase : IAccount
{
    public double Balance { get; set; }
    public double Interest { get; set; }
    public abstract void CalculateInterest();
}

// Конкретные реализации для каждого типа аккаунта
public class RegularAccount : AccountBase
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;
        else if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}

public class SalaryAccount : AccountBase
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}
