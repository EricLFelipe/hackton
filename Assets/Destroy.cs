using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	
	GameObject obj1,obj2,obj3,obj4;

	// Use this for initialization
	void Start () {
		
		obj1 = GameObject.Find("User");
		obj2 = GameObject.Find("Habilitados");
		obj3 = GameObject.Find("Respostas");
		obj4 = GameObject.Find("PF1");
		Destroy(obj1);
		Destroy(obj2);
		Destroy(obj3);
		Destroy(obj4);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
