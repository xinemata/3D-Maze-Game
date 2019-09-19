using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
  public GameObject player;
  public float cameraHeight = -2.0f;
  public float cameraBack = 1.0f;
  
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     Vector3 pos = player.transform.position;
     
     pos.z += cameraHeight;
     pos.y += cameraBack;
     
     transform.position = pos;
    }
}
