using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public static string FraseAConvertir { get; set; }
        public static int IntAConvertir { get; set; }

        static void Main(string[] args)
        {
            FraseAConvertir = "--001-20 pu r e de rem3- ola cha 0 1-";

            QuitarCaracteres(FraseAConvertir , ' ');
            Console.WriteLine(FraseAConvertir);

            QuitarCaracteres(FraseAConvertir);
            Console.WriteLine(FraseAConvertir);

            QuitarCerosYMenos(FraseAConvertir);
            Console.WriteLine(FraseAConvertir);

            ConvertirEnInt();
            Console.WriteLine(IntAConvertir);
            Console.ReadLine();
        }
        public static string QuitarCaracteres(string s, char caracteraquitar)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == caracteraquitar)
                {
                    s = s.Remove(i, 1);
                }
            }

            FraseAConvertir = s;

            return FraseAConvertir;
        }

        public static string QuitarCaracteres(string s)
        {
            s = FraseAConvertir;
            StringBuilder resultado = new StringBuilder();

            // Recorremos la cadena
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]) == false && Char.IsSymbol(s[i]) == false)
                {
                    resultado.Append(s[i]);
                }
            }
            
            FraseAConvertir = resultado.ToString();

            return FraseAConvertir;
        }

        public static string QuitarCerosYMenos(string s)
        {
            s = FraseAConvertir;
            StringBuilder resultado = new StringBuilder();

            bool SeEncontroNumero = false;
            bool SeEncontroMenos = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0' && !SeEncontroNumero)
                {
                    continue;
                }
                if (s[i] == '-' && !SeEncontroMenos)
                {
                    resultado.Append(s[i]);
                    SeEncontroMenos = true;
                    continue;
                }
                if (Char.IsDigit(s[i]) == true)
                {
                    resultado.Append(s[i]);
                    SeEncontroNumero = true;
                }
            }

            FraseAConvertir = resultado.ToString();

            return FraseAConvertir;
        }



        public static int ConvertirEnInt()
        {
            IntAConvertir = int.Parse(FraseAConvertir);


            return IntAConvertir;
        }
    }
}



/*
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public static string FraseAConvertir { get; set; }
        public static int IntAConvertir { get; set; }

        static void Main(string[] args)
        {
            FraseAConvertir = "-00120 pu r e de rem3 ola cha 0 1";

            QuitarCaracteres(FraseAConvertir, ' ');
            Console.WriteLine(FraseAConvertir);

            QuitarCaracteres(FraseAConvertir);
            Console.WriteLine(FraseAConvertir);

            QuitarCeros(FraseAConvertir);
            Console.WriteLine(FraseAConvertir);

            QuitarMenosDeMas(FraseAConvertir);
            Console.WriteLine(FraseAConvertir);

            ConvertirEnInt();
            Console.WriteLine(IntAConvertir);
            Console.ReadLine();
        }
        public static string QuitarCaracteres(string s, char caracteraquitar)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == caracteraquitar)
                {
                    s = s.Remove(i, 1);
                }
            }

            FraseAConvertir = s;

            return FraseAConvertir;
        }

        public static string QuitarCaracteres(string s)
        {
            StringBuilder resultado = new StringBuilder();

            // Recorremos la cadena
            for (int i = 0; i < s.Length; i++)
            {
                // Si el carácter no es letra ni símbolo, lo agregamos al resultado
                if (Char.IsLetter(s[i]) == false && Char.IsSymbol(s[i]) == false)
                {
                    resultado.Append(s[i]);
                }
            }

            FraseAConvertir = resultado.ToString();

            return FraseAConvertir;
        }

        public static string QuitarCeros(string s)
        {
            StringBuilder resultado = new StringBuilder();

            bool SeEncontroNumero = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0' && !SeEncontroNumero)
                {
                    continue;
                }

                if (Char.IsDigit(s[i]) == true)
                {
                    resultado.Append(s[i]);
                    SeEncontroNumero = true;
                }
            }

            FraseAConvertir = resultado.ToString();

            return FraseAConvertir;
        }

        public static string QuitarMenosDeMas(string s)
        {
            StringBuilder resultado = new StringBuilder();
            bool SeEncontroMenos = false;
            bool SeEncontroNumero = false;

            for (int i = s.Length; i < 0; i--)
            {
                if (Char.IsDigit(s[i]) == true)
                {
                    resultado.Append(s[i]);
                    SeEncontroNumero = true;
                    continue;
                }
                if (s[i] == '-' && !SeEncontroMenos && SeEncontroNumero)
                {
                    resultado.Append(s[i]);
                    SeEncontroMenos = true;
                }
            }

            FraseAConvertir = resultado.ToString();

            return FraseAConvertir;
        }


        public static int ConvertirEnInt()
        {
            IntAConvertir = int.Parse(FraseAConvertir);


            return IntAConvertir;
        }
    }
}

*/