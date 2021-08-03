using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace IfElseIfElse
{

    public class StringCalculator
    {
        private readonly ICalculator _calculator;

        public StringCalculator(ICalculator calculator)
        {
            this._calculator = calculator;
        }

        public int Calculate(string operation)
        {
            if (string.IsNullOrEmpty(operation)) return 0;

            string[] split = ExplodeOperations(operation);

            int initial = int.Parse(split[0]);
            if (split.Length == 1) return initial;

            IEnumerable<(char Operator, int Value)> operations = this.ListOperations(split.Skip(1));

            return operations.Aggregate(initial,
                (acc, current) => this._calculator.Calculate(current.Operator, acc, current.Value));
        }

        private IEnumerable<(char Operator, int Value)> ListOperations(IEnumerable<string> parts)
        {
            var groups = parts.Select((item, index) => new { Item = item, Index = index })
                .GroupBy(x => x.Index % 2 == 0).ToDictionary(g => g.Key, g => g);
            IEnumerable<char> operators = groups[true].Select(op => char.Parse(op.Item));
            IEnumerable<int> numbers = groups[false].Select(n => int.Parse(n.Item));

            return operators.Zip(numbers);
        }

        private static string[] ExplodeOperations(string operation)
        {
            return Regex.Split(operation, @"(\d+)")
                .Where(s => !string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s)).ToArray();
        }
    }

}
