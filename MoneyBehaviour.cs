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
        //przypisanie pieni?dzy
        moneyTMpro.text = money + " z?";
    }
    public void Buy()
    {
        //wywo?anie zakupu
        cost = LIB.cost1;
        money -= cost;
    }
}
