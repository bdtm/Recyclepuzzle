using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BoxTrash : MonoBehaviour {
	public AudioClip audioCorrent;
	public AudioClip audioWrong;
	private AudioSource asCorrent;
	private AudioSource asWrong;

	[SerializeField]
	private Text txScore;
	public GameObject detect;

	// Use this for initialization
	void Start()
	{
		asCorrent = gameObject.AddComponent<AudioSource>();
		asCorrent.clip = audioCorrent;

		asWrong = gameObject.AddComponent<AudioSource>();
		asWrong.clip = audioWrong;
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerStay2D(Collider2D collider)
	{

		if (!Input.GetMouseButton(0))
		{

			Destroy(collider.gameObject);
			Debug.Log(" c " + collider.name + " & " + detect.name);

			if (collider.name.Contains(detect.name))
			{
				Data.Score += 10;
				txScore.text = Data.Score.ToString();
				asCorrent.Play();
			}
			else
			{
				asWrong.Play();
				SceneManager.LoadScene ("Gameover", LoadSceneMode.Single);

			}
		}        
	}
}