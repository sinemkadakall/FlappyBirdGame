using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public bool isDead;

    public float velocity = 3f;
    private Rigidbody2D rb;

    public GameManager manager;

    public GameObject deathScreen;


    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

   
    void Update()
    {

        //Týklamayý alma
        if(Input.GetMouseButtonDown(0))
        {
            //Havada kuþu sýçratma
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            manager.updateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            deathScreen.SetActive(true);
        }
    }
}
