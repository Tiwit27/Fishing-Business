using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RulesBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public RulesDataBase RDB;
    public MyLakesBehaviour MLB;
    public FishingClubsDataBase FCDB;
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
    public int ID2;
    public GameObject Warning;
    public TMP_Dropdown dropdown4;
    //typy
    public GameObject komercyjne;
    public GameObject zwiazkowe;
    public GameObject hodowlane;
    //zwi¹zkowe
    public TMP_Dropdown chooseClub;
    public TMP_Text costTypeText;
    public TMP_Text fishBuyText;
    public TMP_Text fishLimitIsTrueText;
    public TMP_Text maxFishingRodsText;
    public TMP_Text costText;
    public TMP_Text fishCostText;
    public TMP_Text fishLimitText;
    public int ID1;
    void Start()
    {
        Warning.SetActive(false);
        rulesWindow.SetActive(false);
        background.SetActive(false);
        lakeTypeID = 1;
    }
    public void On()
    {
        MLB.myLakes.SetActive(false);
        rulesWindow.SetActive(true);
        background.SetActive(true);
        name.text = "Zasady £owiska: " + MLB.name.text;
        ID = RDB.Name.IndexOf(MLB.name.text);
        //laketype
        if (RDB.LakeType[ID] == "Komercyjne")
        {
            dropdown.value = 0;
            //costType
            if (RDB.CostType[ID] == "Za Wêdkê")
            {
                dropdown1.value = 0;
            }
            if (RDB.CostType[ID] == "Za Godzinê")
            {
                dropdown1.value = 1;
            }
            if (RDB.CostType[ID] == "Za Dobê")
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
            if (RDB.FishBuyType[ID] == "Za Sztukê")
            {
                dropdown2.value = 1;
            }
            if (RDB.FishBuyType[ID] == "Na Wagê")
            {
                dropdown2.value = 2;
            }
            if (RDB.FishBuyType[ID] == "Zakaz")
            {
                dropdown2.value = 3;
            }
            //fishlimitistrue
            switch (RDB.FishLimitIsTrueList[ID])
            {
                case true:
                    ID = RDB.Name.IndexOf(MLB.name.text);
                    RDB.FishLimitIsTrueList[ID] = true;
                    dropdown4.value = 0;
                    break;
                case false:
                    ID = RDB.Name.IndexOf(MLB.name.text);
                    RDB.FishLimitIsTrueList[ID] = false;
                    dropdown4.value = 1;
                    break;
            }
            if (RDB.FishLimitIsTrueList[ID] == true)
            {
                FishLimitInt.SetActive(true);
            }
            else
            {
                inputField2.text = 0.ToString();
                FishLimitInt.SetActive(false);
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
        if (RDB.LakeType[ID] == "Zwi¹zkowe")
        {
            dropdown.value = 1;
            ID1 = FCDB.Name.IndexOf(chooseClub.GetComponentInChildren<TMP_Text>().text);
            chooseClub.value = FCDB.Name.IndexOf(RDB.Club[ID]);
            costTypeText.text = FCDB.CostType[ID1];
            fishBuyText.text = FCDB.FishBuyType[ID1];
            switch (FCDB.FishLimitIsTrueList[ID1])
            {
                case true:
                    ID = RDB.Name.IndexOf(MLB.name.text);
                    RDB.FishLimitIsTrueList[ID1] = true;
                    dropdown4.value = 0;
                    break;
                case false:
                    ID = RDB.Name.IndexOf(MLB.name.text);
                    RDB.FishLimitIsTrueList[ID1] = false;
                    dropdown4.value = 1;
                    break;
            }
            if (RDB.FishLimitIsTrueList[ID1] == true)
            {
                FishLimitInt.SetActive(true);
            }
            else
            {
                inputField2.text = 0.ToString();
                FishLimitInt.SetActive(false);
            }
            maxFishingRodsText.text = FCDB.FishingRodLimit[ID1].ToString();
            costText.text = FCDB.Cost[ID1].ToString();
            fishCostText.text = FCDB.FishCost[ID1].ToString();
            fishLimitText.text = FCDB.FishLimit[ID1].ToString();
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
    //typ ³owiska
    public void LakeType()
    {
        if (lakeType.GetComponent<TMP_Text>().text == "Komercyjne")
        {
            lakeTypeID = 1;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.LakeType[ID] = "Komercyjne";
        }
        if (lakeType.GetComponent<TMP_Text>().text == "Zwi¹zkowe")
        {
            Debug.Log("Ca³oœæ");
            if (FCDB.Name.Count > 0)
            {
                Debug.Log("IF");
                lakeTypeID = 2;
                ID = RDB.Name.IndexOf(MLB.name.text);
                RDB.LakeType[ID] = "Zwi¹zkowe";
                Warning.SetActive(false);
            }
            else
            {
                Debug.Log("Else");
                Warning.SetActive(true);
                lakeTypeID = 1;
                ID = RDB.Name.IndexOf(MLB.name.text);
                RDB.LakeType[ID] = "Komercyjne";
            }
        }
        if (lakeType.GetComponent<TMP_Text>().text == "Hodowlane")
        {
            lakeTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.LakeType[ID] = "Hodowlane";
        }
    }
    //typ p³atnoœci
    public void CostType()
    {
        Warning.SetActive(false);
        if (costType.GetComponent<TMP_Text>().text == "Za Wêdkê")
        {
            costTypeID = 1;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za Wêdkê";
        }
        if (costType.GetComponent<TMP_Text>().text == "Za Godzinê")
        {
            costTypeID = 2;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za Godzinê";
        }
        if (costType.GetComponent<TMP_Text>().text == "Za Dobê")
        {
            costTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.CostType[ID] = "Za Dobê";
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
        Warning.SetActive(false);
        if (fishbuyType.GetComponent<TMP_Text>().text == "W Cenie")
        {
            costTypeID = 1;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "W Cenie";
        }
        if (fishbuyType.GetComponent<TMP_Text>().text == "Za Sztukê")
        {
            costTypeID = 2;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "Za Sztukê";
        }
        if (fishbuyType.GetComponent<TMP_Text>().text == "Na Wagê")
        {
            costTypeID = 3;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "Na Wagê";
        }
        if (fishbuyType.GetComponent<TMP_Text>().text == "Zakaz")
        {
            costTypeID = 4;
            ID = RDB.Name.IndexOf(MLB.name.text);
            RDB.FishBuyType[ID] = "Zakaz";
        }
        //buyfish check
        if (costTypeID == 1 || costTypeID == 4)
        {
            FCDB.FCI.fishCost.gameObject.SetActive(false);
            fishCost.gameObject.SetActive(false);
            if (FCDB.Name.Count > 0)
            {
                FCDB.FishCost[ID] = 0;
            }
            RDB.FishCost[ID] = 0;
            fishCostText.gameObject.SetActive(false);
        }
        else
        {
            FCDB.FCI.fishCost.gameObject.SetActive(true);
            fishCost.gameObject.SetActive(true);
            fishCostText.gameObject.SetActive(true);
        }
    }
    //koszt
    public void Cost()
    {
        Warning.SetActive(false);
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
        Warning.SetActive(false);
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
        Warning.SetActive(false);
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
        Warning.SetActive(false);
        if (inputField2.text == "")
        {
            inputField2.text = 0.ToString();
        }
        RDB.FishLimit[ID] = int.Parse(inputField2.GetComponent<TMP_InputField>().text);
    }
    //fishing rod limit
    public void FishingRodLimit()
    {
        Warning.SetActive(false);
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
        Warning.SetActive(false);
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
        //wyjœcie do menu
        if (Input.GetKeyDown(KeyCode.Escape) && rulesWindow.activeSelf)
        {
            Warning.SetActive(false);
            rulesWindow.SetActive(false);
            MLB.myLakes.SetActive(true);
            background.SetActive(false);
        }
        //przypisanie zwi¹zkowe
        /*if (FCDB.FCB.isMoreOne)
        {
            if (dropdown.value == 1)
            {
                ZwiazkowePrzypisz();
            }
        }*/
    }
    //button change rules
    public void ChangeRules()
    {
        Warning.SetActive(false);
        GB.OpenFishingClubs();
        rulesWindow.SetActive(false);
        background.SetActive(false);
        GB.SG.background2.SetActive(true);
    }
    public void ZwiazkowePrzypisz()
    {
        ID2 = RDB.Club.IndexOf(RDB.Club[ID]);
        ID1 = FCDB.Name.IndexOf(chooseClub.GetComponentInChildren<TMP_Text>().text);
        costTypeText.text = FCDB.CostType[ID1];
        fishBuyText.text = FCDB.FishBuyType[ID1];
        if (FCDB.FishBuyType[ID1] == "W Cenie" || FCDB.FishBuyType[ID1] == "Zakaz")
        {
            fishCostText.gameObject.SetActive(false);
        }
        else
        {
            fishCostText.gameObject.SetActive(true);
        }
        
        switch (FCDB.FishLimitIsTrueList[ID1])
        {
            case true:
                fishLimitIsTrueText.text = "Tak";
                fishLimitText.gameObject.SetActive(true);
                break;
            case false:
                fishLimitIsTrueText.text = "Nie";
                fishLimitText.gameObject.SetActive(false);
                break;
        }
        maxFishingRodsText.text = FCDB.FishingRodLimit[ID1].ToString();
        costText.text = FCDB.Cost[ID1].ToString();
        fishCostText.text = FCDB.FishCost[ID1].ToString();
        fishLimitText.text = FCDB.FishLimit[ID1].ToString();
        RDB.Club[RDB.Name.IndexOf(MLB.name.text)] = chooseClub.GetComponentInChildren<TMP_Text>().text;
    }
}
