using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public string TranslateName(string word, int language)
    {
        string toReturn = "";

        if(language == 1)
        {
            foreach (char c in word)
            {
                switch(c)
                {
                    case 'a':
                        toReturn += "a";
                    break;

                    case 'b':
                        toReturn += "b";
                    break;

                    case 'c':
                        toReturn += "c";
                    break;

                    case 'd':
                        toReturn += "d";
                    break;

                    case 'e':
                        toReturn += "e";
                    break;

                    case 'f':
                        toReturn += "f";
                    break;

                    case 'g':
                        toReturn += "g";
                    break;

                    case 'h':
                        toReturn += "h";
                    break;

                    case 'i':
                        toReturn += "i";
                    break;

                    case 'j':
                        toReturn += "j";
                    break;

                    case 'k':
                        toReturn += "k";
                    break;

                    case 'l':
                        toReturn += "l";
                    break;

                    case 'm':
                        toReturn += ",";
                    break;

                    case 'n':
                        toReturn += "m";
                    break;

                    case 'o':
                        toReturn += "o";
                    break;

                    case 'p':
                        toReturn += "p";
                    break;

                    case 'q':
                        toReturn += "q";
                    break;

                    case 'r':
                        toReturn += "r";
                    break;

                    case 's':
                        toReturn += "s";
                    break;

                    case 't':
                        toReturn += "t";
                    break;

                    case 'u':
                        toReturn += "u";
                    break;

                    case 'v':
                        toReturn += "v";
                    break;

                    case 'w':
                        toReturn += "w";
                    break;

                    case 'x':
                        toReturn += "x";
                    break;

                    case 'y':
                        toReturn += "y";
                    break;

                    case 'z':
                        toReturn += "z";
                    break;

                }
            }
        }
        else if(language == 2)
        {
            foreach (char c in word)
            {
                switch(c)
                {
                    case 'b':
                        toReturn += "a";
                    break;

                    case 'c':
                        toReturn += "b";
                    break;

                    case 'h':
                        toReturn += "c";
                    break;

                    case 'a':
                        toReturn += "d";
                    break;

                    case 'd':
                        toReturn += "e";
                    break;

                    case 'e':
                        toReturn += "f";
                    break;

                    case 'f':
                        toReturn += "g";
                    break;

                    case 'g':
                        toReturn += "h";
                    break;

                    case 'j':
                        toReturn += "i";
                    break;

                    case 'i':
                        toReturn += "j";
                    break;

                    case 'k':
                        toReturn += "k";
                    break;

                    case 'l':
                        toReturn += "l";
                    break;

                    case 'z':
                        toReturn += "m";
                    break;

                    case 'n':
                        toReturn += "n";
                    break;

                    case 'm':
                        toReturn += "o";
                    break;

                    case 'y':
                        toReturn += "p";
                    break;

                    case 'x':
                        toReturn += "q";
                    break;

                    case 'p':
                        toReturn += "r";
                    break;

                    case 's':
                        toReturn += "s";
                    break;

                    case 't':
                        toReturn += "t";
                    break;

                    case 'w':
                        toReturn += "u";
                    break;

                    case 'v':
                        toReturn += "v";
                    break;

                    case 'q':
                        toReturn += "w";
                    break;

                    case 'u':
                        toReturn += "x";
                    break;

                    case 'r':
                        toReturn += "y";
                    break;

                    case 'o':
                        toReturn += "z";
                    break;
                }
            }
        }
        else if(language == 3)
        {
            foreach (char c in word)
            {
                switch(c)
                {
                    case 'f':
                        toReturn += "a";
                    break;

                    case 'd':
                        toReturn += "b";
                    break;

                    case 'c':
                        toReturn += "b";
                    break;

                    case 'e':
                        toReturn += "d";
                    break;

                    case 'h':
                        toReturn += "e";
                    break;

                    case 'l':
                        toReturn += "f";
                    break;

                    case 'g':
                        toReturn += "g";
                    break;

                    case 'a':
                        toReturn += "h";
                    break;

                    case 'b':
                        toReturn += "i";
                    break;

                    case 'j':
                        toReturn += "j";
                    break;

                    case 'i':
                        toReturn += "k";
                    break;

                    case 'm':
                        toReturn += "l";
                    break;

                    case 'p':
                        toReturn += "m";
                    break;

                    case 'k':
                        toReturn += "n";
                    break;

                    case 'o':
                        toReturn += "o";
                    break;

                    case 'q':
                        toReturn += "p";
                    break;

                    case 't':
                        toReturn += "q";
                    break;

                    case 'r':
                        toReturn += "r";
                    break;

                    case 's':
                        toReturn += "s";
                    break;

                    case 'w':
                        toReturn += "t";
                    break;

                    case 'x':
                        toReturn += "u";
                    break;

                    case 'u':
                        toReturn += "v";
                    break;

                    case 'v':
                        toReturn += "w";
                    break;

                    case 'n':
                        toReturn += "x";
                    break;

                    case 'z':
                        toReturn += "y";
                    break;

                    case 'y':
                        toReturn += "z";
                    break;
                }
            }
        }

        return toReturn;
    }

    /*
    public void Test(string word)
    {
        foreach (char c in word)
        {
            switch(c)
            {
                case 'b':
                    toReturn += "a";
                break;

                case 'c':
                    toReturn += "b";
                break;

                case 'h':
                    toReturn += "c";
                break;

                case 'a':
                    toReturn += "d";
                break;

                case 'd':
                    toReturn += "e";
                break;

                case 'e':
                    toReturn += "f";
                break;

                case 'f':
                    toReturn += "g";
                break;

                case 'g':
                    toReturn += "h";
                break;

                case 'j':
                    toReturn += "i";
                break;

                case 'i':
                    toReturn += "j";
                break;

                case 'k':
                    toReturn += "k";
                break;

                case 'l':
                    toReturn += "l";
                break;

                case 'z':
                    toReturn += "m";
                break;

                case 'n':
                    toReturn += "n";
                break;

                case 'm':
                    toReturn += "o";
                break;

                case 'y':
                    toReturn += "p";
                break;

                case 'x':
                    toReturn += "q";
                break;

                case 'p':
                    toReturn += "r";
                break;

                case 's':
                    toReturn += "s";
                break;

                case 't':
                    toReturn += "t";
                break;

                case 'w':
                    toReturn += "u";
                break;

                case 'v':
                    toReturn += "v";
                break;

                case 'q':
                    toReturn += "w";
                break;

                case 'u':
                    toReturn += "x";
                break;

                case 'r':
                    toReturn += "y";
                break;

                case 'o':
                    toReturn += "z";
                break;
            }
        }
    }
    */
}