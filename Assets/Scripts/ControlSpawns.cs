using UnityEngine;

public class ControlSpawns: MonoBehaviour {

	public GameObject spown1;
	public GameObject spown2;
	public GameObject spown3;
	public GameObject spown4;

	float waitShow1 = 0;
	float waitShow2 = 0;
	float waitShow3 = 0;
	float waitShow4 = 0;

	float timer1;
	float timer2;
	float timer3;
	float timer4;

	public GameObject[] ob;

	// Use this for initialization
	void Start () {
		waitShow1 = Random.Range(0f, 3f);
		waitShow2 = Random.Range(0f, 3f);
		waitShow3 = Random.Range(0f, 3f);
		waitShow4 = Random.Range(0f, 3f);
	}

	// Update is called once per frame
	void Update () {

		timer1 += Time.deltaTime;
		timer2 += Time.deltaTime;
		timer3 += Time.deltaTime;
		timer4 += Time.deltaTime;

		if (timer1 > waitShow1)
		{

			GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spown1.transform.position, spown1.transform.rotation);
			waitShow1 = Random.Range(4f, 7f);
			timer1 = 0;
		}

		if (timer2 > waitShow2)
		{
			GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spown2.transform.position, spown2.transform.rotation);
			waitShow2 = Random.Range(4f, 7f);
			timer2 = 0;
		}

		if (timer3 > waitShow3)
		{
			GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spown3.transform.position, spown3.transform.rotation);
			waitShow3 = Random.Range(4f, 7f);
			timer3 = 0;
		}

		if (timer4 > waitShow4)
		{
			GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spown4.transform.position, spown4.transform.rotation);
			waitShow4 = Random.Range(4f, 7f);
			timer4 = 0;
		}      
	}
}