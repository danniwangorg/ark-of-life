using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMove : MonoBehaviour
{
    public GameObject movePlatform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay()
    {
    movePlatform.transform.position += movePlatform.transform.up * Time.deltaTime;
    }
}
