using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameoverControl : MonoBehaviour {

	public Text score;
	// Use this for initialization
	void Start()
	{
		score.text = Data.Score.ToString();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Ulangi()
	{ 
		Data.Score = 0;
		SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
	}
	public void Home()
	{
		Data.Score = 0;
		SceneManager.LoadScene ("Home", LoadSceneMode.Single);
	}
}