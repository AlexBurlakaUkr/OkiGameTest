using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionWinLevel : MonoBehaviour
{
    private Animator cameraWinLevelMove;
    private string moveTrigger = "Move";
    private void Start()
    {
        cameraWinLevelMove= GetComponent<Animator>();
    }
    public void ChangeCameraPosition()
    {
        cameraWinLevelMove.SetTrigger(moveTrigger);
    }
}
