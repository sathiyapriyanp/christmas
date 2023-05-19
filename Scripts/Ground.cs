using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private AudioSource ballFall;
    // Start is called before the first frame update
    void Start()
    {
        ballFall = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        ballFall.Play();
    }
}
