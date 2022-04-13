using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishingClubsDataBase : MonoBehaviour
{
    public FishingClubsBehaviour FCB;
    public FishingClubsInfo FCI;
    public int ID;
    public List<string> Name = new List<string>();
    public List<string> CostType = new List<string>();
    public List<string> FishBuyType = new List<string>();
    public List<bool> FishLimitIsTrueList = new List<bool>();
    public List<int> FishingRodLimit = new List<int>();
    public List<int> Cost = new List<int>();
    public List<int> FishCost = new List<int>();
    public List<int> FishLimit = new List<int>();
    public List<int> Open = new List<int>();
    public List<int> Close = new List<int>();
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Dodaj()
    {
        Name.Add(FCI.FCIO.name);
        CostType.Add("Za Wêdkê");
        FishBuyType.Add("W Cenie");
        FishLimitIsTrueList.Add(true);
        FishingRodLimit.Add(1);
        Cost.Add(0);
        FishCost.Add(0);
        FishLimit.Add(0);
        //Open.Add();
        //Close.Add();
    }
    public void Przypisz()
    {
        ID = Name.IndexOf(FCI.FCIO.name);
        CostType[ID] = FCI.costType.GetComponentInChildren<TMP_Text>().text;
        FishBuyType[ID] = FCI.fishbuyType.GetComponentInChildren<TMP_Text>().text;
        switch (FCI.fishLimitIsTrue.GetComponentInChildren<TMP_Text>().text)
        {
            case "Tak":
                FishLimitIsTrueList[ID] = true;
                break;
            case "Nie":
                FishLimitIsTrueList[ID] = false;
                break;
        }
        FishingRodLimit[ID] = int.Parse(FCI.fishingRodLimit.GetComponentInChildren<TMP_Text>().text);
        Cost[ID] = int.Parse(FCI.cost.text);
        FishCost[ID] = int.Parse(FCI.fishCost.text);
        FishLimit[ID] = int.Parse(FCI.fishLimit.text);
    }
    public void On()
    {
        FCI.nameClub.text = "Regulamin zwi¹zku: " + Name[FCI.FCIO.ID];
        /*CostType.Add("Za Wêdkê");
        FishBuyType.Add("W Cenie");
        FishLimitIsTrueList.Add(true);
        FishingRodLimit.Add(1);
        Cost.Add(0);
        FishCost.Add(0);
        FishLimit.Add(0);*/
    }
}
