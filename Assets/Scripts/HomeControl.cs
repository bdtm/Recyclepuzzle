using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Home()
	{
		SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);	
	}
	public void Exit()
	{
		Application.Quit ();
	}
}
	