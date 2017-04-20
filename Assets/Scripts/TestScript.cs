using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
	
	private Rigidbody rb;

	void Start ()
	{
		rb = gameObject.GetComponent<Rigidbody>() ;
	}
	
	void FixedUpdate ()
	{
		rb.AddForce(0, 0, 2000 * Time.deltaTime);
	}
}
