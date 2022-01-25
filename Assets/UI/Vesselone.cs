using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vesselone : MonoBehaviour
{
    public GameObject vesselone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkClick(){
        Debug.Log("1");
        vesselone.SetActive(false);
    }
}