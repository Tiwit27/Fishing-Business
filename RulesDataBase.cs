using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesDataBase : MonoBehaviour
{
    public LakeInfoBehaviour LIB;
    public List<string> Name = new List<string>();
    public List<string> LakeType = new List<string>();
    public List<string> CostType = new List<string>();
    public List<string> FishBuyType = new List<string>();
    public List<int> Cost = new List<int>();
    public List<int> FishCost = new List<int>();
    public List<bool> FishLimitIsTrueList = new List<bool>();
    public List<int> FishLimit = new List<int>();
    public List<int> FishingRodLimit = new List<int>();
    public List<int> Open = new List<int>();
    public List<int> Close = new List<int>();
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
