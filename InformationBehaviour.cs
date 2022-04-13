using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InformationBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI lakes;
    public TextMeshProUGUI weather;
    public TextMeshProUGUI sea;
    public TextMeshProUGUI lakes2;
    public TextMeshProUGUI terrain2;
    public TextMeshProUGUI sea2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //zmiana informacji gdy wybieramy kraj
        if (this.gameObject.name == "country 1")
        {
            weather.text = "41%";
            sea.text = "Tak";
        }
        if (this.gameObject.name == "country 2")
        {
            weather.text = "42%";
            sea.text = "Nie";
        }
        if (this.gameObject.name == "country 3")
        {
            weather.text = "49%";
            sea.text = "Tak";
        }
        if (this.gameObject.name == "country 4")
        {
            weather.text = "40%";
            sea.text = "Tak";
        }
        if (this.gameObject.name == "country 5")
        {
            weather.text = "44%";
            sea.text = "Tak";
        }
        if (this.gameObject.name == "Po�udnie")
        {
            terrain2.text = "Wy�ynny";
            sea2.text = "Nie";
        }
        if (this.gameObject.name == "Wsch�d")
        {
            terrain2.text = "Nizinny";
            sea2.text = "Tak";
        }
        if (this.gameObject.name == "P�noc")
        {
            terrain2.text = "Nizinny";
            sea2.text = "Tak";
        }
        if (this.gameObject.name == "Zach�d")
        {
            terrain2.text = "Zr�nicowany";
            sea2.text = "Nie";
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //resetowanie informacji powy�ej
        weather.text = "";
        sea.text = "";
        terrain2.text = "";
        sea2.text = "";
    }
}
