using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public enum ChangeActionCommand { Neutral, PlayForvard, PlayBack };

public class TakeFood : MonoBehaviour
{
    private ChainIKConstraint mobRig;
    [SerializeField] protected float weightSpeed = 10f;
    protected float maxWeigthValue = 1f;
    protected float minWeigthValue = 0f;
    protected int attackID;

    private void Start()
    {
        mobRig = gameObject.GetComponent<ChainIKConstraint>();
    }
    public virtual void GetAnimationRigCommand(int attackid)
    {
        attackID = attackid;
        if (attackID == (int)ChangeActionCommand.PlayForvard)
        {
            GetAnimationRig(maxWeigthValue);
        }
        else if (attackID == (int)ChangeActionCommand.PlayBack)
        {
            GetAnimationRig(minWeigthValue);
        }
    }
    public virtual void GetAnimationRig(float weigthValue)
    {
        mobRig.weight = Mathf.MoveTowards(mobRig.weight, weigthValue, weightSpeed * Time.deltaTime);
        if (mobRig.weight == weigthValue) attackID = (int)ChangeActionCommand.Neutral;
    }
}
