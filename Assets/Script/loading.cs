using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    float time, second;

    public Image FillImage;
    // Start is called before the first frame update
    void Start()
    {
        
      second = 5;
      Invoke("LoadApp",5f); 
    }

    // Update is called once per frame
    void Update()
    {
      if (time<5)
      {
        time += Time.deltaTime;
        FillImage.fillAmount= time/second;
      }  
    }

    public void LoadApp(){
      SceneManager.LoadScene(1);
}
}
