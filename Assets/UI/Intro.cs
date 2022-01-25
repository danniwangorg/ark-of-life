using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Intro : MonoBehaviour
{
    public GameObject intro;
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
        intro.SetActive(false);
    }

    
}

