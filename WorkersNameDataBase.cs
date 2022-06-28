using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkersNameDataBase : MonoBehaviour
{
    [SerializeField] public List<string> Mnames = new List<string>();
    [SerializeField] public List<string> Wnames = new List<string>();
    [SerializeField] public List<int> Skills = new List<int>();
    [SerializeField] public List<int> Ambitions = new List<int>();
    [SerializeField] public List<int> WantingSalary = new List<int>();
    [SerializeField] public List<Texture> bonusC1 = new List<Texture>();
    [SerializeField] public List<Texture> bonusC2 = new List<Texture>();
    [SerializeField] public List<Texture> bonusC3 = new List<Texture>();
    [SerializeField] public List<Texture> bonusC4 = new List<Texture>();
    [SerializeField] public List<Texture> ambitions = new List<Texture>();
    [SerializeField] public List<Texture> faces = new List<Texture>();
    [SerializeField] public List<bool> StopBuy = new List<bool>();
    //Workers
    [SerializeField] public List<string> NameSave = new List<string>();
    [SerializeField] public List<int> SkillsSave = new List<int>();
    [SerializeField] public List<int> AmbitionsSave = new List<int>();
    [SerializeField] public List<int> SalarySave = new List<int>();
    //save workers to lake
    [SerializeField] public List<string> NameWorker = new List<string>();
    [SerializeField] public List<int> CategoryID = new List<int>();
    [SerializeField] public List<int> LakeID = new List<int>();
    [SerializeField] public List<string> MyLakeID = new List<string>();
    [SerializeField] public List<bool> IsWorking = new List<bool>();
    [SerializeField] public List<string> WorkerOnThisLake = new List<string>();
    [SerializeField] public List<int> WorkerID = new List<int>();
}
