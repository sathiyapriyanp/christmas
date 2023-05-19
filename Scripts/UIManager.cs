using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Sprite[] lifeSprites;
    public Image lifeImage;
    private int life = 3;
    private int score = 0, high_Score;

    public Text scoreText;
    public Text yourScore;
    public Text highScore;
    public GameObject mainScreen;
    public GameObject exitScreen;
    public GameObject bucket;
    public GameObject sound_On;
    public GameObject sound_Off;
    public static UIManager instance;
    public AudioSource mainSound;
    public ExitScreen es;




    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
            
        mainSound = GetComponent<AudioSource>();

        high_Score = PlayerPrefs.GetInt("HighScore", 0);

        exitScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HighScore();
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = "Balls:" + score.ToString();

    }
    public void Retry()
    {
        SceneManager.LoadScene(1);


    }
    public void Exit()
    {
        Application.Quit();
    }
    public void HighScore()
    {
        if (score > high_Score)
        {
            high_Score = score;
            PlayerPrefs.SetInt("HighScore", high_Score);
            highScore.text = "HighScore:" + PlayerPrefs.GetInt("HighScore", 0);


        }
    }
    public void UpdateLife()
    {




        if (life == 0)
        {

            mainScreen.SetActive(false);
            bucket.SetActive(false);
            exitScreen.SetActive(true);

            yourScore.text = "Your Score: " + score.ToString();


        }
        else
        {
            life--;

            lifeImage.sprite = lifeSprites[life];
        }
    }
    public void SoundOn()
    {
        sound_Off.gameObject.SetActive(true);
        sound_On.gameObject.SetActive(false);
        mainSound.Pause();

    }
    public void SoundOff()
    {
        sound_On.gameObject.SetActive(true);
        sound_Off.gameObject.SetActive(false);
        mainSound.Play();
    }

}
