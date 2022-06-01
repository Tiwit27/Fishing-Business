using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptInMyWorker : MonoBehaviour
{
    public AddWorkerBehaviour AWB;
    public int ID;
    public void Nexter()
    {
        AWB.SIMW = this.gameObject.GetComponent<ScriptInMyWorker>();
        AWB.Workername.text = GetComponentInChildren<TMP_Text>().text;
        AWB.MoreInfo();
    }
}
