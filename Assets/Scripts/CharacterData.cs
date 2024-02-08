using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Character : MonoBehaviour
{   
    public string characterName;
    public int strength;
    public int intellect;
    public int spirit; 

    public Character(Character character){
        characterName = character.name;
        strength = character.strength;
        intellect = character.intellect;
        spirit = character.spirit;
    }
}
