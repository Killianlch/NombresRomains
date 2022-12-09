using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NombresRomains
{
    public static class ConvertisseurNombresRomains
    {


        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                <= 3 => new string('I', nombreArabe),
                4 => "IV",
                <= 8 => "V" + Convertir(nombreArabe - 5),
                9 => "IX",
                10 => "X",
                <= 13 => "X" + new string('I', nombreArabe - 10),
                14 => "XIV",
                <= 18 => "XV" + Convertir(nombreArabe - 15),
                19 => "XIX",
                <= 23 => "XX" + new string('I', nombreArabe - 20),
                24 => "XXIV",
                <= 28 => "XXV" + Convertir(nombreArabe - 25),
                29 => "XXIX",
            };


    };
}