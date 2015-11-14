using UnityEngine;
using UnityEngine.VR;
using System.Collections;

public class RiftRecenter : MonoBehaviour 
{
	
	void Start () 
	{
	
	}

	void Update () 
	{
		if (Input.GetKeyDown("space"))
			InputTracking.Recenter();
	}
}
