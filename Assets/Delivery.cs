using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    [SerializeField] float destroyDelay=0.4f;         
    public bool hasPackage; 
    SpriteRenderer spriteRenderer;
    void Start() {
      spriteRenderer = GetComponent<SpriteRenderer>();  
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Package" && !hasPackage){ 

            Debug.Log("Package picked up");
            hasPackage=true;
            spriteRenderer.color=hasPackageColor;
            Destroy(other.gameObject , destroyDelay);
            if(CountdownTimer.currentTime>0)
                CountdownTimer.currentTime+=5f;
            AudioSourceManager.PlaySound ("packageSound");                   
        }
        if(other.tag=="Base" && hasPackage){

            Debug.Log("Package delivered");
            hasPackage=false;
            spriteRenderer.color=noPackageColor;
            AudioSourceManager.PlaySound ("deliverySound");                               
        }              
    }

    public bool getHasPackage(){
        return hasPackage;
    }
    
    
}
