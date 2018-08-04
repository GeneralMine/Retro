using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public static PlayerMovement instance;

    //Rigidbody2D rigidbody;
    float speed = 200f;
    Vector2 movement;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        //rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        transform.Translate(movement.x, 0, movement.y);
    }
}
