using System.Text;

namespace _04.MosreCodeTransl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = ".-";
            string B = "-...";
            string C = "-.-.";
            string D = "-..";
            string E = ".";
            string F = "..-.";
            string G = "--.";
            string H = "....";
            string I = "..";
            string J = ".---";
            string K = "-.-";
            string L = ".-..";
            string M = "--";
            string N = "-.";
            string O = "---";
            string P = ".--.";
            string Q = "--.-";
            string R = ".-.";
            string S = "...";
            string T = "-";
            string U = "..-";
            string V = "...-";
            string W = ".--";
            string X = "-..-";
            string Y = "-.--";
            string Z = "--..";
            string space = "|";

            string[] codedText = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            StringBuilder englishText = new StringBuilder();

            foreach (var symbol in codedText)
            {
                if (symbol == A)
                {
                    englishText.Append('A');
                }
                else if (symbol == B)
                {
                    englishText.Append('B');
                }
                else if (symbol == C)
                {
                    englishText.Append('C');
                }
                else if (symbol == D)
                {
                    englishText.Append('D');
                }
                else if (symbol == E)
                {
                    englishText.Append('E');
                }
                else if (symbol == F)
                {
                    englishText.Append('F');
                }
                else if (symbol == G)
                {
                    englishText.Append('G');
                }
                else if (symbol == H)
                {
                    englishText.Append('H');
                }
                else if (symbol == I)
                {
                    englishText.Append('I');
                }
                else if (symbol == J)
                {
                    englishText.Append('J');
                }
                else if (symbol == K)
                {
                    englishText.Append('K');
                }
                else if (symbol == L)
                {
                    englishText.Append('L');
                }
                else if (symbol == M)
                {
                    englishText.Append('M');
                }
                else if (symbol == N)
                {
                    englishText.Append('N');
                }
                else if (symbol == O)
                {
                    englishText.Append('O');
                }
                else if (symbol == P)
                {
                    englishText.Append('P');
                }
                else if (symbol == Q)
                {
                    englishText.Append('Q');
                }
                else if (symbol == R)
                {
                    englishText.Append('R');
                }
                else if (symbol == S)
                {
                    englishText.Append('S');
                }
                else if (symbol == T)
                {
                    englishText.Append('T');
                }
                else if (symbol == U)
                {
                    englishText.Append('U');
                }
                else if (symbol == V)
                {
                    englishText.Append('V');
                }
                else if (symbol == W)
                {
                    englishText.Append('W');
                }
                else if (symbol == X)
                {
                    englishText.Append('X');
                }
                else if (symbol == Y)
                {
                    englishText.Append('Y');
                }
                else if (symbol == Z)
                {
                    englishText.Append('Z');
                }
                else if (symbol == space)
                {
                    englishText.Append(' ');
                }
            }
            Console.WriteLine(englishText.ToString());
         
        }
    }
}