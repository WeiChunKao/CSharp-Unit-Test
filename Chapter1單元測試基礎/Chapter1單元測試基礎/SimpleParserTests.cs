using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1單元測試基礎
{
    public class TestUtil
    {
        public static void ShowProblem(string test, string message)
        {
            Console.WriteLine($"{test}，{message}");
        }
    }
    class SimpleParserTests
    {
        public static void TestReturnZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtil.ShowProblem(testName, @"***SimpleParserTests.TestReturnZeroWhenEmptyString:
                    -----
                    Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
