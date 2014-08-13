using System;

namespace PaizaC008
{
    internal class Program
    {
        private static void Main()
        {
            var tags = Console.ReadLine().Split(' ');
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var leftTag = tags[0];
            var rightTag = tags[1];
            var leftIndex = input.IndexOf(leftTag, StringComparison.InvariantCulture);
            while (leftIndex >= 0)
            {
                var startIndex = leftIndex + leftTag.Length;
                var rightIndex = input.IndexOf(rightTag, startIndex, StringComparison.InvariantCulture);
                if (rightIndex < 0)
                {
                    break;
                }

                if (rightIndex == startIndex)
                {
                    Console.WriteLine("<blank>");
                }
                else
                {
                    var text = input.Substring(startIndex, rightIndex - startIndex);
                    Console.WriteLine(text);
                }

                var nextStartIndex = rightIndex + rightTag.Length;
                if (nextStartIndex >= input.Length)
                {
                    break;
                }
                leftIndex = input.IndexOf(leftTag, nextStartIndex, StringComparison.InvariantCulture);
            }
        }
    }
}