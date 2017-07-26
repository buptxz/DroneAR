using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GateTrigger : MonoBehaviour {
	public Text timeText;

	private bool isPassed = false;
	private float startTime;			//场景加载的时刻
	private float currentTime;			//从场景加载到现在所花的时间
	public int value = 1;	// Score per collision

//	void OnTriggerEnter (Collider other)
//	{
//		Debug.Log ("Object entered");
//	}
//
//	void OnTriggerStay (Collider other)
//	{
//		Debug.Log ("Object stayed");
//	}

	void OnTriggerExit (Collider other)
	{
		if (isPassed == false) {
			isPassed = true;
			Debug.Log ("Object exit");
			timeText.text = currentTime.ToString ("0.00");
			GameManager.gm.AddScore (value);
		}
	}

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime = Time.time - startTime;
	}
}
