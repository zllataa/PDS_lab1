using System;

class Program
{
    static void Main(string[] args)
    {
        string p = "11111000";
        string q = "10100110";

        // Виконання операцій для висловлювань
        bool conjunction = BitwiseConjunction(p, q);
        bool disjunction = BitwiseDisjunction(p, q);
        bool alternativeOr = BitwiseAlternativeOr(p, q);
        bool implication = BitwiseImplication(p, q);
        bool equivalence = BitwiseEquivalence(p, q);

        Console.WriteLine("Результати операцій для висловлювань:");
        Console.WriteLine("Кон'юнкція: " + conjunction);
        Console.WriteLine("Диз'юнкція: " + disjunction);
        Console.WriteLine("Альтернативне 'або': " + alternativeOr);
        Console.WriteLine("Імплікація: " + implication);
        Console.WriteLine("Еквівалентність: " + equivalence);

        string str1 = "11001011";
        string str2 = "10110101";

        // Виконання порозрядних операцій для рядків
        string resultOr = BitwiseStringOr(str1, str2);
        string resultAnd = BitwiseStringAnd(str1, str2);
        string resultXor = BitwiseStringXor(str1, str2);

        Console.WriteLine("\nРезультати порозрядних операцій для рядків:");
        Console.WriteLine("OR: " + resultOr);
        Console.WriteLine("AND: " + resultAnd);
        Console.WriteLine("XOR: " + resultXor);

        Console.ReadLine();
    }

    static bool BitwiseConjunction(string p, string q)
    {
        int pValue = Convert.ToInt32(p, 2);
        int qValue = Convert.ToInt32(q, 2);

        int result = pValue & qValue;
        return Convert.ToBoolean(result);
    }

    static bool BitwiseDisjunction(string p, string q)
    {
        int pValue = Convert.ToInt32(p, 2);
        int qValue = Convert.ToInt32(q, 2);

        int result = pValue | qValue;
        return Convert.ToBoolean(result);
    }

    static bool BitwiseAlternativeOr(string p, string q)
    {
        int pValue = Convert.ToInt32(p, 2);
        int qValue = Convert.ToInt32(q, 2);

        int result = pValue ^ qValue;
        return Convert.ToBoolean(result);
    }

    static bool BitwiseImplication(string p, string q)
    {
        int pValue = Convert.ToInt32(p, 2);
        int qValue = Convert.ToInt32(q, 2);

        int result = (~pValue) | qValue;
        return Convert.ToBoolean(result);
    }

    static bool BitwiseEquivalence(string p, string q)
    {
        int pValue = Convert.ToInt32(p, 2);
        int qValue = Convert.ToInt32(q, 2);

        int result = pValue ^ qValue ^ 255;
        return Convert.ToBoolean(result);
    }

    static string BitwiseStringOr(string str1, string str2)
    {
        int n = str1.Length;
        int[] resultArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int digit1 = Convert.ToInt32(str1[i].ToString());
            int digit2 = Convert.ToInt32(str2[i].ToString());

            // Perform bitwise OR operation
            resultArr[i] = digit1 | digit2;
        }

        // Convert the result array back to string
        string result = string.Join("", resultArr);
        return result;
    }


    static string BitwiseStringAnd(string str1, string str2)
    {
        int n = str1.Length;
        string result = "";

        for (int i = 0; i < n; i++)
        {
            int digit1 = Convert.ToInt32(str1[i].ToString());
            int digit2 = Convert.ToInt32(str2[i].ToString());

            // Perform bitwise AND operation
            result += (digit1 & digit2).ToString();
        }

        return result;
    }

    static string BitwiseStringXor(string str1, string str2)
    {
        int n = str1.Length;
        string result = "";

        for (int i = 0; i < n; i++)
        {
            int digit1 = Convert.ToInt32(str1[i].ToString());
            int digit2 = Convert.ToInt32(str2[i].ToString());

            // Perform bitwise XOR operation
            result += (digit1 ^ digit2).ToString();
        }

        return result;
    }
}

