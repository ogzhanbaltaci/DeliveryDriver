using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PackageCount : MonoBehaviour
{
    [SerializeField] Text packCount;
    public static int package=0;
    
    bool packInfo;
    private void OnTriggerEnter2D(Collider2D other){
        
        packInfo = GameObject.Find("PickUpCar").GetComponent<Delivery>().hasPackage;       
        if( this.tag=="Base" && packInfo){           
            package++;
            packCount.GetComponent<Text>().text=package.ToString();            
        }

    }
}
