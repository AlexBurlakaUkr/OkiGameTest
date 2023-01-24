using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent OnFruitCounter = new UnityEvent();
    public static UnityEvent OnWinTheLevel = new UnityEvent();

    public static void SendFruitCount() => OnFruitCounter.Invoke();
    public static void SendWinTheLevel() => OnWinTheLevel.Invoke();
}
