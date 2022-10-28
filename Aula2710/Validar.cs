using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2710
{
    public class Validar
    {
        string Frase= "Halloween is here";
        int ContadorVol = 0;
        int contadorMai = 0;
        int contadorMin = 0;
        int contadorPal = 0;
        

        public void QuantidadeCaracteres()
        {
         Console.WriteLine($"A quantidade de caracteres é: {Frase.Length}");
        }

        public void Maiusculos()
        {
            for (int i = 0; i < Frase.Length; i++)
            {
                    if (Char.IsUpper(Frase[i]))
                    {
                        contadorMai++;
          
                    }
           
            } 
            Console.WriteLine($"A quantidade de letras maiusculas é: {contadorMai}");
        }

        public void Minusculos()
        {
            for (int i = 0; i < Frase.Length; i++)
            {
                if (Char.IsLower(Frase[i]))
                {
                    contadorMin++;
                }
            }
            Console.WriteLine($"A quantidade de letras minusculas é: {contadorMin}");
        }
        public void Vogais()
        {
            for (int i = 0; i < Frase.Length; i++)
            {
                
                if (Char.Contains('a') || Frase.Contains('e') || Frase.Contains('i') || Frase.Contains('o') || Frase.Contains('u'))
                {
                    ContadorVol++;
                }
            }
            Console.WriteLine($"A quantidade de vogais é: {ContadorVol}");
        }
        public void Consoantes()
        {

        }
        public void QuantidadePalavras()
        {
            for (int i = 0; i < Frase.Length; i++)
            {
                if (Char.IsWhiteSpace(Frase[i]))
                {
                    contadorPal++;
                }
            }
            Console.WriteLine($"A quantidade de palavras é: {contadorPal + 1}");
        }
    }
}


