using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class WinTheGame : MonoBehaviour
{
    [SerializeField] private GameObject conveyorSpawner;
    [SerializeField] private GameObject fruitSpawner;
    [SerializeField] private GameObject basketWithFruit;
    [SerializeField] private GameObject playLevelUI;
    [SerializeField] private GameObject winLevelUI;
    [SerializeField] private GameObject torchs;
    [SerializeField] List<string> danceNameList = new List<string>();
    [SerializeField] private Animator playerAnimation;
    [SerializeField] private TwoBoneIKConstraint constraintIKHand;
    [SerializeField] private TwoBoneIKConstraint constraintIKBigFinger;
    [SerializeField] private OverrideTransform constrainOverrideLeftHand;
    [SerializeField] CameraPositionWinLevel mainCameraMove;
    private string danceForWinLevel;
    private float constrainOff = 0f;
    private float deleyTime = 0.4f;
    public int indexNumber;

    private void Awake()
    {
        indexNumber = Random.Range(0, danceNameList.Count);
        danceForWinLevel = danceNameList[indexNumber];
    }
    private void Start()
    {
        GlobalEventManager.OnWinTheLevel.AddListener(GetStartWinLevel);
    }
    private void GetStartWinLevel() => StartCoroutine(GetWinTheLevel());
    IEnumerator GetWinTheLevel()
    {
        yield return new WaitForSeconds(deleyTime);
        SoundManager.Instance.StopFonMusic();
        conveyorSpawner.SetActive(false);
        fruitSpawner.SetActive(false);
        basketWithFruit.SetActive(false);
        playLevelUI.SetActive(false);
        winLevelUI.SetActive(true);
        mainCameraMove.ChangeCameraPosition();
        constraintIKHand.weight = constrainOff;
        constraintIKBigFinger.weight = constrainOff;
        constrainOverrideLeftHand.weight = constrainOff;
        SoundManager.Instance.PlayAudioForWinDance();
        torchs.SetActive(true);
        PlayerAttackAnimation(danceForWinLevel);
    }
    private void PlayerAttackAnimation(string typeOfAttack) => playerAnimation.SetTrigger(typeOfAttack);
}
