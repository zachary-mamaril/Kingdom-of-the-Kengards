using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_Cards : MonoBehaviour
{
    //Create public objects to use in the Inspector
    public GameObject card1;
    public GameObject card2;
    public GameObject playerArea;
    public GameObject enemyArea;

    List<GameObject> cards = new List<GameObject>();

    void Start()
    {
        cards.Add(card1);
        cards.Add(card2);
    }

    public void OnClick()
    {
        for(var i=0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity); //on click set new object to create new version of card1 (Quaternion is used to declare No Rotation)
            playerCard.transform.SetParent(playerArea.transform, false);
        }

        for(var j=0; j < 5; j++)
        {
            GameObject enemyCard = Instantiate(cards[Random.Range(0,cards.Count)], new Vector3(0, 0, 0), Quaternion.identity); //in cards list, we will instantiate a random card from the range in the list.(random assortment of cards)
            enemyCard.transform.SetParent(enemyArea.transform, false);
        }

    }

}
