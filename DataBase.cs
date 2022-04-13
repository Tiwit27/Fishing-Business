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
    //przypisywanie informacji do �owisk
    public void Szachta()
    { //0
        city1 = "Wodzis�aw �l�ski";
        size1 = "Bardzo Ma�y";
        fish1 = "P�o�";
        fishQuantity1 = "Ma�a";
        depth1 = "5 metr�w";
        bottomType1 = "Mu�owe";
    }
    public void ZalewPolomski()
    { //1 
        city1 = "Po�omia";
        size1 = "Ma�y";
        fish1 = "Karp";
        fishQuantity1 = "�rednia";
        depth1 = "13 metr�w";
        bottomType1 = "�wirowe";
    }
    public void ZalewRybnicki()
    { //2
        city1 = "Rybnik";
        size1 = "Du�y";
        fish1 = "Karp";
        fishQuantity1 = "Ma�a";
        depth1 = "20 metr�w";
        bottomType1 = "Mu�owe";
    }
    public void DzierznoDuze()
    { //3
        city1 = "Gliwice";
        size1 = "Du�y";
        fish1 = "Leszcz";
        fishQuantity1 = "�rednia";
        depth1 = "17 metr�w";
        bottomType1 = "Glinowe";
    }
    public void JezioroDobrzyckie()
    { //4
        city1 = "Dobrzyce";
        size1 = "Du�y";
        fish1 = "Karp";
        fishQuantity1 = "�rednia";
        depth1 = "16 metr�w";
        bottomType1 = "�wirowe";
    }
    public void ZalewSulejowski()
    { //5
        city1 = "Piotrk�w Trybunalski";
        size1 = "Bardzo Du�y";
        fish1 = "Amur";
        fishQuantity1 = "Du�a";
        depth1 = "32 metry";
        bottomType1 = "Mu�owe";
    }
    public void ZbiornikGoczalkowicki()
    { //6
        city1 = "Gocza�kowice";
        size1 = "Bardzo Du�y";
        fish1 = "Karp";
        fishQuantity1 = "�rednia";
        depth1 = "27 metr�w";
        bottomType1 = "Glinowe";
    }
    public void JezioroCzorsztynskie()
    { //7
        city1 = "Czorsztyn";
        size1 = "�redni";
        fish1 = "Pstr�g";
        fishQuantity1 = "Du�a";
        depth1 = "23 metry";
        bottomType1 = "�wirowe";
    }
    public void Mlynszczok()
    { //8
        city1 = "Zebrzydowice";
        size1 = "Ma�y";
        fish1 = "Karp";
        fishQuantity1 = "�rednia";
        depth1 = "14 metr�w";
        bottomType1 = "Mu�owe";
    }
    public void JezioroLaka()
    { //9
        city1 = "Pszczyna";
        size1 = "�redni";
        fish1 = "Leszcz";
        fishQuantity1 = "�rednia";
        depth1 = "16 metr�w";
        bottomType1 = "�wirowe";
    }
    public void ZbiornikDzieckowice()
    { //10
        city1 = "Tychy";
        size1 = "Du�y";
        fish1 = "Sum";
        fishQuantity1 = "Du�a";
        depth1 = "25 metr�w";
        bottomType1 = "Glinowe";
    }
    public void JezioroSwierklaniec()
    { //11
        city1 = "�wierklaniec";
        size1 = "�redni";
        fish1 = "Karp";
        fishQuantity1 = "�rednia";
        depth1 = "13 metr�w";
        bottomType1 = "Mu�owe";
    }
    public void ZalewPorajski()
    { //12
        city1 = "Cz�stochowa";
        size1 = "Du�y";
        fish1 = "Amur";
        fishQuantity1 = "Du�a";
        depth1 = "17 metr�w";
        bottomType1 = "�wirowe";
    }
    public void JezioroOtmuchowskie()
    { //13
        city1 = "Otmuch�w";
        size1 = "Bardzo Du�y";
        fish1 = "Karp";
        fishQuantity1 = "�rednia";
        depth1 = "29 metr�w";
        bottomType1 = "�wirowe";
    }
    public void JezioroNyskie()
    { //14
        city1 = "Nysa";
        size1 = "Bardzo Du�y";
        fish1 = "Amur";
        fishQuantity1 = "Du�a";
        depth1 = "17 metr�w";
        bottomType1 = "Glinowe";
    }
    public void StaroRzeka()
    { //15
        city1 = "Olza";
        size1 = "Bardzo Ma�y";
        fish1 = "Karp";
        fishQuantity1 = "Bardzo Du�a";
        depth1 = "5 metr�w";
        bottomType1 = "Mu�owe";
    }
}

