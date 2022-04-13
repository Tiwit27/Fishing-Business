using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackgroundButtonBehaviour : MonoBehaviour
{
    public LakesBehaviour LB;
    public string name;
    public string city;
    public string popular;
    public string price;
    void Start()
    {
        //przypisanie danych stawu (odnosi siê do lakeInfoBehaviour)
        name = transform.Find("Name").GetComponent<TMP_Text>().text;
        city = transform.Find("City").GetComponent<TMP_Text>().text;
        popular = transform.Find("popular").GetComponent<TMP_Text>().text;
        //price = int.Parse(transform.Find("Price").GetComponent<TMP_Text>().text);
        price = transform.Find("Price").GetComponent<TMP_Text>().text;
    }
    public void Click()
    {
        //przypisywanie informacji (odnosi siê do LakeBehaviour)
        LB.BBB = this.gameObject.GetComponent<BackgroundButtonBehaviour>();
        LB.LakeInfo();
    }
}
