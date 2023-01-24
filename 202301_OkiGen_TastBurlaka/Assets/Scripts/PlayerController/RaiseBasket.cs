using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RaiseBasket : TakeFood
{
    private OverrideTransform mobRigOverride;
    private void Start()
    {
        mobRigOverride = GetComponent<OverrideTransform>();
    }
    public override void GetAnimationRig(float weigthValue)
    {
        mobRigOverride.weight = Mathf.MoveTowards(mobRigOverride.weight, weigthValue, weightSpeed * Time.deltaTime);
        if (mobRigOverride.weight == weigthValue) attackID = (int)ChangeActionCommand.Neutral;
    }
}
