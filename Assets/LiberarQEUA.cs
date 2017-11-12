using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiberarQEUA : MonoBehaviour {
	
	GameObject go;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Libera()
	{
		go = GameObject.Find("Canvas/InputField/Text");
		string verifica = go.GetComponent<UnityEngine.UI.Text>().text;
		if (verifica=="123")
			Application.LoadLevel("EUA1");
	}
}
