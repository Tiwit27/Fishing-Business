using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class StartGame : MonoBehaviour
{
    public TimeBehaviour TB;
    public GameBehaviour GameB;
    public LakesBehaviour LB;
    public GameObject person;
    public GameObject money;
    public GameObject lakes;
    public GameObject start;
    public GameObject chooseCountry;
    public GameObject chooseRegion;
    public TextMeshProUGUI username;
    public GameObject background;
    public GameObject background1;
    public GameObject background2;
    public GameObject MainMenu;
    private int countryID;
    private int regionID;
    void Start()
    {
        //przypisanie
        person = GameObject.Find("User Name");
        money = GameObject.Find("Money");
        start = GameObject.Find("Start");
        background = GameObject.Find("Background");
        chooseRegion = GameObject.Find("Choose region");
        person.SetActive(false);
        money.SetActive(false);
        lakes.SetActive(false);
        start.SetActive(true);
        chooseCountry.SetActive(false);
        chooseRegion.SetActive(false);
        background.SetActive(true);
        background1.SetActive(false);
        background2.SetActive(false);
        MainMenu.SetActive(false);
        GameB.buyLakes.SetActive(false);
        GameB.obramówka.SetActive(false);
        GameB.MLB.myLakes.SetActive(false);
    }

    public void Next()
    {
        //dalej
        username.text = GameObject.Find("user name input").GetComponent<TMP_InputField>().text;
        start.SetActive(false);
        chooseCountry.SetActive(true);
    }
    public void Next1()
    {
        //dalej
        chooseCountry.SetActive(false);
        chooseRegion.SetActive(true);
    }
    public void Next2()
    {
        //dalej
        chooseRegion.SetActive(false);
        background.SetActive(false);
        background1.SetActive(true);
        background2.SetActive(true);
        MainMenu.SetActive(true);
        person.SetActive(true);
        money.SetActive(true);
        lakes.SetActive(true);
        TB.TimeStart();
    }
    //countries
    public void Poland()
    {
        countryID = 1;
    }
    public void Czech()
    {
        countryID = 2;
    }
    public void GB()
    {
        countryID = 3;
    }
    public void Spain()
    {
        countryID = 4;
    }
    public void Germany()
    {
        countryID = 5;
    }
    //regions
    public void P1()
    {
        regionID = 1;
        LB.ppwz = 1;
        LB.Region();
    }
    public void P2()
    {
        regionID = 2;
        LB.ppwz = 2;
        LB.Region();
    }
    public void P3()
    {
        regionID = 3;
        LB.ppwz = 3;
        LB.Region();
    }
    public void P4()
    {
        regionID = 4;
        LB.ppwz = 4;
        LB.Region();
    }

}
