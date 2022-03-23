using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManager : MonoBehaviour
{
    public static AudioClip packageSound, deliverySound, boostSound;
    static AudioSource audioSource;
    void Start()
    {
        packageSound=Resources.Load<AudioClip> ("packageSound");
        deliverySound=Resources.Load<AudioClip> ("deliverySound");
        boostSound=Resources.Load<AudioClip> ("boostSound");
        audioSource=GetComponent<AudioSource>();
    }  
    public static void PlaySound (string clip){
        switch(clip){
            case "packageSound":
            audioSource.PlayOneShot (packageSound);
            break;
            case "deliverySound":
            audioSource.PlayOneShot (deliverySound);
            break;
            case "boostSound":
            audioSource.PlayOneShot (boostSound);
            break;
        }
    }
}
