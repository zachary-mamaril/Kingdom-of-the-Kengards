using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject zoomCard;
    private CanvasScaler scale;
    public void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
    }

    public void OnHoverEnter()//when mouse enters field where card is located...
    {
        ///Vector2 screen division added to place hovered cards to the center of the screen
        zoomCard = Instantiate(gameObject, new Vector2(Screen.width / 2, Screen.height / 2), Quaternion.identity); //creates clone
        zoomCard.transform.SetParent(Canvas.transform, true);
        zoomCard.layer = LayerMask.NameToLayer("Zoom");
        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(250,400);
    }

    public void OnHoverExit()
    {
        Destroy(zoomCard);//Destroys clone after mouse leaves.
    }
}
