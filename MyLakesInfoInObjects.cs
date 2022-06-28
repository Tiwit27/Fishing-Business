using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyLakesInfoInObjects : MonoBehaviour
{
    public MyLakesBehaviour MLB;
    public string name1;
    public string city1;
    public string size1;
    public string fishQuantity1;
    public string fish1;
    public string depth1;
    public string bottomType1;

    void Start()
    {
        MLB = GameObject.Find("Manager").GetComponent<MyLakesBehaviour>();
    }
    public void Przekaznik()
    {
        MLB.GB.AWB.IDPrzypisz();
    }
    public void Przypisz()
    {
        MLB.MLIIO = this.gameObject.GetComponent<MyLakesInfoInObjects>();
        city1 = MLB.DB.city1;
        size1 = MLB.DB.size1;
        fishQuantity1 = MLB.DB.fishQuantity1;
        fish1 = MLB.DB.fish1;
        depth1 = MLB.DB.depth1;
        bottomType1 = MLB.DB.bottomType1;
        MLB.Przypisz();
    }
    //wybór ³owiska
    public void LakeID()
    {
        name1 = this.gameObject.GetComponentInChildren<TMP_Text>().text;
        if (name1 == "Szachta")
        {
            MLB.DB.Szachta();
        }
        if (name1 == "Zalew Po³omski")
        {
            MLB.DB.ZalewPolomski();
        }
        if (name1 == "Zalew Rybnicki")
        {
            MLB.DB.ZalewRybnicki();
        }
        if (name1 == "Dzier¿no Du¿e")
        {
            MLB.DB.DzierznoDuze();
        }
        if (name1 == "Jezioro Dobrzyckie")
        {
            MLB.DB.JezioroDobrzyckie();
        }
        if (name1 == "Zalew Sulejowski")
        {
            MLB.DB.ZalewSulejowski();
        }
        if (name1 == "Zbiornik Gocza³kowice")
        {
            MLB.DB.ZbiornikGoczalkowicki();
        }
        if (name1 == "Jezioro Czorsztyñskie")
        {
            MLB.DB.JezioroCzorsztynskie();
        }
        if (name1 == "M³yñszczok")
        {
            MLB.DB.Mlynszczok();
        }
        if (name1 == "Jezioro £¹ka")
        {
            MLB.DB.JezioroLaka();
        }
        if (name1 == "Zbiornik Dzieækowice")
        {
            MLB.DB.ZbiornikDzieckowice();
        }
        if (name1 == "Jezioro Œwierklaniec")
        {
            MLB.DB.JezioroSwierklaniec();
        }
        if (name1 == "Zalew Porajski")
        {
            MLB.DB.ZalewPorajski();
        }
        if (name1 == "Jezioro Otmuchowskie")
        {
            MLB.DB.JezioroOtmuchowskie();
        }
        if (name1 == "Jezioro Nyskie")
        {
            MLB.DB.JezioroNyskie();
        }
        if (name1 == "Staro Rzeka")
        {
            MLB.DB.StaroRzeka();
        }
    }
}
