using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
using UnityEngine.UI;
using TMPro;
*/

[CreateAssetMenu(fileName = "PossibleAlienPrpertys")]
public class AlienPropertys : ScriptableObject
{
    [Header("Pictures")]
    public Sprite picture;

    [Header("Name")]
    public string alienName;

    [Header("Occupation")]
    public string occupation;

    [Header("HomePlanet")]
    public string homePlanet;

    [Header("Species")]
    public string species;

    [Header("Age")]
    public string fullAge;

    [Header("Can Pass")]
    public bool canPass;
}
