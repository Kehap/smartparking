using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMovement : MonoBehaviour
{

    public GameObject MenuOrigPos;
    public GameObject MenuActivePos;
     public GameObject MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
       MenuPanel.transform.position = MenuOrigPos.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
