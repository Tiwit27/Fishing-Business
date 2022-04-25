using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyBehaviour : MonoBehaviour
{
    public long money;
    public int cost;
    public TextMeshProUGUI moneyTMpro;
    public LakeInfoBehaviour LIB;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        //przypisanie pieniêdzy
        moneyTMpro.text = money + " €";
    }
    public void Buy()
    {
        //wywo³anie zakupu
        cost = LIB.cost1;
        money -= cost;
    }
}
