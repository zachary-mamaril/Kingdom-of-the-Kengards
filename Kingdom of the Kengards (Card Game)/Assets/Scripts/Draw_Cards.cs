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

    void Start()
    {
        
    }

    public void OnClick()
    {
        GameObject playerCard = Instantiate(card1, new Vector3(0,0,0), Quaternion.identity); //on click set new object to create new version of card1 (Quaternion is used to declare No Rotation)
    }
}
