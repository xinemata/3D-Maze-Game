using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchDemo : MonoBehaviour
{

    public Light myLight;
    
    void Update(){
    
        if (Input.GetKey ("space")){
            myLight.enabled = true;
        } else {
            myLight.enabled = false;
        }
        
    }

}











//Demos

//Use up & down keys to turn light on and off
//        if (Input.GetKey ("up")){
//            myLight.enabled = true;
//        } 
//            if (Input.GetKey ("down")){
//            myLight.enabled = false;
//        }

//Make light stay by using GetKeyDown or GeyKeyUp
//using UnityEngine;
//using System.Collections;
//
//public class DemoScript : MonoBehaviour {
//
//    public Light myLight;
//
//    void Update () {
//        if (Input.GetKeyDown ("space")) {
//            myLight.enabled = true;
//        }
//
//        if (Input.GetKeyUp ("space")) {
//            myLight.enabled = false;
//        }
//    }
//}

//Create a toggle using =!
//using UnityEngine;
//using System.Collections;
//
//public class DemoScript : MonoBehaviour {
//
//    public Light myLight;
//
//    void Update () {
//        if (Input.GetKeyDown ("space")) {
//            myLight.enabled = !myLight.enabled;
//        }
//    }
//}

