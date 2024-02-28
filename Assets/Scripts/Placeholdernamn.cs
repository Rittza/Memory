using UnityEngine;

//Känn er fria att flytta denna kod till vart ni vill ha den, enda anledningen att den är i en seperat script är för enkelhets skull 
//(var dock försiktig så att det inte finns fler än en instans av detta, det kommer mest troligen skapa stora problem)
public class Placeholdernamn : MonoBehaviour
{
    string memory = null;
    bool multiplayer = true;
    int playerturn = 0;

    void Start()
    {
        //multiplayer = //avkommentera och lägg till någon extern parameter för att kontrollera detta här
    }

    //Länka alla memory-kort till metoden "Match" med en string som argument, om två kort med matchande string blir tryckta efter varandra bildar de ett par
    //tips: kolla upp AddListener metoden under namespace:et UnityEngine.Events, använda detta när knappar instansieras för att länka knappen till -
    //funktionen och skapa "par".
    public void Match(string card)
    {
        switch(memory)
        {
            case null:
               memory = card;
            break;

            default:
               if(memory == card)
               {
                   Evaluate();
               }

               memory = null;
               switch(multiplayer)
               {
                   case true:
                      playerturn ++;
                      playerturn = (int)Mathf.Repeat(playerturn, 2);
                   break;
   
                   case false:
                   break;
               }
            break;
        }
    }

    void Evaluate()
    {
        switch(multiplayer)
        {
            case true:
               switch(playerturn)
               {
                   case 0:
                      //Kod för att ge spelare 1 ett par här --->
                   break;

                   case 1:
                      //Kod för att ge spelare 2 ett par här --->
                   break;
               }
               Debug.Log("Match! för spelare: " + (playerturn + 1));
            break;

            case false:
               //kod för att ge ett par i enspelarläge, denna behövs igentligen inte men det kan vara lättare att förstå kod:en om det hålls seperat från flerspelarläge
               Debug.Log("Match! enspelarläge");
            break;
        }
    }
}
