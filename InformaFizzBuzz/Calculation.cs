namespace InformaFizzBuzz
{
    public class Calculation : ICalculation
    {
        public int FizzCount { get; set; }

        public int FizzBuzzCount { get; set; }

        public int BuzzCount { get; set; }

        public int LuckyCount { get; set; }

        public int NumberCount { get; set; }



        public string DisplayNumber(int number)
        {
            if (number.ToString().Contains("3"))
            {
                LuckyCount++;
                return "lucky";
            }

            if (IsFizzBuzz(number))
            {
                FizzBuzzCount++;
                return "fizzbuzz";
            }
            if (IsFizz(number))
            {
                FizzCount++;
                return "fizz";
            }
            if (IsBuzz(number))
            {
                BuzzCount++;
                return "buzz";
            }

            NumberCount++;
            return number.ToString();
        }


        private bool IsFizz(int i)
        {
            return (i%3 == 0);
        }

        private bool IsBuzz(int i)
        {
            return (i%5 == 0);
        }

        private bool IsFizzBuzz(int i)
        {
            return (i%15 == 0);
        }
    }
}