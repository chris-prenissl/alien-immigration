using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AlienLanguages")]
public class AlienLanguages : ScriptableObject
{
    [Header("Names")]
    public List<string> namesBhucander;
    public List<string> namesHuliaphan;
    public List<string> namesDrociamite;

    [Header("Occupation")]
    public List<string> homePlanetBhucander;
    public List<string> homePlanetHuliaphan;
    public List<string> homePlanetDrociamite;

    [Header("Species")]
    public List<string> speciesBhucander;
    public List<string> speciesHuliaphan;
    public List<string> speciesDrociamite;

    /*
    int GetSignForLetter(string letter)
    {
        switch(letter)
        {
            case "a":
                return 
            break;
        }
        return 1;
    }
    */
}