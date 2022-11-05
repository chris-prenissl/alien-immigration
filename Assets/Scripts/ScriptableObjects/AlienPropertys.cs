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

    [Header("Occupation")]
    public string occupation;

    [Header("HomePlanet")]
    public string homePlanet;

    [Header("Species")]
    public string species;

    [Header("Age")]
    public int age;
    public string monthOfBirth;
    public int yearOfBirth;

    [Header("Can Pass")]
    private bool canPass;
    public bool CanPass
    {
        get { return canPass; }
        set { canPass = value; }
    }
    

    /*
    [SerializeField] Image alienImage;
    [SerializeField] TMP_Text occupationText;
    [SerializeField] TMP_Text homePlanetText;
    [SerializeField] TMP_Text speciesText;
    [SerializeField] TMP_Text ageText;

    public void Setup()
    {
        alienImage.sprite = picture;
        occupationText.text = occupation;
        homePlanetText.text = homeplanet;
        speciesText.text = species;
        ageText.text = age.ToString();
    }
    */
}
