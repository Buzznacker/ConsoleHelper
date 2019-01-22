using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    public class ConHelper
    {
        public static string DemanderValeurString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static char DemanderValeurChar(string message)
        {
            string sReponse = "";
            char cReponse = ' ';
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un char!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!char.TryParse(sReponse, out cReponse));
            return cReponse;
        }

        public static byte DemanderValeurByte(string message)
        {
            string sReponse = "";
            byte byReponse = 0;
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un byte!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!byte.TryParse(sReponse, out byReponse));
            return byReponse;
        }

        public static int DemanderValeurInt(string message)
        {
            string sReponse = "";
            int iReponse = 0;
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un int!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!int.TryParse(sReponse, out iReponse));
            return iReponse;
        }

        public static float DemanderValeurFloat(string message)
        {
            string sReponse = "";
            float fReponse = 0;
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un float!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!float.TryParse(sReponse, out fReponse));
            return fReponse;
        }

        public static double DemanderValeurDouble(string message)
        {
            string sReponse = "";
            double dReponse = 0;
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un double!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!double.TryParse(sReponse, out dReponse));
            return dReponse;
        }

        public static long DemanderValeurLong(string message)
        {
            string sReponse = "";
            long lReponse = 0;
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un long!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!long.TryParse(sReponse, out lReponse));
            return lReponse;
        }

        public static decimal DemanderValeurDecimal(string message)
        {
            string sReponse = "";
            decimal deReponse = 0;
            bool bFirstTry = true;
            do
            {
                if (!bFirstTry)
                    Console.WriteLine("Assurez-vous de rentrer un decimal!");
                Console.Write(message);
                sReponse = Console.ReadLine();
                bFirstTry = false;
            } while (!decimal.TryParse(sReponse, out deReponse));
            return deReponse;
        }

        public static void EndConsole()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
