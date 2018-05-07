using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollo : MonoBehaviour {
	public Transform playertransform;

	private Vector3 _cameraoffset;

	[Range(0.1f, 1.0f)]
	public float smootherfactor =0.5f;


	// Use this for initialization

		void Start () {
		_cameraoffset = transform.position - playertransform.position;


	}
	
	// lateupdate is called after update methods

		void LateUpdate () {
		Vector3 newpos = playertransform.position + _cameraoffset;

		transform.position = Vector3.Slerp (transform.position, newpos, smootherfactor);

	}
}
