using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
             SceneManager.LoadScene(1);   
        }
    }
}
