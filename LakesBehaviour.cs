using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LakesBehaviour : MonoBehaviour
{
    public GameObject lakes;
    public GameBehaviour GameB;
    public BackgroundButtonBehaviour BBB;
    public StartGame SG;
    public float speed;
    public GameObject poludnie;
    public GameObject polnoc;
    public GameObject wschod;
    public GameObject zachod;
    public GameObject lakeInformation;
    public LakeInfoBehaviour LIB;
    public string name1;
    public string city1;
    public string popular1;
    public string price1;
    public int ppwz;
    void Start()
    {
        lakes.transform.position = new Vector3(lakes.transform.position.x, 200, 0);
        lakeInformation.SetActive(false);
    }
    void Update()
    {
        //przewijanie strony z ³owiskami
        if (lakes.activeSelf)
        {
            lakes.transform.position += new Vector3(0, Input.mouseScrollDelta.y * speed * -1, 0);
            if (lakes.transform.position.y <= 900)
            {
                lakes.transform.position = new Vector3(lakes.transform.position.x, 901, lakes.transform.position.z);
            }
            if (lakes.transform.position.y >= 2776)
            {
                lakes.transform.position = new Vector3(lakes.transform.position.x, 2775, lakes.transform.position.z);
            }
        }
        //wychodzenie ze strony
        if (Input.GetKeyDown(KeyCode.Escape) && lakes.activeSelf)
        {
            SG.background2.SetActive(true);
            SG.MainMenu.SetActive(true);
            lakes.SetActive(false);
        }
    }
    public void Region()
    {
        //przypisanie wybranego regionu
        poludnie.SetActive(false);
        wschod.SetActive(false);
        polnoc.SetActive(false);
        zachod.SetActive(false);
        switch (ppwz)
        {
            case 1:
                poludnie.SetActive(true);
                break;
            case 2:
                wschod.SetActive(true);
                break;
            case 3:
                polnoc.SetActive(true);
                break;
            case 4:
                zachod.SetActive(true);
                break;
        }
    }
    public void LakeInfo()
    {
        //przekazywanie wiêkszoœci informacji (odnosi siê do LakeInfoBehaviour)
        name1 = BBB.name;
        city1 = BBB.city;
        popular1 = BBB.popular;
        price1 = BBB.price;
        lakeInformation.SetActive(true);
        lakes.SetActive(false);
        LIB.LakeInfoIsOn();
    }
}
