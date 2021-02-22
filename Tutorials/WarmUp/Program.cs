using System;

namespace WarmUp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PrintSockPairs();

            //PrintJumpingOnClouds();

            PrisonBreak.PerformPrisonBreak();
        }

        private static void PrintSockPairs()
        {
            int[] arSocks = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = SocksMerchant.GetSockPairs(9, arSocks);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static  void PrintJumpingOnClouds()
        {
            string str = "0 0 0 1 0 0";
            int[] c = Array.ConvertAll(str.Split(' '), cTemp => Convert.ToInt32(cTemp));
            var res = JumpingOnClouds.GetJumpingOnClouds(c);

            Console.WriteLine("Jumping On Clouds: " + res);
        }
    }
}
