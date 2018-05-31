using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour {
    public Transform particleObjs;
    bool key = true;
    // Use this for initialization

    private void OnCollisionEnter(Collision collision)
    {
        if (key)
        {
            particleObjs.GetComponent<ParticleSystem>().Play(true);


            key = false;
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
