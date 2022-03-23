using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed=0.1f;
    [SerializeField]float moveSpeed=0.01f;
    [SerializeField]float slowSpeed=5f;
    [SerializeField]float fastSpeed=15f;
    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveSpeedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveSpeedAmount,0);       
    }
     void OnCollisionEnter2D(Collision2D other) {
         moveSpeed=slowSpeed;
        
    }
     void OnTriggerEnter2D(Collider2D other){
            if(other.tag=="speedUp"){
                moveSpeed=fastSpeed;
                AudioSourceManager.PlaySound ("boostSound");
            }

            
        }
}
