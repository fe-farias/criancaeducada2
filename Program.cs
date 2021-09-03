using System;

namespace criancaeducada2
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavracensurada = "#@$%*!&";
            string frasedigitada, frasecensurada;
            Console.WriteLine("Digite uma frase: ");
            frasedigitada = Console.ReadLine();

            frasecensurada = frasedigitada
                .Replace("chato",palavracensurada)
                .Replace("chata",palavracensurada)
                .Replace("bobo",palavracensurada)
                .Replace("boba",palavracensurada)
                .Replace("feio",palavracensurada)
                .Replace("feia",palavracensurada)
                .Replace("boboca",palavracensurada)
                .Replace("bocó",palavracensurada)
                .Replace("tonta",palavracensurada)
                .Replace("tonto",palavracensurada)
                .Replace("palerma",palavracensurada)
                .Replace("paspalho",palavracensurada)
                .Replace("paspalha",palavracensurada)
                .Replace("tantã",palavracensurada)
                .Replace("burro",palavracensurada)
                .Replace("burra",palavracensurada)
                .Replace("besta",palavracensurada)
                .Replace("CHATO",palavracensurada)
                .Replace("CHATA",palavracensurada)
                .Replace("BOBO",palavracensurada)
                .Replace("BOBA",palavracensurada)
                .Replace("FEIO",palavracensurada)
                .Replace("FEIA",palavracensurada)
                .Replace("BOBOCA",palavracensurada)
                .Replace("BOCÓ",palavracensurada)
                .Replace("TONTA",palavracensurada)
                .Replace("TONTO",palavracensurada)
                .Replace("PALERMA",palavracensurada)
                .Replace("PASPALHO",palavracensurada)
                .Replace("PASPALHA",palavracensurada)
                .Replace("TANTÃ",palavracensurada)
                .Replace("BURRO",palavracensurada)
                .Replace("BURRA",palavracensurada)
                .Replace("BESTA",palavracensurada);


            Console.WriteLine(frasecensurada);


        }
    }
}
