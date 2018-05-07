using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE : MonoBehaviour {
	public float distToGround = 0.5f;
	public float speed = 10f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		transform.Translate (Input.GetAxis ("Horizontal")*Time.deltaTime,0f,Input.GetAxis ("Vertical")*Time.deltaTime);


	}

	void Fixedupdate () {
		Debug.Log (Physics.Raycast (transform.position, Vector3.down, distToGround));


	}
}
