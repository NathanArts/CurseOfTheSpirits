using UnityEngine;
using System.Collections;

public class ProfBehaviour : MonoBehaviour {
    private static readonly int WALKING = 10;
    private static readonly int IDLE = 0;

    private Animator animator;
    private float speed;
    private int speedFactor;

    // Use this for initialization
    void Start () {
        this.animator = this.GetComponent<Animator>();
        this.speed = 0;
        this.speedFactor = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.DownArrow)) {
            animator.SetFloat("speed", 1.0f);
            animator.SetInteger("direction", 0);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            animator.SetFloat("speed", 1.0f);
            animator.SetInteger("direction", 1);
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            animator.SetFloat("speed", 1.0f);
            animator.SetInteger("direction", 2);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            animator.SetFloat("speed", 1.0f);
            animator.SetInteger("direction", 3);
        } else {
            animator.SetFloat("speed", 0.0f);
        }
    }

    void FixedUpdate() {
        bool keyDown = false;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            this.speedFactor = 2;
        } else {
            this.speedFactor = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            keyDown = true;
            this.speed = WALKING;
            Vector2 tf = transform.up * -1 * speed * speedFactor;
            GetComponent<Rigidbody2D>().AddForce(tf);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            keyDown = true;
            this.speed = WALKING;
            Vector2 tf = transform.right * -1 * speed * speedFactor;
            GetComponent<Rigidbody2D>().AddForce(tf);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            keyDown = true;
            this.speed = WALKING;
            Vector2 tf = transform.up * 1 * speed * speedFactor;
            GetComponent<Rigidbody2D>().AddForce(tf);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            keyDown = true;
            this.speed = WALKING;
            Vector2 tf = transform.right * 1 * speed * speedFactor;
            GetComponent<Rigidbody2D>().AddForce(tf);
        }
        if (!keyDown) {
            this.speed = IDLE;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
