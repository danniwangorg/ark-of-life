using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTarget : MonoBehaviour
{
    private Renderer renderer;
    public GameObject TheTree;
    public Color ChangeColor;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        TheTree.SetActive(false);  
    }

        private void OnMouseOver()
        {
        renderer.material.color = ChangeColor;
    }

    private void OnMouseDown(){
        TheTree.SetActive(true); 
        audio.Play(); 
    }

    private void OnMouseExit(){
        renderer.material.color = Color.white; 
    }

}
