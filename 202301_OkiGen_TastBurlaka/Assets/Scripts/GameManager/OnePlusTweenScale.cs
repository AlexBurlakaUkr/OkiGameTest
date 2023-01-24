using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnePlusTweenScale : MonoBehaviour
{
    [SerializeField] private float targetScale;
    [SerializeField] private float timeToReachTarget;
    private float startScale;
    private float percentScaled;
    private void Start()
    {
        startScale = transform.localScale.x;
    }
    private void Update()
    {
        if (percentScaled < 1f)
        {
            percentScaled += Time.deltaTime / timeToReachTarget;
            float scale = Mathf.Lerp(startScale, targetScale, percentScaled);
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
