namespace InformaFizzBuzz
{
    public interface ICalculation
    {
        string DisplayNumber(int number);
        int FizzCount { get; set; }
        int FizzBuzzCount { get; set; }
        int BuzzCount { get; set; }
        int LuckyCount { get; set; }
        int NumberCount { get; set; }


    }
}
