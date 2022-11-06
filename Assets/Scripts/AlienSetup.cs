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

    [SerializeField] AlienManager alienManagerScript;

    [Header("References to text for alien")]
    public Image alienImage;
    public TMP_Text nameText;
    public TMP_Text occupationText;
    public TMP_Text homePlanetText;
    public TMP_Text speciesText;
    public TMP_Text ageText;

    void Start()
    {
        CreateAlien(spawnAmount);
        Debug.Log("Work!!!!");
    }

    public void CreateAlien(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if(CanPassRandomiser())
            {
                AlienPropertys x = ScriptableObject.CreateInstance<AlienPropertys>();

                x.picture = possibleAlienPrpertys.picture[Random.Range(0, possibleAlienPrpertys.picture.Count)];
                x.alienName = possibleAlienPrpertys.names[Random.Range(0, possibleAlienPrpertys.names.Count)];
                x.occupation = possibleAlienPrpertys.occupation[Random.Range(0, possibleAlienPrpertys.occupation.Count)];
                x.homePlanet = possibleAlienPrpertys.homePlanet[Random.Range(0, possibleAlienPrpertys.homePlanet.Count)];
                x.species = possibleAlienPrpertys.species[Random.Range(0, possibleAlienPrpertys.species.Count)];
                x.age = Random.Range(0, AgeStuff(RandomizeSpecies(), true));
                x.canPass = true;

                alienManagerScript.aliensSpawned.Add(x);

                alienImage.sprite = x.picture;
                occupationText.text = x.occupation;
                homePlanetText.text = x.homePlanet;
                speciesText.text = x.species;
                ageText.text = x.age.ToString();
            }
            else
            {
                AlienPropertys x = ScriptableObject.CreateInstance<AlienPropertys>();

                x.picture = possibleAlienPrpertys.picture[Random.Range(0, possibleAlienPrpertys.picture.Count)];
                x.alienName = possibleAlienPrpertys.names[Random.Range(0, possibleAlienPrpertys.names.Count)];
                x.occupation = possibleAlienPrpertys.occupation[Random.Range(0, possibleAlienPrpertys.occupation.Count)];
                x.homePlanet = possibleAlienPrpertys.homePlanet[Random.Range(0, possibleAlienPrpertys.homePlanet.Count)];
                x.species = possibleAlienPrpertys.species[Random.Range(0, possibleAlienPrpertys.species.Count)];
                x.age = Random.Range(0, AgeStuff(RandomizeSpecies(), true));
                x.canPass = true;

                alienManagerScript.aliensSpawned.Add(x);

                alienImage.sprite = x.picture;
                occupationText.text = x.occupation;
                homePlanetText.text = x.homePlanet;
                speciesText.text = x.species;
                ageText.text = x.age.ToString();
            }
        }
    }

    int AgeStuff(int speciesNumber, bool canPass)
    {
        if(canPass)
        {
            int x = Random.Range(0, 3);

            if(x == 1)
            {
                return Random.Range(18, possibleAlienPrpertys.ageLengthBhucander);
            }
            else if(x == 2)
            {
                return Random.Range(18, possibleAlienPrpertys.ageLengthHuliaphan);
            }
            else
            {
                return Random.Range(18, possibleAlienPrpertys.ageLengthDrociamite);
            }
        }
        else
        {
            int x = Random.Range(0, 3);

            if(x == 1)
            {
                return Random.Range(0, possibleAlienPrpertys.ageLengthBhucander + 150);
            }
            else if(x == 2)
            {
                return Random.Range(18, possibleAlienPrpertys.ageLengthHuliaphan + 100);
            }
            else
            {
                return Random.Range(18, possibleAlienPrpertys.ageLengthDrociamite + 150);
            }
        }
    }

    int RandomizeSpecies()
    {
        return Random.Range(0, 3);
    }

    bool CanPassRandomiser()
    {
        int x = Random.Range(0, 2);

        if(x == 1 || x == 2)
        {
            Debug.Log("true" + x);
            return true;
        }
        else
        {
            Debug.Log("false" + x);
            return false;
        }
    }
}