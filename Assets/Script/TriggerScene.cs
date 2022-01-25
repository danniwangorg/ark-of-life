using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour
{
    public Camera OriginCam;
    public Camera ChangeCam;
    public GameObject OriginCharacter;
    public GameObject ChangeCharacter;
    void Start()
    {
        OriginCam.enabled = true;
        ChangeCam.enabled = false;
        ChangeCharacter.SetActive(false);
        OriginCharacter.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        OriginCam.enabled = false;
        ChangeCam.enabled = true;
        ChangeCharacter.SetActive(true);
        OriginCharacter.SetActive(false);
        Debug.Log("???");
    }

}
