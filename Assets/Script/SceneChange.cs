using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  SceneChange : MonoBehaviour
{
     private int nextSceneToLoad;
    private int previousSceneToLoad;
    // Start is called before the first frame update
     private void Start()
    {
     nextSceneToLoad= SceneManager.GetActiveScene().buildIndex +1;
    previousSceneToLoad= SceneManager.GetActiveScene().buildIndex -1;   
    }

    // Update is called once per frame
   
     public void NextScene(){
        Time.timeScale = 1;
        SceneManager.LoadScene(nextSceneToLoad);
    }
    public void PreviousScene(){
        Time.timeScale = 1;
        SceneManager.LoadScene(previousSceneToLoad);
    }
    public void ChangeScene(int index){
        Time.timeScale = 1;
        SceneManager.LoadScene(index);

    }
}
