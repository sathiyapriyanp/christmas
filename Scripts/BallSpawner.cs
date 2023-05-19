using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public GameObject bomb;
    public GameObject pizza;
    public AudioSource bombSound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BalSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {

            Destroy(gameObject);
            bombSound.Play();

        }
    }
    IEnumerator BalSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Vector3 pos = new Vector3(Random.Range(-8f, 8f), 5.50f, 0);
            Instantiate(ball, pos, Quaternion.identity);
            Vector3 pos1 = new Vector3(Random.Range(-8f, 8f), 8, 0);
            Instantiate(bomb, pos1, Quaternion.identity);
            Vector3 pos2 = new Vector3(Random.Range(-9f, 9f), 11, 0);
            Instantiate(pizza, pos2, Quaternion.identity);
        }
    }
}
