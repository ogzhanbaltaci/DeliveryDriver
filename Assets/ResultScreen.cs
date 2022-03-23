using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ResultScreen : MonoBehaviour
{
        [SerializeField] TextMeshProUGUI ResultText; 
        
    void Update()
    {
        if(PackageCount.package==15 && CountdownTimer.currentTime>=0){
                        
            ResultText.text="Congrats! You collected all 15 packages within the time limit!              Press 'R' to restart";                       
            if(Input.GetKeyDown(KeyCode.R)){
                ResultText.text="";
                PackageCount.package=0;
                SceneManager.LoadScene(1);
            }

        }
        if(CountdownTimer.currentTime==0){
            ResultText.text="Time has ran out.         You lose.                                Press 'R to restart the game.";
            
            if(Input.GetKeyDown(KeyCode.R)){
                ResultText.text="";
                PackageCount.package=0;
                SceneManager.LoadScene(1);
        }
    }
}
}
