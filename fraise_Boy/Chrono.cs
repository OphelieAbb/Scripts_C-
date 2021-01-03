using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chrono : MonoBehaviour
{
	
	private int bestScore =600;
	private int chrono=0;


	private float minutes;
	private float secondes;
	private float fraction;
	public Text chronoUI;
   
    

    public string bestScoreString;

    public float delay;
    

    void SetScoreToText()
	{
        chronoUI.text = "chrono : " + chrono.ToString();
	}
	void SetBestScore()
	{
		PlayerPrefs.SetInt("bestScore", chrono);
	}
    void Awake()
    {
        

        PlayerPrefs.SetInt("bestScore", 600);
        chrono = (int)delay;


        if (bestScore >= 0f)
        {
            minutes = (int)(chrono / 60f);
            secondes = (int)(chrono % 60f);
            fraction = (int)((chrono * 100f) % 100f);
        }

        bestScoreString = "Best : " + minutes + ":" + secondes + ":" + fraction;

    }
    // Start is called before the first frame update
    void Start()
	{
		if (PlayerPrefs.HasKey("bestScore") == true)
		{
			bestScore = PlayerPrefs.GetInt("bestScore");
		}
		else
		{
			PlayerPrefs.SetInt("bestScore", 0);
			bestScore = 0;
		}
	}

	
    // Update is called once per frame
    
	void Update()
	{
		chrono += (int)Time.deltaTime;
        
        if (chrono >= 0f)
        {
            minutes = (int)(chrono / 60f);
            secondes = (int)(chrono % 60f);
            fraction = (int)((chrono * 100f) % 100f);

        }

		chronoUI.text = bestScoreString + "\n" + "Temps : " + minutes + ":" + secondes + ":" + fraction;
	}

    void End() 
    {
        if (chrono < bestScore)
        {

            PlayerPrefs.SetInt("bestScore",0);
            bestScore = (int)chrono;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
