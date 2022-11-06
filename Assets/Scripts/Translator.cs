using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public string nameToTranslate;
    public string translated;

    public PossibleAlienPrpertys possibleAlienPrpertysScript;
    public AlienLanguages alienLanguagesScript;

    void Start()
    {
        for (int i = 0; i < possibleAlienPrpertysScript.homePlanet.Count; i++)
        {
            Tramslate(possibleAlienPrpertysScript.homePlanet[i], 1);
            alienLanguagesScript.homePlanetBhucander.Add(translated);
            translated = "";
        }
        
        for (int i = 0; i < possibleAlienPrpertysScript.homePlanet.Count; i++)
        {
            Tramslate(possibleAlienPrpertysScript.homePlanet[i], 1);
            alienLanguagesScript.homePlanetHuliaphan.Add(translated);
            translated = "";
        }

        for (int i = 0; i < possibleAlienPrpertysScript.homePlanet.Count; i++)
        {
            Tramslate(possibleAlienPrpertysScript.homePlanet[i], 1);
            alienLanguagesScript.homePlanetDrociamite.Add(translated);
            translated = "";
        }
    }

    void Tramslate(string word, int art)
    {
        //1 = Bhucander, 2 = Huliphan, 3 = Drociamite
        if(art == 1)
        {
            foreach (char c in word)
            {
                switch(c)
                {
                    case 'a':
                        translated += "0";
                    break;

                    case 'b':
                        translated += "1";
                    break;

                    case 'c':
                        translated += "2";
                    break;

                    case 'd':
                        translated += "3";
                    break;

                    case 'e':
                        translated += "4";
                    break;

                    case 'f':
                        translated += "5";
                    break;

                    case 'g':
                        translated += "6";
                    break;

                    case 'h':
                        translated += "7";
                    break;

                    case 'i':
                        translated += "8";
                    break;

                    case 'j':
                        translated += "9";
                    break;

                    case 'k':
                        translated += "E0";
                    break;

                    case 'l':
                        translated += "E1";
                    break;

                    case 'm':
                        translated += "E2";
                    break;

                    case 'n':
                        translated += "E3";
                    break;

                    case 'o':
                        translated += "E4";
                    break;

                    case 'p':
                        translated += "E5";
                    break;

                    case 'q':
                        translated += "E6";
                    break;

                    case 'r':
                        translated += "E7";
                    break;

                    case 's':
                        translated += "E8";
                    break;

                    case 't':
                        translated += "E9";
                    break;

                    case 'u':
                        translated += "T0";
                    break;

                    case 'v':
                        translated += "T1";
                    break;

                    case 'w':
                        translated += "T2";
                    break;

                    case 'x':
                        translated += "T3";
                    break;

                    case 'y':
                        translated += "T4";
                    break;

                    case 'z':
                        translated += "T5";
                    break;
                }
            }
        }
        else if(art == 2)
        {
            foreach (char c in word)
            {
                switch(c)
                {
                    case 'b':
                        translated += "a";
                    break;

                    case 'c':
                        translated += "b";
                    break;

                    case 'h':
                        translated += "c";
                    break;

                    case 'a':
                        translated += "d";
                    break;

                    case 'd':
                        translated += "e";
                    break;

                    case 'e':
                        translated += "f";
                    break;

                    case 'f':
                        translated += "g";
                    break;

                    case 'g':
                        translated += "h";
                    break;

                    case 'j':
                        translated += "i";
                    break;

                    case 'i':
                        translated += "j";
                    break;

                    case 'k':
                        translated += "k";
                    break;

                    case 'l':
                        translated += "l";
                    break;

                    case 'z':
                        translated += "m";
                    break;

                    case 'n':
                        translated += "n";
                    break;

                    case 'm':
                        translated += "o";
                    break;

                    case 'y':
                        translated += "p";
                    break;

                    case 'x':
                        translated += "q";
                    break;

                    case 'p':
                        translated += "r";
                    break;

                    case 's':
                        translated += "s";
                    break;

                    case 't':
                        translated += "t";
                    break;

                    case 'w':
                        translated += "u";
                    break;

                    case 'v':
                        translated += "v";
                    break;

                    case 'q':
                        translated += "w";
                    break;

                    case 'u':
                        translated += "x";
                    break;

                    case 'r':
                        translated += "y";
                    break;

                    case 'o':
                        translated += "z";
                    break;
                }
            }
        }
        else if(art == 3)
        {
            foreach (char c in word)
            {
                switch(c)
                {
                    case 'f':
                        translated += "0";
                    break;

                    case 'd':
                        translated += "1";
                    break;

                    case 'c':
                        translated += "2";
                    break;

                    case 'e':
                        translated += "3";
                    break;

                    case 'h':
                        translated += "4";
                    break;

                    case 'l':
                        translated += "5";
                    break;

                    case 'g':
                        translated += "6";
                    break;

                    case 'a':
                        translated += "7";
                    break;

                    case 'b':
                        translated += "8";
                    break;

                    case 'j':
                        translated += "9";
                    break;

                    case 'i':
                        translated += "E0";
                    break;

                    case 'm':
                        translated += "E1";
                    break;

                    case 'p':
                        translated += "E2";
                    break;

                    case 'k':
                        translated += "E3";
                    break;

                    case 'o':
                        translated += "E4";
                    break;

                    case 'q':
                        translated += "E5";
                    break;

                    case 't':
                        translated += "E6";
                    break;

                    case 'r':
                        translated += "E7";
                    break;

                    case 's':
                        translated += "E8";
                    break;

                    case 'w':
                        translated += "E9";
                    break;

                    case 'x':
                        translated += "T0";
                    break;

                    case 'u':
                        translated += "T1";
                    break;

                    case 'v':
                        translated += "T2";
                    break;

                    case 'n':
                        translated += "T3";
                    break;

                    case 'z':
                        translated += "T4";
                    break;

                    case 'y':
                        translated += "T5";
                    break;
                }
            }
        }
    }
}