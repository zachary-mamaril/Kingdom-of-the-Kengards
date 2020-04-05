using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.CoroutineTween;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public Card card;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI desrcriptionText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;

    public Image artworkImage;


    void Start()
    {

        nameText.text = card.name;
        desrcriptionText.text = card.description;
        healthText.text = card.health.ToString();
        attackText.text = card.attack.ToString();
        defenseText.text = card.defense.ToString();
        goldText.text = card.gold.ToString();
        artworkImage.sprite = card.artwork;
    }
}
