using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishingClubsDataBase : MonoBehaviour
{
    public RulesBehaviour RB;
    public FishingClubsBehaviour FCB;
    public FishingClubsInfo FCI;
    public int ID;
    public int ID1;
    public List<string> Name = new List<string>();
    public List<string> CostType = new List<string>();
    public List<string> FishBuyType = new List<string>();
    public List<bool> FishLimitIsTrueList = new List<bool>();
    public List<int> FishingRodLimit = new List<int>();
    public List<int> Cost = new List<int>();
    public List<int> FishCost = new List<int>();
    public List<int> FishLimit = new List<int>();
    public RulesDataBase RDB;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Dodaj()
    {
        Name.Add(FCI.FCIO.name);
        CostType.Add("Za Rok");
        FishBuyType.Add("W Cenie");
        FishLimitIsTrueList.Add(true);
        FishingRodLimit.Add(1);
        Cost.Add(0);
        FishCost.Add(0);
        FishLimit.Add(0);
    }
    public void Przypisz()
    {
        ID = Name.IndexOf(FCI.FCIO.name);
    }
    public void CostTypePrzypisz()
    {
        ID1 = FCI.FCIO.ID;
        CostType[ID1] = FCI.costType.GetComponentInChildren<TMP_Text>().text;
    }
    public void FishBuyTypePrzypisz()
    {
        ID1 = FCI.FCIO.ID;
        FishBuyType[ID1] = FCI.fishbuyType.GetComponentInChildren<TMP_Text>().text;
        if (FishBuyType[ID1] == "W Cenie" || FishBuyType[ID1] == "Zakaz")
        {
            FCI.fishCost.gameObject.SetActive(false);
            RB.fishCost.gameObject.SetActive(false);
            FishCost[ID] = 0;
            RB.fishCostText.gameObject.SetActive(false);
        }
        else
        {
            FCI.fishCost.gameObject.SetActive(true);
            RB.fishCost.gameObject.SetActive(true);
            RB.fishCostText.gameObject.SetActive(true);
        }
    }
    public void FishLimitIsTrue()
    {
        ID1 = FCI.FCIO.ID;
        switch (FCI.fishLimitIsTrue.GetComponentInChildren<TMP_Text>().text)
        {
            case "Tak":
                FishLimitIsTrueList[ID1] = true;
                FCI.fishLimit.gameObject.SetActive(true);
                RB.fishLimitText.gameObject.SetActive(true);
                break;
            case "Nie":
                FishLimitIsTrueList[ID1] = false;
                FCI.fishLimit.gameObject.SetActive(false);
                RB.fishLimitText.gameObject.SetActive(false);
                FishLimit[ID1] = 0;
                break;
        }
    }
    public void FishingRodLimitPrzypisz()
    {
        ID1 = FCI.FCIO.ID;
        FishingRodLimit[ID1] = int.Parse(FCI.fishingRodLimit.GetComponentInChildren<TMP_Text>().text);
    }
    public void CostPrzypisz()
    {
        ID1 = FCI.FCIO.ID;
        if (FCI.cost.text == "")
        {
            Cost[ID1] = 0;
            FCI.cost.text = "0";
        }
        else
        {
            Cost[ID1] = int.Parse(FCI.cost.text);
        }
    }
    public void FishCostPrzypisz()
    {
        ID1 = FCI.FCIO.ID;
        if (FCI.fishCost.text == "")
        {
            FishCost[ID1] = 0;
            FCI.fishCost.text = "0";
        }
        else
        {
            FishCost[ID1] = int.Parse(FCI.fishCost.text);
        }
    }
    public void FishLimitPrzypisz()
    {
        ID1 = FCI.FCIO.ID;
        if (FCI.fishLimit.text == "")
        {
            FishLimit[ID1] = 0;
            FCI.fishLimit.text = "0";
        }
        else
        {
            FishLimit[ID1] = int.Parse(FCI.fishLimit.text);
        }
    }
    public void On()
    {
        ID1 = FCI.FCIO.ID;
        FCI.nameClub.text = "Regulamin zwi¹zku: " + Name[ID1];
        switch (CostType[ID1])
        {
            case "Za Rok":
                FCI.costType.value = 0;
                break;
            case "Za Miesi¹c":
                FCI.costType.value = 1;
                break;
        }
        switch (FishBuyType[ID1])
        {
            case "W Cenie":
                FCI.fishbuyType.value = 0;
                break;
            case "Za Sztukê":
                FCI.fishbuyType.value = 1;
                break;
            case "Na Wagê":
                FCI.fishbuyType.value = 2;
                break;
            case "Zakaz":
                FCI.fishbuyType.value = 3;
                break;
        }
        switch (FishLimitIsTrueList[ID1])
        {
            case true:
                FCI.fishLimitIsTrue.value = 0;
                break;
            case false:
                FCI.fishLimitIsTrue.value = 1;
                break;
        };
        switch (FishingRodLimit[ID1])
        {
            case 1:
                FCI.fishingRodLimit.value = 0;
                break;
            case 2:
                FCI.fishingRodLimit.value = 1;
                break;
            case 3:
                FCI.fishingRodLimit.value = 2;
                break;
            case 4:
                FCI.fishingRodLimit.value = 3;
                break;
        }
        FCI.cost.text = Cost[ID1].ToString();
        FCI.fishCost.text = FishCost[ID1].ToString();
        FCI.fishLimit.text = FishLimit[ID1].ToString();
    }
}
