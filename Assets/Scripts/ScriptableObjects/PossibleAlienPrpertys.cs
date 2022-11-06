using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PossibleAlienPrpertys")]
public class PossibleAlienPrpertys : ScriptableObject
{
    [Header("Picture")]
    public List<Sprite> picture;

    [Header("Names")]
    public List<string> names;

    [Header("Occupation")]
    public List<string> occupation;
    public List<string> canPassOccupation;
    public List<string> canNotPassOccupation;

    [Header("HomePlanet")]
    public List<string> homePlanet;
    public List<string> canPassPlanet;
    public List<string> canNotPlanet;

    [Header("Species")]
    public List<string> species;

    [Header("Age")]
    public int ageLengthBhucander; 
    public int ageLengthHuliaphan;
    public int ageLengthDrociamite;
}
