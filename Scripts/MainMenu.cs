using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject main_Menu;
    
    public GameObject splash_Screen;


    public AudioSource music;





    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SplashScreen());




    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();

    }


    IEnumerator SplashScreen()
    {
        splash_Screen.gameObject.SetActive(true);
        main_Menu.gameObject.SetActive(false);

        music.Stop();
        yield return new WaitForSeconds(2f);
        music.Play();
        splash_Screen.SetActive(false);
        main_Menu.gameObject.SetActive(true);
    }
}
