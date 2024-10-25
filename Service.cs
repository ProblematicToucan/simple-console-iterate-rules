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

                if (divisibleBy3)
                    result.Append("foo");

                if (divisibleBy5)
                    result.Append("bar");

                if (!divisibleBy3 && !divisibleBy5)
                    result.Append(i);

                if (i < x) result.Append(", ");
            }

            Console.WriteLine(result.ToString());
        }
    }
}