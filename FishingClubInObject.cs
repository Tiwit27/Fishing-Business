using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishingClubInObject : MonoBehaviour
{
    public FishingClubsInfo FCI;
    public string name;
    public string name1;
    public int ID;
    void Start()
    {
        FCI = GameObject.Find("Manager").GetComponent<FishingClubsInfo>();
        FCI.FCIO = this.gameObject.GetComponent<FishingClubInObject>();
        name = this.gameObject.GetComponentInChildren<TMP_Text>().text;
    }
    public void PrzypiszName()
    {
        name = this.gameObject.GetComponentInChildren<TMP_Text>().text;
    }
    public void Click()
    {
        FCI.FCB.Info.SetActive(true);
        FCI.FCIO = this.gameObject.GetComponent<FishingClubInObject>();
        ID = FCI.FCDB.Name.IndexOf(name);
        FCI.FCDB.On();
    }
}
