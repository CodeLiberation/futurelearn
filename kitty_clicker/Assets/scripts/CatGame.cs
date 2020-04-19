using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatGame : MonoBehaviour
{
    public GameObject cat;
    public GameObject scoreBar;

    private int happyCatScore = 5;
    public GameObject timerBar;
    private float playTime = 5.0f;
    private bool gameRunning = true;
    private float startTime = 0.0f;


    //short cuts 
    public Button playBtn; 
    public GameObject GameOverText;
    private Animator catAnim;
    private Text gameText;

    void Start()
    {
        startTime = Time.time;
        playBtn.gameObject.SetActive(false);
        catAnim = cat.GetComponent<Animator>();
        gameText = GameOverText.GetComponent<Text>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunning && Time.time > startTime + playTime)
        {
                gameRunning = false;
            if (cat.GetComponent<ScoreKeeper>().score > happyCatScore)
            {
       
                gameText.text = "you win";
                catAnim.SetTrigger("StartHappy");
            }
            else {
                gameText.text = "you lose";
            } 

            playBtn.gameObject.SetActive(true); 
            gameObject.SetActive(false); 
            }
        else {
           
            float timeLeft = startTime - Time.time + playTime;
            Debug.Log(timeLeft*160);
            scoreBar.GetComponent<Text>().text = "Score: "+ cat.GetComponent<ScoreKeeper>().score.ToString();
            timerBar.GetComponent<RectTransform>().sizeDelta = new Vector2(timeLeft * 160.0f, 10.0f);       
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit(); 
        }

    }

    public void ReplayGame() {

        catAnim.SetTrigger("ReverseCat");
        startTime = Time.time;
        gameRunning = true;
        gameObject.SetActive(true);
        cat.GetComponent<ScoreKeeper>().score = 0;
        gameText.text = "";
        playBtn.gameObject.SetActive(false);
    }


    public void quitGame() {

    }
}


