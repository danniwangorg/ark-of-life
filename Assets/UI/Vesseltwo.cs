using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vesseltwo : MonoBehaviour
{
    public GameObject vesseltwo;
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
        vesseltwo.SetActive(false);
    }
}