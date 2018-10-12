using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	[SerializeField]
	float Horizontal;
	[SerializeField]
	float Vertical;
	[SerializeField]
	float ScrollWheel;

	float movementSpeed = 10;
	float zoomSpeed = 20;
	float zoomMovement = 0;
	float zoomDecrement = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vertical = Input.GetAxis("Vertical");
		Horizontal = Input.GetAxis("Horizontal");
		ScrollWheel = Input.GetAxis("Mouse ScrollWheel");

		// Zoom-In
		if(Input.GetAxis("Mouse ScrollWheel") > 0){
			gameObject.transform.Translate((Vector3.forward * Time.deltaTime) * zoomSpeed);
		}
		// Zoom-Out
		if(Input.GetAxis("Mouse ScrollWheel") < 0){
			gameObject.transform.Translate((Vector3.back * Time.deltaTime) * zoomSpeed);
		}

		// Up
		if(Input.GetAxisRaw("Vertical") > 0){
			gameObject.transform.Translate((Vector3.up * Time.deltaTime) * movementSpeed);
		}
		// Down
		if (Input.GetAxisRaw("Vertical") < 0){
			gameObject.transform.Translate((Vector3.down * Time.deltaTime) * movementSpeed);
		}
		// Right
		if(Input.GetAxisRaw("Horizontal") > 0){
			gameObject.transform.Translate((Vector3.right * Time.deltaTime) * movementSpeed);
		}
		// Left
		if(Input.GetAxisRaw("Horizontal") < 0){
			gameObject.transform.Translate((Vector3.left * Time.deltaTime) * movementSpeed);
		}
	}
}
