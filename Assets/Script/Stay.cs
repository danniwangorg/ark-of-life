using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stay : MonoBehaviour
{
    public GameObject movePlatform;
    public float speed = 12f;
    Vector3 startPosition;

    void Start(){
        startPosition = movePlatform.transform.position;
    }

  

    private void OnTriggerStay()
    {
        movePlatform.transform.position += movePlatform.transform.up * Time.deltaTime * speed;
        if(movePlatform.transform.position.y >= 60.0f){
            speed = 0;
        }
    }

    private void OnTriggerExit()
    {
        movePlatform.transform.position = startPosition;
    }


}
