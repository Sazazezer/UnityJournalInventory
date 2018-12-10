using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


    public float health;
    public Text healthDisplay;

    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 moveVelocity;
    public Canvas bag;
    public Canvas journal;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        bag.GetComponent<Canvas> ().enabled = false;
        journal.GetComponent<Canvas> ().enabled = false;
    }

    private void Update()
    {

        healthDisplay.text = health.ToString();

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (moveInput != Vector2.zero)
        {
            anim.SetBool("isRunning", true);
        }
        else {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Fire2")){
            if (bag.GetComponent<Canvas> ().enabled == false){
                bag.GetComponent<Canvas> ().enabled = true;
                Time.timeScale = 0f;

                } else {
                    bag.GetComponent<Canvas> ().enabled = false;
                    Time.timeScale = 1f;
                }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
