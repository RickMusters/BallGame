using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float speed;
	
	void FixedUpdate(){
		float horizontalmovement = Input.GetAxis("Horizontal");
		float verticalmovement = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(horizontalmovement,0.0f,verticalmovement);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
		
	}
	
}
