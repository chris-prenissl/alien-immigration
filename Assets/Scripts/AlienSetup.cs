using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using AlienImmigration;

public class AlienSetup : MonoBehaviour
{
    [Header("Spawn propertys")]
    public int spawnAmount = 1;

    [Header("References")]
    public PossibleAlienPrpertys possibleAlienPrpertys;
    //public AlienPropertys alienPrpertys;

    [SerializeField] AlienManager alienManagerScript;
    [SerializeField] Translator translatorScript;

    [Header("References to text for alien")]
    public Image alienImage;
    public TMP_Text nameText;
    public TMP_Text occupationText;
    public TMP_Text homePlanetText;
    public TMP_Text speciesText;
    public TMP_Text ageText;

    public void CreateAlien(int amount)
    {
        if(alienManagerScript.alienSpawned != null) { Destroy(alienManagerScript.alienSpawned); }

        for (int i = 0; i < amount; i++)
        {
            //0 = Bhucander, 1 = Huliphan, 2 = Drociamite
            int species = RandomizeSpecies();

            if(CanPassRandomiser())
            {
                AlienPropertys x = ScriptableObject.CreateInstance<AlienPropertys>();

                x.picture = possibleAlienPrpertys.picture[Random.Range(0, possibleAlienPrpertys.picture.Count)];
                x.alienName = possibleAlienPrpertys.names[Random.Range(0, possibleAlienPrpertys.names.Count)];

                x.occupation = possibleAlienPrpertys.canPassOccupation[Random.Range(0, possibleAlienPrpertys.canPassOccupation.Count)];
                x.homePlanet = possibleAlienPrpertys.canPassPlanet[Random.Range(0, possibleAlienPrpertys.canPassPlanet.Count)];

                x.species = possibleAlienPrpertys.species[Random.Range(0, possibleAlienPrpertys.species.Count)];

                x.fullAge = AgeStuff(species, true);
                x.canPass = true;

                alienManagerScript.alienSpawned = x;

                alienImage.sprite = x.picture;
                nameText.text = translatorScript.TranslateName(x.alienName, species + 1);
                occupationText.text = translatorScript.TranslateName(x.occupation, species + 1);
                //homePlanetText.text = translatorScript.TranslateName(x.homePlanet, species + 1);
                homePlanetText.text = x.homePlanet;
                speciesText.text = x.species;
                ageText.text = x.fullAge.ToString();
            }
            else
            {
                bool cantPassOccupation = CanPassRandomiser();
                bool cantPassPlanet = CanPassRandomiser();
                bool cantPassAge = CanPassRandomiser();

                AlienPropertys x = ScriptableObject.CreateInstance<AlienPropertys>();

                x.picture = possibleAlienPrpertys.picture[Random.Range(0, possibleAlienPrpertys.picture.Count)];
                x.alienName = possibleAlienPrpertys.names[Random.Range(0, possibleAlienPrpertys.names.Count)];
                x.species = possibleAlienPrpertys.species[Random.Range(0, possibleAlienPrpertys.species.Count)];

                if(cantPassOccupation)
                {
                    x.occupation = possibleAlienPrpertys.canNotPassOccupation[Random.Range(0, possibleAlienPrpertys.canNotPassOccupation.Count)];
                }
                else
                {
                    x.occupation = possibleAlienPrpertys.canPassOccupation[Random.Range(0, possibleAlienPrpertys.canPassOccupation.Count)];
                }
                
                if(cantPassPlanet)
                {
                    x.homePlanet = possibleAlienPrpertys.canNotPassPlanet[Random.Range(0, possibleAlienPrpertys.canNotPassPlanet.Count)];
                }
                else
                {
                    x.homePlanet = possibleAlienPrpertys.canPassPlanet[Random.Range(0, possibleAlienPrpertys.canPassPlanet.Count)];
                }

                if(cantPassAge)
                {
                    x.fullAge = AgeStuff(species, false);
                }
                else
                {
                    x.fullAge = AgeStuff(species, true);
                }

                if(cantPassOccupation || cantPassPlanet || cantPassAge)
                {
                    x.canPass = false;
                }
                else
                {
                    x.canPass = true;
                }

                alienManagerScript.alienSpawned = x;

                alienImage.sprite = x.picture;
                nameText.text = translatorScript.TranslateName(x.alienName, species + 1);
                occupationText.text = translatorScript.TranslateName(x.occupation, species + 1);
                //homePlanetText.text = translatorScript.TranslateName(x.homePlanet, species + );
                homePlanetText.text = x.homePlanet;
                speciesText.text = x.species;
                ageText.text = x.fullAge.ToString();
            }
        }
    }

    string AgeStuff(int speciesNumber, bool canPass)
    {
        int currantYear = 4022;
        if(canPass)
        {
            int x = Random.Range(0, 3);

            if(x == 1)
            {
                int age = Random.Range(18, possibleAlienPrpertys.ageLengthBhucander);
                int yearOfBirth = currantYear - (age + Random.Range(1, 50));
                return yearOfBirth.ToString() + " - " + age;
            }
            else if(x == 2)
            {
                int age = Random.Range(18, possibleAlienPrpertys.ageLengthHuliaphan);
                int yearOfBirth = currantYear - (age + Random.Range(1, 50));
                return yearOfBirth.ToString() + " - " + age;
            }
            else
            {
                int age = Random.Range(18, possibleAlienPrpertys.ageLengthDrociamite);
                int yearOfBirth = currantYear - (age + Random.Range(1, 50));
                return yearOfBirth.ToString() + " - " + age;
            }
        }
        else
        {
            int x = Random.Range(0, 3);

            if(x == 1)
            {
                int age = Random.Range(possibleAlienPrpertys.ageLengthBhucander, possibleAlienPrpertys.ageLengthBhucander + 80);
                int yearOfBirth = currantYear - age;
                return yearOfBirth.ToString() + " - " + age;
            }
            else if(x == 2)
            {
                int age = Random.Range(possibleAlienPrpertys.ageLengthHuliaphan, possibleAlienPrpertys.ageLengthHuliaphan + 80);
                int yearOfBirth = currantYear - age;
                return yearOfBirth.ToString() + " - " + age;
            }
            else
            {
                
                int age = Random.Range(possibleAlienPrpertys.ageLengthDrociamite, possibleAlienPrpertys.ageLengthDrociamite + 80);
                int yearOfBirth = currantYear - age;
                return yearOfBirth.ToString() + " - " + age;
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
            return true;
        }
        else
        {
            return false;
        }
    }
}