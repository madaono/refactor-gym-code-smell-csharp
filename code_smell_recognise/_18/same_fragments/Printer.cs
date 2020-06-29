using System;
using System.Text;

namespace code_smell_recognise._18.same_fragments
{
    public class Printer
    {
        private readonly StringBuilder stringBuilder;

        public Printer(StringBuilder stringBuilder) {
            this.stringBuilder = stringBuilder;
        }

        public void PrintString(string str) {
            stringBuilder.Append("--------------- START --------------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(str);
            stringBuilder.Append("\n");
            stringBuilder.Append("--------------- END --------------------");
        }

        public void PrintTwoStrings(string first, string second) {
            var str = first + second;
            stringBuilder.Append("--------------- START --------------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(str);
            stringBuilder.Append("\n");
            stringBuilder.Append("--------------- END --------------------");
        }

        public void PrintStringAndInt(string str, int number) {
            var combinedString = str + ": " + number;
            stringBuilder.Append("--------------- START --------------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(combinedString);
            stringBuilder.Append("\n");
            stringBuilder.Append("--------------- END --------------------");
        }
    }
}