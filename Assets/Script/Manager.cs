using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public GameObject shape;

    GameObject Container;

    void Start()
    {
        Container = GameObject.Find("Container");
    }

    void Update()
    {

    }

    public void ToggleCube(){
        GameObject go = Instantiate(shape,new Vector3(17,1,-17),Quaternion.identity);
        go.transform.SetParent(Container.transform);
    }
}
