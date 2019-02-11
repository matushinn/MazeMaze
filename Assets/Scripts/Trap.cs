using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //当たり判定
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball"){
            var respawn = GameObject.FindWithTag("Respawn");
            other.gameObject.transform.position = respawn.transform.position;

            Debug.Log("リスタート");
        }
        
    }
}
