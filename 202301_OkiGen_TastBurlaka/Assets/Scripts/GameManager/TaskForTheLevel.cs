using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskForTheLevel : MonoBehaviour
{
    public int fruitCollectNumber = 0;
    public string fruitName;
    private int randomIndex;
    [SerializeField] private List<string> fruitsNameList= new List<string>();
    [SerializeField] private List<Image> fruitsImageList= new List<Image>();
    private void Awake()
    {
        fruitCollectNumber = Random.Range(1, 6);
        randomIndex = Random.Range(0, fruitsNameList.Count);
        fruitName = fruitsNameList[randomIndex];
        fruitsImageList[randomIndex].gameObject.SetActive(true);
        GetComponent<TMP_Text>().text = $"Collect {fruitCollectNumber} {fruitName}";
    }
}
