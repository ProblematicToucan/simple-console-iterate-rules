using System.Text;

namespace formulatrix_submission_01
{
    class Service
    {
        private static readonly Dictionary<int, string> rules = new(){
            {3, "foo"},
            {4, "baz"},
            {5, "bar"},
            {7, "jazz"},
            {9, "huzz"},
        };

        public static void Calculate(int x)
        {
            var result = new StringBuilder();
            for (int i = 1; i <= x; i++)
            {
                var output = new StringBuilder();

                // Check divisibility against the keys in the dictionary
                foreach (var rule in rules)
                {
                    if (i % rule.Key == 0)
                    {
                        output.Append(rule.Value);
                    }
                }

                // If output is empty, append the number itself
                if (output.Length == 0)
                {
                    output.Append(i);
                }

                result.Append(output);

                if (i < x) result.Append(", ");
            }

            Console.WriteLine(result.ToString());
        }

        public static void AddRule(int input, string output)
        {
            rules.Add(input, output);
            Console.WriteLine("Rule entry was added.");
        }

        public static void RemoveRule(int input)
        {
            if (!rules.ContainsKey(input)) Console.WriteLine("Rule entry was removed.");
            rules.Remove(input);
        }
    }
}