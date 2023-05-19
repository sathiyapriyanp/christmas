using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScreen : MonoBehaviour
{
    private AudioSource gameOver;
    public GameObject boomPrefab;

    public GameObject volume;



    // Start is called before the first frame update
    void Start()
    {
        volume.gameObject.SetActive(false);
        gameOver = GetComponent<AudioSource>();


        gameOver.Play();
        Boom();




    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Boom()
    {
        Instantiate(boomPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
