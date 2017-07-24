using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TestColliderAsTrigger : MonoBehaviour {
	public Text timeText;

	private float startTime;			//场景加载的时刻
	private float currentTime;			//从场景加载到现在所花的时间

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
		Debug.Log ("Object exit");
		timeText.text = currentTime.ToString ("0.00");
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		currentTime = Time.time - startTime;
	}
}
