using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 0;
    private AudioSource bucketPop;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        bucketPop = GetComponent<AudioSource>();
    }


    void Update()
    {
        MovePlayer();
    }




    private void MovePlayer()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector2(horizontal, 0) * speed * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -5.7f, 5.7f), transform.position.y);
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        bucketPop.Play();
    }
}
