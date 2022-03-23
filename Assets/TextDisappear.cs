using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisappear : MonoBehaviour
{
    [SerializeField] Text TextOut;   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){          
            TextOut.enabled=false;
        }
    }
}
