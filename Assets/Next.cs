using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {
	
		GameObject go;
		PontosFase2 f2script;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Next1 () {
		
			go = GameObject.Find("Proxima");	
			f2script = go.GetComponent<PontosFase2>();
			f2script.Verifica ();
		
	}
}
