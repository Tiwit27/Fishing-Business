using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LakeInfoBehaviour : MonoBehaviour
{
    public WorkersNameDataBase WNDB;
    public RulesDataBase RDB;
    public LakesBehaviour LB;
    public DataBase DB;
    public MoneyBehaviour MB;
    public GameBehaviour GB;
    public MyLakesBehaviour MLB;
    public TextMeshProUGUI name;
    public TextMeshProUGUI popular;
    public TextMeshProUGUI city;
    public TextMeshProUGUI size;
    public TextMeshProUGUI fish;
    public TextMeshProUGUI topFish;
    public TextMeshProUGUI depth;
    public TextMeshProUGUI bottomType;
    public TextMeshProUGUI price;
    public int cost1;
    public GameObject Button;
    public GameObject MoreInfoButton;
    public int lakesQuantity1;
    public string x;
    public GameObject notEnaughMoney;
    void Start()
    {
        notEnaughMoney.SetActive(false);
    }
    void Update()
    {
        if (notEnaughMoney.activeSelf && Input.anyKeyDown)
        {
            notEnaughMoney.SetActive(false);
        }
    }
    public void LakeInfoIsOn()
    {
        //w³¹czenie okna z informacjami o ³owisku
        name.text = LB.name1;
        city.text = LB.city1;
        popular.text = LB.popular1;
        price.text = "Kup:     " + LB.price1 + "z³";
        x = name.text;
        if (DB.LakeIsBought.Contains(x))
        {
            Button.SetActive(false);
            MoreInfoButton.SetActive(false);
            name.text = LB.name1;
            city.text = LB.city1;
            popular.text = LB.popular1;
            size.text = "Wielkoœæ: " + DB.size1;
            fish.text = "Iloœæ ryb: " + DB.fishQuantity1;
            topFish.text = "G³ówna ryba: " + DB.fish1;
            depth.text = "G³êbokoœæ: " + DB.depth1;
            bottomType.text = "Typ dna: " + DB.bottomType1;
        }
        else if (DB.LakeIsMoreInfo.Contains(x))
        {
            MoreInfoButton.SetActive(false);
            name.text = LB.name1;
            city.text = LB.city1;
            popular.text = LB.popular1;
            size.text = "Wielkoœæ: " + DB.size1;
            fish.text = "Iloœæ ryb: " + DB.fishQuantity1;
            topFish.text = "G³ówna ryba: " + DB.fish1;
            depth.text = "G³êbokoœæ: " + DB.depth1;
            bottomType.text = "Typ dna: " + DB.bottomType1;
        }
        else
        {
            Button.SetActive(true);
            MoreInfoButton.SetActive(true);
        }
    }
    public void MoreInfo()
    {
        //wiêcej informacji
        if (MB.money >= 500)
        {
            MoreInfoButton.SetActive(false);
            MB.money -= 500;
            size.text = "Wielkoœæ: " + DB.size1;
            fish.text = "Iloœæ ryb: " + DB.fishQuantity1;
            topFish.text = "G³ówna ryba: " + DB.fish1;
            depth.text = "G³êbokoœæ: " + DB.depth1;
            bottomType.text = "Typ dna: " + DB.bottomType1;
            DB.LakeIsMoreInfo.Add(name.text);
        }
        else
        {
            notEnaughMoney.SetActive(true);
        }
    }
    public void BuyButton()
    {
        //zakup ³owiska
        cost1 = int.Parse(LB.price1);
        if (MB.money >= cost1)
        {
            Button.SetActive(false);
            lakesQuantity1 = int.Parse(GB.LakesQuantity.text);
            lakesQuantity1++;
            GB.LakesQuantity.text = lakesQuantity1.ToString();
            DB.LakeIsBought.Add(name.text);
            MLB.AddLake();
            if (!DB.LakeIsMoreInfo.Contains(x))
            {
                DB.LakeIsMoreInfo.Add(name.text);
            }
            //usuwanie przycisku moreinfo
            MoreInfoButton.SetActive(false);
            size.text = "Wielkoœæ: " + DB.size1;
            fish.text = "Iloœæ ryb: " + DB.fishQuantity1;
            topFish.text = "G³ówna ryba: " + DB.fish1;
            depth.text = "G³êbokoœæ: " + DB.depth1;
            bottomType.text = "Typ dna: " + DB.bottomType1;
            MB.Buy();
        }
        else
        {
            notEnaughMoney.SetActive(true);
        }
        //name
        RDB.Name.Add(name.text);
        //lakeType
        RDB.LakeType.Add("Komercyjne");
        //costType
        RDB.CostType.Add("Za Wêdkê");
        //FishBuyType
        RDB.FishBuyType.Add("W Cenie");
        //cost
        RDB.Cost.Add(0);
        //fishCost
        RDB.FishCost.Add(0);
        //fishLimitisTrue
        RDB.FishLimitIsTrueList.Add(true);
        //fishLimit
        RDB.FishLimit.Add(0);
        //fishing Rod Limit
        RDB.FishingRodLimit.Add(1);
        //Open Hours
        RDB.Open.Add(6);
        RDB.Close.Add(20);
        RDB.Club.Add("");
        WNDB.MyLakeID.Add(name.text);
        for (int i = 0; i < 4; i++)
        {
            WNDB.WorkerOnThisLake.Add("");
        }
    }
    public void Back()
    {
        //powrót na stronê z ³owiskami
        size.text = "Wielkoœæ: ";
        fish.text = "Iloœæ ryb: ";
        topFish.text = "G³ówna ryba: ";
        depth.text = "G³êbokoœæ: ";
        bottomType.text = "Typ dna: ";
        Button.SetActive(true);
        MoreInfoButton.SetActive(true);
        LB.lakeInformation.SetActive(false);
        LB.lakes.SetActive(true);
    }
}
