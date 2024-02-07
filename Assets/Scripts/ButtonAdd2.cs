using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAdd2 : MonoBehaviour
{
    [SerializeField]
    private Transform SpelPlan;

    [SerializeField]
    private GameObject btn;

    void Awake(){
        for (int i = 0; i < 19; i++){
            GameObject button = Instantiate(btn);
            button.name = ""  + i;
            button.transform.SetParent(SpelPlan, false);
        }
    }
}
