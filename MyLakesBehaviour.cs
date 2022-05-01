using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyLakesBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public MyLakesInfoInObjects MLIIO;
    public LakesBehaviour LB;
    public DataBase DB;
    public LakeInfoBehaviour LIB;
    public GameObject prefab;
    public Transform startPosition;
    public GameObject downPosition;
    public GameObject myLakes;
    public GameObject myLakes1;
    public bool isFirst;
    public int lakes;
    public GameObject myLake;
    public int speed;
    public Transform borderUp;
    public Transform borderDown;
    public Vector3 newPosition;
    public GameObject Info;
    public TextMeshProUGUI name;
    public TextMeshProUGUI city;
    public TextMeshProUGUI size;
    public TextMeshProUGUI fishQuantity;
    public TextMeshProUGUI fish;
    public TextMeshProUGUI depth;
    public TextMeshProUGUI bottomType;
    public GameObject buttons;
    public void AddLake()
    {
        myLakes1.transform.position = new Vector3(0, 0, 0);
        if (isFirst == false)
        {
            myLake = Instantiate(prefab, new Vector3(startPosition.position.x, startPosition.position.y - (168 * lakes), 0), Quaternion.identity);
            lakes++;
        }
        if (isFirst == true)
        {
            myLake = Instantiate(prefab, new Vector3(startPosition.position.x, startPosition.position.y, 0), Quaternion.identity);
            isFirst = false;
            Debug.Log("check");
        }
        myLake.transform.parent = myLakes1.transform;
        myLake.transform.Find("LakeName").GetComponent<TMP_Text>().text = LB.name1;
        downPosition.transform.position = myLake.transform.position;
        }
    void Update()
    {
        //wychodzenie ze strony
        if (Input.GetKeyDown(KeyCode.Escape) && myLakes.activeSelf && !GB.myWorkers.activeSelf)
        {
            name.text = "";
            city.text = "";
            size.text = "";
            fishQuantity.text = "";
            fish.text = "";
            depth.text = "";
            bottomType.text = "";
            buttons.SetActive(false);
            LB.SG.background2.SetActive(true);
            LB.SG.MainMenu.SetActive(true);
            myLakes.SetActive(false);
        }
        //przesuwanie ³owisk
        if (myLakes.activeSelf)
        {
            if (DB.LakeIsBought.Count >= 6)
            {
                myLakes1.transform.position += new Vector3(0, Input.mouseScrollDelta.y * speed * -1, 0);
                if (myLakes1.transform.position.y <= 10)
                {
                    myLakes1.transform.position = new Vector3(myLakes1.transform.position.x, 11, myLakes1.transform.position.z);
                }
                if (downPosition.transform.position.y >= borderDown.transform.position.y)
                {
                    myLakes1.transform.position = new Vector3(myLakes1.transform.position.x, myLakes1.transform.position.y - 20, myLakes1.transform.position.z);
                }
            }
        }
        if (myLakes.activeSelf)
        {
            if (DB.LakeIsBought.Count != 0)
            {
                Info.SetActive(true);
            }
            else
            {
                Info.SetActive(false);
            }
        }
    }
    public void Przypisz()
    {
        name.text = MLIIO.name1;
        city.text = "Miejscowoœæ: " + MLIIO.city1;
        size.text = "Wielkoœæ: " + MLIIO.size1;
        fishQuantity.text = "Iloœæ ryb: " + MLIIO.fishQuantity1;
        fish.text = "G³ówna ryba: " + MLIIO.fish1;
        depth.text = "G³êbokoœæ: " + MLIIO.depth1;
        bottomType.text = "Typ dna: " + MLIIO.bottomType1;
        buttons.SetActive(true);
    }
    void Start()
    {
        name.text = "";
        city.text = "";
        size.text = "";
        fishQuantity.text = "";
        fish.text = "";
        depth.text = "";
        bottomType.text = "";
        buttons.SetActive(false);
    }
}
