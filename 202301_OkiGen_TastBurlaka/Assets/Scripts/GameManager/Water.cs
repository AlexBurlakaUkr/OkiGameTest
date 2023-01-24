using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private Animator waveAnimation;
    [SerializeField] string parametrName = "StartWave";
    void Start()
    {
        waveAnimation= GetComponent<Animator>();
        waveAnimation.SetBool(parametrName, true);
    }
}
