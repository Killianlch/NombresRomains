﻿namespace NombresRomains
{
    public static class ConvertisseurNombresRomains
    {


        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                <= 3 => new string('I', nombreArabe),
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 =>"VIII",
            };


    };
}