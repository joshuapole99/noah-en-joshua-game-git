using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float speed;
    public float jumpHeight;
    public Rigidbody2D rb;

    public bool grounded;
    public LayerMask WhatIsGround;
	
    private Collider2D Mycollider;

    AudioSource audiosource;
    
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
        audiosource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(Mycollider, WhatIsGround);


        transform.Translate(speed, 0, 0 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
                audiosource.Play();
            }
            
            
        }
	}


}
