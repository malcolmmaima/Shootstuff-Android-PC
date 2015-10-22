using UnityEngine;
using System.Collections;

public class WinPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Others){
		if(Others.tag == "WinPoint"){
			Application.LoadLevel("Stage2");
		}
	}
}
