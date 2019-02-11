using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        Physics.gravity = Quaternion.AngleAxis((float)(Input.GetAxis("Horizontal") * 60.0), Vector3.forward) *
            Quaternion.AngleAxis((float)(Input.GetAxis("Vertical") * -60.0), Vector3.right) *
            (Vector3.up * -20);

    }
}
