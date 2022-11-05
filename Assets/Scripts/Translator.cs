using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public string nameToTranslate;
    public string translated;

    void Start()
    {
        foreach (char c in nameToTranslate)
        {
            Debug.Log(c);

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
}
