using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RulesBehaviour : MonoBehaviour
{
    public RulesDataBase RDB;
    public MyLakesBehaviour MLB;
    public GameObject background;
    public TMP_Dropdown dropdown;
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    public TMP_InputField inputField;
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_Dropdown dropdown3;
    public TMP_InputField open1;
    public TMP_InputField close1;
    public TextMeshProUGUI name;
    public GameObject rulesWindow;
    public GameObject lakeType;
    public GameObject costType;
    public GameObject fishbuyType;
    public GameObject cost;
    public GameObject fishCost;
    public GameObject FishLimitis;
    public GameObject FishLimitInt;
    public GameObject FishingRod;
    public GameObject Open;
    public GameObject Close;
    public GameObject Text1;
    public GameObject Text2;
    public int lakeTypeID;
    public int costTypeID;
    public int ID;
    public int y;
    //typy
    public GameObject komercyjne;
    public GameObject zwiazkowe;
    public GameObject hodowlane;
    void Start()
    {
        rulesWindow.SetActive(false);
        background.SetActive(false);
        lakeTypeID = 1;
    }
    public void On()
    {
        MLB.myLakes.SetActive(false);
        rulesWindow.SetActive(true);
        background.SetActive(true);
        name.text = "Zasady �owiska: " + MLB.name.text;
        ID = RDB.Name.IndexOf(MLB.name.text);
        //laketype
        if (RDB.LakeType[ID] == "Komercyjne")
        {
            dropdown.value = 0;
            //costType
            if (RDB.CostType[ID] == "Za W�dk�")
            {
                dropdown1.value = 0;
            }
            if (RDB.CostType[ID] == "Za Godzin�")
            {
                dropdown1.value = 1;
            }
            if (RDB.CostType[ID] == "Za Dob�")
            {
                dropdown1.value = 2;
            }
            if (RDB.CostType[ID] == "Za Stanowisko")
            {
                dropdown1.value = 3;
            }
            //fishCost
            if (RDB.FishBuyType[ID] == "W Cenie")
            {
                dropdown2.value = 0;
            }
            if (RDB.FishBuyType[ID] == "Za Sztuk�")
            {
                dropdown2.value = 1;
            }
            if (RDB.FishBuyType[ID] == "Na Wag�")
            {
                dropdown2.value = 2;
            }
            //Cost
            inputField.text = RDB.Cost[ID].ToString();
            //fishCost
            inputField1.text = RDB.FishCost[ID].ToString();
            //fishLimit
            inputField2.text = RDB.FishLimit[ID].ToString();
            //fishingRod Limit
            if (RDB.FishingRodLimit[ID] == 1)
            {
                dropdown3.value = 0;
            }
            if (RDB.FishingRodLimit[ID] == 2)
            {
                dropdown3.value = 1;
            }
            if (RDB.FishingRodLimit[ID] == 3)
            {
                dropdown3.value = 2;
            }
            if (RDB.FishingRodLimit[ID] == 4)
            {
                dropdown3.value = 3;
            }
            //OpenHours
            open1.text = RDB.Open[ID].ToString();
            close1.text = RDB.Close[ID].ToString();
        }
        if (RDB.LakeType[ID] == "Zwi�zkowe")
        {
            dropdown.value = 1;
        }
        if (RDB.LakeType[ID] == "Hodowlane")
        {
            dropdown.value = 2;
        }
        //buyfish check
        if (RDB.FishBuyType[ID] == "W Cenie")
        {
            fishCost.SetActive(false);
            RDB.FishCost[ID] = 0;
        }
        else
        {
            fishCost.SetActive(true);
        }
    }
    //typ �owiska
    public void LakeType()
    {
        if (lakeType.GetComponent<TMP_Text>().text == "Komercyjne")
        {
            lakeTypeID = 1;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.LakeType[ID] = "Komercyjne";
        }
        if (lakeType.GetComponent<TMP_Text>().text == "Zwi�zkowe")
        {
            lakeTypeID = 2;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.LakeType[ID] = "Zwi�zkowe";
        }
        if (lakeType.GetComponent<TMP_Text>().text == "Hodowlane")
        {
            lakeTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.LakeType[ID] = "Hodowlane";
        }
    }
    //typ p�atno�ci
    public void CostType()
    {
        if (costType.GetComponent<TMP_Text>().text == "Za W�dk�")
        {
            costTypeID = 1;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za W�dk�";
        }
        if (costType.GetComponent<TMP_Text>().text == "Za Godzin�")
        {
            costTypeID = 2;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za Godzin�";
        }
        if (costType.GetComponent<TMP_Text>().text == "Za Dob�")
        {
            costTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za Dob�";
        }
        if (costType.GetComponent<TMP_Text>().text == "Za Stanowisko")
        {
            costTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za Stanowisko";
        }
    }
    //Kupno ryb
    public void FishBuyType()
    {
        if (fishbuyType.GetComponent<TMP_Text>().text == "W Cenie")
        {
            costTypeID = 1;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "W Cenie";
        }
        if (fishbuyType.GetComponent<TMP_Text>().text == "Za Sztuk�")
        {
            costTypeID = 2;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "Za Sztuk�";
        }
        if (fishbuyType.GetComponent<TMP_Text>().text == "Na Wag�")
        {
            costTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "Na Wag�";
        }
        //buyfish check
        if (RDB.FishBuyType[ID] == "W Cenie")
        {
            fishCost.SetActive(false);
            RDB.FishCost[ID] = 0;
            inputField1.text = "0";
        }
        else
        {
            fishCost.SetActive(true);
        }
    }
    //koszt
    public void Cost()
    {
        if (inputField.text == "")
        {
            inputField.text = 0.ToString();
        }
        ID = RDB.Name.IndexOf(MLB.name.text);
        RDB.Cost[ID] = int.Parse(cost.GetComponent<TMP_InputField>().text);
    }
    //koszt ryby
    public void FishCost()
    {
        if (inputField1.text == "")
        {
            inputField1.text = 0.ToString();
        }
        ID = RDB.Name.IndexOf(MLB.name.text);
        RDB.FishCost[ID] = int.Parse(fishCost.GetComponent<TMP_InputField>().text);
    }
    //fish limit istrue
    public void FishLimitIsTrue()
    {
        if (FishLimitis.GetComponent<TMP_Text>().text == "Tak")
        {
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishLimitIsTrueList[ID] = true;
        }
        if (FishLimitis.GetComponent<TMP_Text>().text == "Nie")
        {
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishLimitIsTrueList[ID] = false;
        }
        //check
        if (RDB.FishLimitIsTrueList[ID] == true)
        {
            FishLimitInt.SetActive(true);
        }
        else
        {
            inputField2.text = 0.ToString();
            FishLimitInt.SetActive(false);
        }
    }
    //fish limit
    public void FishLimit()
    {
        if (inputField2.text == "")
        {
            inputField2.text = 0.ToString();
        }
        RDB.FishLimit[ID] = int.Parse(inputField2.GetComponent<TMP_InputField>().text);
    }
    //fishing rod limit
    public void FishingRodLimit()
    {
        if (FishingRod.GetComponent<TMP_Text>().text == "1")
        {
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishingRodLimit[ID] = 1;
        }
        if (FishingRod.GetComponent<TMP_Text>().text == "2")
        {
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishingRodLimit[ID] = 2;
        }
        if (FishingRod.GetComponent<TMP_Text>().text == "3")
        {
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishingRodLimit[ID] = 3;
        }
        if (FishingRod.GetComponent<TMP_Text>().text == "4")
        {
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishingRodLimit[ID] = 4;
        }
    }
    //OpenHours
    public void OpenAndClose()
    {
        ID = RDB.Name.IndexOf(MLB.name.text);
        if (open1.text == "" || int.Parse(open1.text) >= 25 || int.Parse(open1.text) < 0)
        {
            open1.text = RDB.Open[ID].ToString();
        }
        if (close1.text == "" || int.Parse(close1.text) >= 25 || int.Parse(close1.text) < 0)
        {
            close1.text = RDB.Close[ID].ToString();
        }
        if (int.Parse(open1.text) < int.Parse(close1.text))
        {
            RDB.Close[ID] = int.Parse(close1.GetComponent<TMP_InputField>().text);
            RDB.Open[ID] = int.Parse(open1.GetComponent<TMP_InputField>().text);
        }
        else
        {
            close1.GetComponent<TMP_InputField>().text = RDB.Close[ID].ToString();
            open1.GetComponent<TMP_InputField>().text = RDB.Open[ID].ToString();
        }
    }
    void Update()
    {
        switch (lakeTypeID)
        {
            case 1:
                komercyjne.SetActive(true);
                zwiazkowe.SetActive(false);
                hodowlane.SetActive(false);
                break;
            case 2:
                komercyjne.SetActive(false);
                zwiazkowe.SetActive(true);
                hodowlane.SetActive(false);
                break;
            case 3:
                komercyjne.SetActive(false);
                zwiazkowe.SetActive(false);
                hodowlane.SetActive(true);
                break;
        }
        //wyj�cie do menu
        if (Input.GetKeyDown(KeyCode.Escape) && rulesWindow.activeSelf)
        {
            rulesWindow.SetActive(false);
            MLB.myLakes.SetActive(true);
            background.SetActive(false);
        }
    }
    //button change rules
    public void ChangeRules()
    {
        Debug.Log("Wczytaj stron� z zwi�zkiem");
    }
}
