using System;
using System.Text;

namespace code_smell_recognise._18.similar_fragments
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
            stringBuilder.Append("--------------- START --------------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(first + second);
            stringBuilder.Append("\n");
            stringBuilder.Append("--------------- END --------------------");
        }

        public void PrintStringAndInt(string str, int number) {
            stringBuilder.Append("--------------- START --------------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(str + ": " + number);
            stringBuilder.Append("\n");
            stringBuilder.Append("--------------- END --------------------");
        }
    }
}