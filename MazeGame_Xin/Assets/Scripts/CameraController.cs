using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// store a public reference to the Player game object, so we can refer to it's Transform
	public GameObject player;

	// Store a Vector3 offset from the player (a distance to place the camera from the player at all times)
	private Vector3 offset;
    
    public float sensitivity = 10f;

	// At the start of the game..
	void Start ()
	{
		// Create an offset by subtracting the Camera's position from the player's position
		offset = transform.position - player.transform.position;
	}
    
         void Update ()
     {
         var c = Camera.main.transform;
         c.Rotate(0, Input.GetAxis("Mouse X")* sensitivity, 0);
         c.Rotate(-Input.GetAxis("Mouse Y")* sensitivity, 0, 0);
         c.Rotate(0, 0, -Input.GetAxis("QandE")*90 * Time.deltaTime);
         if (Input.GetMouseButtonDown(0))
             Cursor.lockState = CursorLockMode.Locked;
             
        Vector3 playerPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
             transform.LookAt(playerPosition);
     }
    
         // Update is called once per frame
     void FixedUpdate () {
         float x = 5 * Input.GetAxis ("Mouse X");
         float y = 5 * -Input.GetAxis ("Mouse Y");
         Camera.main.transform.Rotate (x, y, 0);
  // declare the RaycastHit variable
     
     }

	// After the standard 'Update()' loop runs, and just before each frame is rendered..
	void LateUpdate ()
	{
		// Set the position of the Camera (the game object this script is attached to)
		// to the player's position, plus the offset amount
		transform.position = player.transform.position + offset;
	}
}
