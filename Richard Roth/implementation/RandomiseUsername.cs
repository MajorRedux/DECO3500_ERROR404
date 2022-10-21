using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomiseUsername : MonoBehaviour
{
    // Initialise variables
    [SerializeField] TextMeshPro username;
    // Array of random user names for testing
    private string[] names = new string[] {"Dilogical", "Gardyloo", "Edaphic", "RedskyeQuaff", "Caritative", "Hydroxyzine", "Deadeye", "Whirligig", "Wulu5Rivel", "Festooned", "Ideopraxist", "Rendezvous", "Tonyroy2Hedera", "Snooker", "Lavaliere", "ThetrojNabob", "Barbate", "MrjoekAloof", "BeadWashi", "KloogGonzo", "JelidPogey", "Teim0Blob", "Velation", "Shabang", "Foursquare", "Aficionado", "Ochlocracy", "Katydid", "Gravey4Jumar", "ChorisHotbed", "Trifurcate", "Blabbermouth", "Protensive", "FrenetFurphy", "Passacaglia", "Manorexic", "Rittmaster", "Dillydally", "Nephelognosy", "Xxps3gamerxBlock", "Agynary", "Guru", "Spiraltan723", "Umpteenth", "Bruitbsoy1", "Biltong", "Whitster", "Hokum", "Hobnail", "Cloying", "Mirabilia", "Shemomedjamo", "Poulprus765", "Quibble", "Agapeistic", "Flabbergast", "Calescence", "Toothsome", "Pileated", "Typhoon", "Contranoak", "Loopy", "Kinnikinnick", "Thuggee", "Temporaneous", "Fartlek", "Epipolism", "Woozy", "Celsitude", "Haboob", "Benthic", "Geta", "Poodleper90", "Smithereens", "Outwith", "Rindfleis", "Suqloudy", "Disemvowel", "Koshertaunch", "Titter"};
    
    // Get a random name from the array
    public string GetRandomName()
    {
        return names[Random.Range(0, names.Length)];
    }

    // Assign the random name to the object username.text
    void Start()
    {
        username.text = GetRandomName();
    }
}
