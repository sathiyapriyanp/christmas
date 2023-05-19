using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {

    }
    
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            UIManager.instance.UpdateScore();
        }
        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            UIManager.instance.UpdateLife();
        }
    }
}
