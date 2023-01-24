using TMPro;
using UnityEngine;

public class PickFruitCounterText : MonoBehaviour
{
    private int count = 0;
    [SerializeField] private TaskForTheLevel taskForTheLevel;
    private int numberFruitForWin;

    private void Start()
    {
        GlobalEventManager.OnFruitCounter.AddListener(FruitCount);
        numberFruitForWin = taskForTheLevel.fruitCollectNumber;

    }
    private void Update()
    {
        if(numberFruitForWin == count)
        {
            GlobalEventManager.SendWinTheLevel();
        }
    }
    private void FruitCount()
    {
        count++;
        GetComponent<TMP_Text>().text = $"- {count}";
    }
}
