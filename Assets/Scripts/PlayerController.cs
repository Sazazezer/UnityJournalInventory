﻿using System.Collections;
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
    public bool inJournal = false;
    public bool inBag = false;

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
            GoToJournal();
        }

        if (Input.GetButtonDown("Fire3")){
            GameObject.FindObjectOfType<JournalList>().ResetJournals();
            GoToBag();
        }
        if (Input.GetButtonDown("Cancel")){
            BackToGame();
        }
//activates old inventory. Keeping separate for the moment
     /*   if (Input.GetButtonDown("Fire2")){
            if (bag.GetComponent<Canvas> ().enabled == false){
                bag.GetComponent<Canvas> ().enabled = true;
                Time.timeScale = 0f;

                } else {
                    bag.GetComponent<Canvas> ().enabled = false;
                    Time.timeScale = 1f;
                }
        }*/
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    public void GoToJournal() {
        if (inJournal == false){
            BackToGame();
            GameObject.FindObjectOfType<JournalCanvas>().Activate();
            Time.timeScale = 0f;
            Debug.Log("Into journal");
            inJournal = true;
        } else {
            BackToGame();
            GameObject.FindObjectOfType<JournalCanvas>().Deactivate();
            Time.timeScale = 1f;
            Debug.Log("Leave journal");
            inJournal = false;
        }

    }

    public void GoToBag() {
        if (inBag == false){
            BackToGame();
            GameObject.FindObjectOfType<Bag>().Activate();
            Time.timeScale = 0f;
            Debug.Log("Into Bag");
            inBag = true;
        } else {
            BackToGame();
            GameObject.FindObjectOfType<Bag>().Deactivate();
            Time.timeScale = 1f;
            Debug.Log("Leave Bag");
            inBag = false;
        }

    }

    public void BackToGame() {
        GameObject.FindObjectOfType<Bag>().Deactivate();
        inJournal = false;
        GameObject.FindObjectOfType<JournalCanvas>().Deactivate();
        inBag = false;
        Time.timeScale = 1f; 
    }
}
