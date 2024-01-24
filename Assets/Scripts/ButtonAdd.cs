using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAdd : MonoBehaviour
{
    public float cardWidth = 108;
    public Transform GameArea;
    public GameObject Button;

    void Create(){
        for(int i = 0; i < 2; i++){
            print("Create button");
            GameObject button = Instantiate(Button);
            button.name = "" + i;
            button.transform.SetParent(GameArea, false);
            button.transform.position += new Vector3(cardWidth * i,0,0);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Create();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
