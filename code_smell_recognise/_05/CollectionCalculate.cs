using System.Collections.Generic;

namespace code_smell_recognise._05
{
    public class CollectionCalculate
    {
        private int[] input;

        public int[] FilterEvenNumber() {
            var result = new List<int>();
            for (var i = 0; i < input.Length; i++) {
                if (input[i] % 2 == 0) {
                    result.Add(input[i]);
                }
            }

            return result.ToArray();
        }
    }
}