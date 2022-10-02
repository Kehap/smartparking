using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMovement : MonoBehaviour
{

    public GameObject MenuOrigPos;
    public GameObject MenuActivePos;
     public  GameObject MenuPanel;
     public bool Move_Menu_Panel;
     public bool Move_Menu_Panel_Back;

    // Start is called before the first frame update
    void Start()
    {
       MenuPanel.transform.position = MenuOrigPos.transform.position;
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovePanel(){
Move_Menu_Panel= true;
Move_Menu_Panel_Back= false;

// Debug.Log(Move_Menu_Panel + "  " + Move_Menu_Panel_Back );

    }
      public void MovePanelBack(){
Move_Menu_Panel= false;
Move_Menu_Panel_Back= true;
// Debug.Log(Move_Menu_Panel_Back + "  " + Move_Menu_Panel );
    }
}
