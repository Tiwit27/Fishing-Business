using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishingClubsBehaviour : MonoBehaviour
{
    public FishingClubsDataBase FCDB;
    public FishingClubsInfo FCI;
    public GameBehaviour GB;
    public GameObject prefab;
    public GameObject list;
    public int prefabCount;
    public Transform StopDown;
    public Transform StopUp;
    public Transform CheckInObject;
    public List<GameObject> MyClub = new List<GameObject>();
    public bool isMoreOne;
    public GameObject writeName;
    public GameObject nameGive;
    public GameObject warning;
    public GameObject warning1;
    public TMP_Dropdown dropdown;
    public GameObject Info;
    public MoneyBehaviour MB;
    public bool isExit;
    public int ID;
    public GameObject thisNameIsBusy;
    void Update()
    {
        if (isMoreOne == true)
        {
                CheckInObject.transform.position = MyClub[ID].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && GB.fishingClubs.activeSelf && !writeName.activeSelf)
        {
            GB.fishingClubs.SetActive(false);
            GB.SG.MainMenu.SetActive(true);
            GB.background3.SetActive(false);
            GB.obramówka1.SetActive(false);
            writeName.SetActive(false);
            list.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Escape) && writeName.activeSelf)
        {
            isExit = true;
            prefabCount--;
            if (prefabCount <= 1)
            {
                isMoreOne = false;
            }
            Destroy(MyClub[ID]);
            MyClub.Remove(MyClub[ID]);
            if (isMoreOne)
            {
                ID--;
            }
            writeName.SetActive(false);
            warning.SetActive(false);
            warning1.SetActive(false);
            thisNameIsBusy.SetActive(false);
            nameGive.GetComponent<TMP_InputField>().text = "";
        }
        //scrollowanie listy
        if (GB.fishingClubs.activeSelf && prefabCount > 4)
        {
            list.transform.position += new Vector3(0, Input.mouseScrollDelta.y * 20 * -1, 0);
            if (list.transform.position.y <= StopUp.transform.position.y)
            {
                Debug.Log("za nisko");
                list.transform.position = new Vector3(list.transform.position.x, 675, list.transform.position.z);
            }
            if (CheckInObject.transform.position.y >= StopDown.transform.position.y)
            {
                Debug.Log("za wysoko");
                float nowPosition = list.transform.position.y;
                list.transform.position = new Vector3(list.transform.position.x, nowPosition - 20, list.transform.position.z);
            }
        }
    }
    public void Create()
    {
            thisNameIsBusy.SetActive(false);
            if (isMoreOne)
            {
                ID++;
            }
            isExit = false;
            writeName.SetActive(true);
            MyClub.Add(Instantiate(prefab));
            MyClub[ID].transform.parent = list.transform;
            MyClub[ID].transform.position = list.transform.position;
            if (prefabCount >= 1)
            {
                MyClub[ID].transform.position -= new Vector3(0, 178 * prefabCount, 0);
                Debug.Log("pozycja");
            }
            prefabCount++;
    }
    void Start()
    {
        thisNameIsBusy.SetActive(false);
        isExit = false;
        warning.SetActive(false);
        writeName.SetActive(false);
        prefabCount = 0;
        isMoreOne = false;
        Info.SetActive(false);
        warning1.SetActive(false);
    }
    public void WriteNameExit()
    {
        if (FCDB.Name.Contains(nameGive.GetComponent<TMP_InputField>().text))
        {
            thisNameIsBusy.SetActive(true);
        }
        else
        {
            if (nameGive.GetComponent<TMP_InputField>().text != "")
            {
                if (MB.money >= 35000)
                {
                    MB.money -= 35000;
                    warning.SetActive(false);
                    warning1.SetActive(false);
                    MyClub[ID].transform.Find("ClubName").GetComponent<TMP_Text>().text = nameGive.GetComponent<TMP_InputField>().text;
                    nameGive.GetComponent<TMP_InputField>().text = "";
                    dropdown.options.Add(new TMP_Dropdown.OptionData() { text = MyClub[ID].transform.Find("ClubName").GetComponent<TMP_Text>().text });
                    dropdown.RefreshShownValue();
                    writeName.SetActive(false);
                    FCI.FCIO.PrzypiszName();
                    FCI.Przypisz();
                    isMoreOne = true;
                    FCDB.Dodaj();
                }
                else
                {
                    warning1.SetActive(true);
                }
            }
            else
            {
                warning.SetActive(true);
                isMoreOne = false;
            }
            nameGive.GetComponent<TMP_InputField>().text = "";
        }
    }
}
