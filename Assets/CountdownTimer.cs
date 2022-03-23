using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static float currentTime;  
    bool finish;
    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime=120f;
        countdownText.enabled=true;   
    } 
    void Update()
    {                 
      if(currentTime<=179){
            currentTime-=1*Time.deltaTime;
            countdownText.text= currentTime.ToString("00");
                if(PackageCount.package==15 && CountdownTimer.currentTime>=0){
                    countdownText.enabled=false;  
                    currentTime=10000000f;                 
                }
                    if(currentTime<=0){
                        currentTime=0;                      
                    }
                }                                        
    }
}
