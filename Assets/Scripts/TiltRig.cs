using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltRig : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.AngleAxis((float)(Input.GetAxis("Horizontal") * 10.0), Vector3.forward) *
            Quaternion.AngleAxis((float)(Input.GetAxis("Vertical") * -10.0), Vector3.right);

    }
}
