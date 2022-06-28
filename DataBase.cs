using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public MyLakesBehaviour MLB;
    public int ID;
    public string city1;
    public string size1;
    public string fish1;
    public string fishQuantity1;
    public string depth1;
    public string bottomType1;
    [SerializeField] public List<string> LakeIsBought = new List<string>();
    [SerializeField] public List<string> LakeIsMoreInfo = new List<string>();
    //przypisywanie informacji do ³owisk
    public void Szachta()
    {
        ID = 0;
        city1 = "Wodzis³aw Œl¹ski";
        size1 = "Bardzo Ma³y";
        fish1 = "P³oæ";
        fishQuantity1 = "Ma³a";
        depth1 = "5 metrów";
        bottomType1 = "Mu³owe";
    }
    public void ZalewPolomski()
    {
        ID = 1;
        city1 = "Po³omia";
        size1 = "Ma³y";
        fish1 = "Karp";
        fishQuantity1 = "Œrednia";
        depth1 = "13 metrów";
        bottomType1 = "¯wirowe";
    }
    public void ZalewRybnicki()
    {
        ID = 2;
        city1 = "Rybnik";
        size1 = "Du¿y";
        fish1 = "Karp";
        fishQuantity1 = "Ma³a";
        depth1 = "20 metrów";
        bottomType1 = "Mu³owe";
    }
    public void DzierznoDuze()
    {
        ID = 3;
        city1 = "Gliwice";
        size1 = "Du¿y";
        fish1 = "Leszcz";
        fishQuantity1 = "Œrednia";
        depth1 = "17 metrów";
        bottomType1 = "Glinowe";
    }
    public void JezioroDobrzyckie()
    {
        ID = 4;
        city1 = "Dobrzyce";
        size1 = "Du¿y";
        fish1 = "Karp";
        fishQuantity1 = "Œrednia";
        depth1 = "16 metrów";
        bottomType1 = "¯wirowe";
    }
    public void ZalewSulejowski()
    {
        ID = 5;
        city1 = "Piotrków Trybunalski";
        size1 = "Bardzo Du¿y";
        fish1 = "Amur";
        fishQuantity1 = "Du¿a";
        depth1 = "32 metry";
        bottomType1 = "Mu³owe";
    }
    public void ZbiornikGoczalkowicki()
    {
        ID = 6;
        city1 = "Gocza³kowice";
        size1 = "Bardzo Du¿y";
        fish1 = "Karp";
        fishQuantity1 = "Œrednia";
        depth1 = "27 metrów";
        bottomType1 = "Glinowe";
    }
    public void JezioroCzorsztynskie()
    {
        ID = 7;
        city1 = "Czorsztyn";
        size1 = "Œredni";
        fish1 = "Pstr¹g";
        fishQuantity1 = "Du¿a";
        depth1 = "23 metry";
        bottomType1 = "¯wirowe";
    }
    public void Mlynszczok()
    {
        ID = 8;
        city1 = "Zebrzydowice";
        size1 = "Ma³y";
        fish1 = "Karp";
        fishQuantity1 = "Œrednia";
        depth1 = "14 metrów";
        bottomType1 = "Mu³owe";
    }
    public void JezioroLaka()
    {
        ID = 9;
        city1 = "Pszczyna";
        size1 = "Œredni";
        fish1 = "Leszcz";
        fishQuantity1 = "Œrednia";
        depth1 = "16 metrów";
        bottomType1 = "¯wirowe";
    }
    public void ZbiornikDzieckowice()
    {
        ID = 10;
        city1 = "Tychy";
        size1 = "Du¿y";
        fish1 = "Sum";
        fishQuantity1 = "Du¿a";
        depth1 = "25 metrów";
        bottomType1 = "Glinowe";
    }
    public void JezioroSwierklaniec()
    {
        ID = 11;
        city1 = "Œwierklaniec";
        size1 = "Œredni";
        fish1 = "Karp";
        fishQuantity1 = "Œrednia";
        depth1 = "13 metrów";
        bottomType1 = "Mu³owe";
    }
    public void ZalewPorajski()
    {
        ID = 12;
        city1 = "Czêstochowa";
        size1 = "Du¿y";
        fish1 = "Amur";
        fishQuantity1 = "Du¿a";
        depth1 = "17 metrów";
        bottomType1 = "¯wirowe";
    }
    public void JezioroOtmuchowskie()
    {
        ID = 13;
        city1 = "Otmuchów";
        size1 = "Bardzo Du¿y";
        fish1 = "Karp";
        fishQuantity1 = "Œrednia";
        depth1 = "29 metrów";
        bottomType1 = "¯wirowe";
    }
    public void JezioroNyskie()
    {
        ID = 14;
        city1 = "Nysa";
        size1 = "Bardzo Du¿y";
        fish1 = "Amur";
        fishQuantity1 = "Du¿a";
        depth1 = "17 metrów";
        bottomType1 = "Glinowe";
    }
    public void StaroRzeka()
    {
        ID = 15;
        city1 = "Olza";
        size1 = "Bardzo Ma³y";
        fish1 = "Karp";
        fishQuantity1 = "Bardzo Du¿a";
        depth1 = "5 metrów";
        bottomType1 = "Mu³owe";
    }
}

