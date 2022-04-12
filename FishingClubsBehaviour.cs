using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishingClubsBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public GameObject prefab;
    public GameObject list;
    public int prefabCount;
    public Transform StopDown;
    public Transform StopUp;
    public Transform CheckInObject;
    public GameObject MyClub;
    public bool isMoreOne;
    public GameObject writeName;
    public GameObject nameGive;
    public GameObject warning;
    public TMP_Dropdown dropdown;
    void Update()
    {
        if (isMoreOne == true)
        {
            CheckInObject.transform.position = MyClub.transform.position;
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
            Destroy(MyClub);
            writeName.SetActive(false);
            prefabCount--;
            if (prefabCount <= 1)
            {
                isMoreOne = false;
            }
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
        writeName.SetActive(true);
        MyClub = Instantiate(prefab);
        MyClub.transform.parent = list.transform;
        MyClub.transform.position = list.transform.position;
        if (prefabCount >= 1)
        {
            MyClub.transform.position -= new Vector3(0, 178 * prefabCount, 0);
            Debug.Log("pozycja");
        }
        prefabCount++;
        isMoreOne = true;
    }
    void Start()
    {
        warning.SetActive(false);
        writeName.SetActive(false);
        prefabCount = 0;
        isMoreOne = false;
    }
    public void WriteNameExit()
    {
        if (nameGive.GetComponent<TMP_InputField>().text != "")
        {
            warning.SetActive(false);
            MyClub.transform.Find("ClubName").GetComponent<TMP_Text>().text = nameGive.GetComponent<TMP_InputField>().text;
            nameGive.GetComponent<TMP_InputField>().text = "";
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = MyClub.transform.Find("ClubName").GetComponent<TMP_Text>().text });
            writeName.SetActive(false);
        }
        else
        {
            warning.SetActive(true);
        }
    }
}
