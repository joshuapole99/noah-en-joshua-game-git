using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mailbox : MonoBehaviour {


    AudioSource audiosource;

    void start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    // Use this for initialization
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mailbox")
        {
            audiosource.Play();
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
