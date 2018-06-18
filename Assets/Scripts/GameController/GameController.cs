using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour 
{
	public static GameController instance;         //A reference to our game control script so we can access it statically.
	public Text scoreText;                      //A reference to the UI text component that displays the player's score.
	public GameObject gameOvertext;             //A reference to the object that displays the text which appears when the player dies.
	private int lifeNave = 50;
	private int scoreNave = 0;                      //The player's score.
	public bool diedNave = false;
	private int lifeBigBoss= 60;
	public bool diedBigBoss = false;
	public bool gameOver = false;               //Is the game over?
	public float scrollSpeed = -1.5f;


	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void Update()
	{
		if (gameOver && Input.GetMouseButtonDown(0)) 
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void NaveScored(int score)
	{
		if (gameOver)   
			return;
		scoreNave+=score;
		scoreText.text = "Score: " + scoreNave.ToString();
	}
	public void DyingNave(int scoreDie){
		lifeNave -= scoreDie;
	}
	public void DyingBigboss(int scoreDie){
		lifeBigBoss -= scoreDie;
	}
	public void DiedBigBoss(){
		if(lifeBigBoss == 0){
			diedBigBoss = true;
		}
	}
	public void NaveDied()
	{
		//Activate the game over text.
		gameOvertext.SetActive (true);
		//Set the game to be over.
		gameOver = true;
	}

}