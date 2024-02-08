using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public string characterclass;
    public int strength;
    public int intellect;
    public int spirit;

    public void UpdateName(InputField inputField)
    {
        name = inputField.text;
    }

    public void UpdateStrength(InputField inputField)
    {
        strength = int.Parse(inputField.text);
    }

    public void Updateintellect(InputField inputField)
    {
        intellect = int.Parse(inputField.text);
    }

    public void Updatespirit(InputField inputField)
    {
        spirit = int.Parse(inputField.text);
    }


}
