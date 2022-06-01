using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkersScriptInObject : MonoBehaviour
{
    public WorkersBuyBehaviour WBB;
    public string name;
    public int ID;
    public void Przypisz()
    {
        name = this.gameObject.GetComponentInChildren<TMP_Text>().text;
    }
    public void Script()
    {
        WBB.WSIO = this.gameObject.GetComponent<WorkersScriptInObject>();
    }
}
