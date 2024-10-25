using System.Text;

namespace formulatrix_submission_01
{
    class Service
    {
        public static void Calculate(int x)
        {
            var result = new StringBuilder();
            for (int i = 1; i <= x; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;
                bool divisibleBy7 = i % 7 == 0;

                bool isNotDivisible = !divisibleBy3 && !divisibleBy5 && !divisibleBy7;

                if (divisibleBy3)
                    result.Append("foo");
                if (divisibleBy5)
                    result.Append("bar");
                if (divisibleBy7)
                    result.Append("jazz");
                if (isNotDivisible)
                    result.Append(i);

                if (i < x) result.Append(", ");
            }

            Console.WriteLine(result.ToString());
        }
    }
}