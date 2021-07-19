using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public GameObject cam;

	private void Start()
	{
		cam = GameObject.FindWithTag("MainCamera");
	}

	private void LateUpdate()
	{
		//transform.forward = new Vector3(cam.transform.forward.x, transform.forward.y, cam.transform.forward.z);

		// transform.LookAt(transform.position + cam.transform.forward, Vector3.up);

		transform.LookAt(cam.transform.position, Vector3.up);
	}
}
