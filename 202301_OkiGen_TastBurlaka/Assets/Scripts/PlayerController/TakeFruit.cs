using System.Collections;
using UnityEngine;


public class TakeFruit : MonoBehaviour
{
    [SerializeField] private TakeFood takeFood;
    [SerializeField] private RaiseBasket raiseBasket;
    [SerializeField] private GameObject foodTarget;
    [SerializeField] private GameObject basketTarget;
    [SerializeField] private GameObject targetForSupervise;
    [SerializeField] private TaskForTheLevel fruitNameFromTasK;
    private GameObject currentFruit;
    private RaycastHit hit;
    private float scaleFruitValue = 0.5f;
    private float deleyTimeForCurotine = 0.4f;
    private string fruitName;
    private void Start()
    {
        fruitName = fruitNameFromTasK.fruitName;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) PicUp();
    }
    void PicUp()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) GetFruitByTag(fruitName);
    }
    void GetFruitByTag(string fruitName)
    {
        if (hit.collider.gameObject.CompareTag(fruitName)) StartCoroutine(GetChangeTransform());
        else SoundManager.Instance.PlayWrongClip();
    }
    IEnumerator GetChangeTransform()
    {
        GetChangeFruitTargetOrSelectFruitTransform(foodTarget, hit.transform);
        takeFood.GetAnimationRigCommand((int)ChangeActionCommand.PlayForvard);
        raiseBasket.GetAnimationRigCommand((int)ChangeActionCommand.PlayForvard);
        yield return new WaitForSeconds(deleyTimeForCurotine);
        hit.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        currentFruit = hit.transform.gameObject;
        GetChangeFruitTargetOrSelectFruitTransform(currentFruit, transform);
        GetChangeFruitTargetOrSelectFruitTransform(foodTarget, basketTarget.transform);
        GetTransformLocalScale(currentFruit, new Vector3(scaleFruitValue, scaleFruitValue, scaleFruitValue));
        SoundManager.Instance.PlayCorrectClip();
        yield return new WaitForSeconds(deleyTimeForCurotine);
        GetTransformPosToParentObject(currentFruit, basketTarget.transform);
        GlobalEventManager.SendFruitCount();
        currentFruit.transform.GetComponent<Rigidbody>().isKinematic = false;
        GetChangeFruitTargetOrSelectFruitTransform(foodTarget, targetForSupervise.transform);
        takeFood.GetAnimationRigCommand((int)ChangeActionCommand.PlayBack);
        raiseBasket.GetAnimationRigCommand((int)ChangeActionCommand.PlayBack);
    }
    void GetChangeFruitTargetOrSelectFruitTransform(GameObject selectObject, Transform parentTransform)
    {
        GetTransformPosToParentObject(selectObject, parentTransform);
        GetTransformLocalPos(selectObject, Vector3.zero);
        GetTransformLocalEulerAngels(selectObject, Vector3.zero);
    }
    private void GetTransformPosToParentObject(GameObject gameObject, Transform parentObjectTransform)
    {
        gameObject.transform.parent = parentObjectTransform;
    }
    private void GetTransformLocalPos(GameObject gameObject, Vector3 vector3)
    {
        gameObject.transform.localPosition = vector3;
    }
    private void GetTransformLocalEulerAngels(GameObject gameObject, Vector3 vector3)
    {
        gameObject.transform.localEulerAngles = vector3;
    }
    private void GetTransformLocalScale(GameObject gameObject, Vector3 vector3)
    {
        gameObject.transform.localScale = vector3;
    }
}
