using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PossibleAlienPrpertys")]
public class PossibleAlienPrpertys : ScriptableObject
{
    public List<Sprite> picture;

    public List<string> occupation;
    public List<string> homePlanet;
    public List<string> species;
    public int age;
}
