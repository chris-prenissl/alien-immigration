using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlienSetup : MonoBehaviour
{
    [Header("Spawn propertys")]
    public int spawnAmount = 1;

    [Header("References")]
    public PossibleAlienPrpertys possibleAlienPrpertys;
    //public AlienPropertys alienPrpertys;

    public Transform alienFolder;

    [SerializeField] AlienManager alienManagerScript;

    [Header("References to text for alien")]
    public Image alienImage;
    public TMP_Text occupationText;
    public TMP_Text homePlanetText;
    public TMP_Text speciesText;
    public TMP_Text ageText;

    void Start()
    {
        CreateAlien(spawnAmount);
    }

    public void CreateAlien(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            AlienPropertys x = ScriptableObject.CreateInstance<AlienPropertys>();

            x.picture = possibleAlienPrpertys.picture[Random.Range(0, possibleAlienPrpertys.picture.Count)];
            x.occupation = possibleAlienPrpertys.occupation[Random.Range(0, possibleAlienPrpertys.occupation.Count)];
            x.homePlanet = possibleAlienPrpertys.homePlanet[Random.Range(0, possibleAlienPrpertys.homePlanet.Count)];
            x.species = possibleAlienPrpertys.species[Random.Range(0, possibleAlienPrpertys.species.Count)];
            x.age = Random.Range(0, 99);

            alienManagerScript.aliensSpawned.Add(x);

            alienImage.sprite = x.picture;
            occupationText.text = x.occupation;
            homePlanetText.text = x.homePlanet;
            speciesText.text = x.species;
            ageText.text = x.age.ToString();
        }

        /*
        for (int i = 0; i < amount; i++)
        {
            GameObject x = Instantiate(alienPrpertys);
            x.transform.SetParent(alienFolder);

            x.GetComponent<AlienPropertys>().picture = possibleAlienPrpertys.picture[Random.Range(0, possibleAlienPrpertys.picture.Count)];
            x.GetComponent<AlienPropertys>().occupation = possibleAlienPrpertys.occupation[Random.Range(0, possibleAlienPrpertys.occupation.Count)];
            x.GetComponent<AlienPropertys>().homeplanet = possibleAlienPrpertys.homeplanet[Random.Range(0, possibleAlienPrpertys.homeplanet.Count)];
            x.GetComponent<AlienPropertys>().species = possibleAlienPrpertys.species[Random.Range(0, possibleAlienPrpertys.species.Count)];
            x.GetComponent<AlienPropertys>().age = Random.Range(0, 99);

            x.GetComponent<AlienPropertys>().Setup();


            alienManagerScript.aliensSpawned.Add(x);
        }
        */
    }
}
