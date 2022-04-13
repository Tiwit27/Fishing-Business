using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishingClubsInfo : MonoBehaviour
{
    public FishingClubsBehaviour FCB;
    public FishingClubsDataBase FCDB;
    public FishingClubInObject FCIO;
    public TMP_Text nameClub;
    public TMP_Dropdown costType;
    public TMP_Dropdown fishbuyType;
    public TMP_Dropdown fishLimitIsTrue;
    public TMP_Dropdown fishingRodLimit;
    public TMP_InputField cost;
    public TMP_InputField fishCost;
    public TMP_InputField fishLimit;
    public void Przypisz()
    {
        nameClub.text = "Regulamin zwi¹zku: " + FCIO.name;
    }
}
