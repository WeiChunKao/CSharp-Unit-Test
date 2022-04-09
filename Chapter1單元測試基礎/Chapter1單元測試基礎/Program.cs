using System;

namespace Chapter1單元測試基礎
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleParserTests.TestReturnZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
