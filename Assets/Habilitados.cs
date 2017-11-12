using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Habilitados : MonoBehaviour {
	
	GameObject go;
	GameObject eua;
	GameObject suica;
	GameObject australia;
	GameObject alemanha;
	GameObject brasil;
	GameObject fase2;
	User userscript;
	public char inicial;
	public char p1='0';
	public char p2='0';
	public char p3='0';
	public char p4='0';
	public char p5='0';
	public char f2='0';

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
			go = GameObject.Find("User");	
			userscript = go.GetComponent<User>();
			string s = userscript.usuario;
			inicial = s[6];
			

switch (inicial)
{
    case '1':
        p1='1';
        break;
    case '2':
        p2='1';
        break;
	case '3':
        p3='1';
        break;
	case '4':
        p4='1';
        break;
	case '5':
        p5='1';
        break;
    default:
        break;
}
		
		if (p1=='0')
		{
			eua = GameObject.FindWithTag("eua");
			if (eua!=null)eua.GetComponent<Button>().interactable = false; 
		}
		else
		{
            eua = GameObject.FindWithTag("eua");
			if (eua!=null)eua.GetComponent<Button>().interactable = true; 
		}
		
		
				if (p2=='0')
		{
			suica = GameObject.FindWithTag("suica");
			if (suica!=null)suica.GetComponent<Button>().interactable = false; 
		}
		else
		{
			suica = GameObject.FindWithTag("suica");
			if (suica!=null)suica.GetComponent<Button>().interactable = true; 
		}
		
		
				if (p3=='0')
		{
			australia = GameObject.FindWithTag("australia");
			if (australia!=null)australia.GetComponent<Button>().interactable = false; 
		}
		else
		{
			australia = GameObject.FindWithTag("australia");
			if (australia!=null)australia.GetComponent<Button>().interactable = true; 
		}
		
		
				if (p4=='0')
		{
			alemanha = GameObject.FindWithTag("alemanha");
			if (alemanha!=null)alemanha.GetComponent<Button>().interactable = false; 
		}
		else
		{
			alemanha = GameObject.FindWithTag("alemanha");
			if (alemanha!=null)alemanha.GetComponent<Button>().interactable = true; 
		}
		
		
				if (p5=='0')
		{
			brasil = GameObject.FindWithTag("brasil");
			if (brasil!=null)brasil.GetComponent<Button>().interactable = false; 
		}
		else
		{
			brasil = GameObject.FindWithTag("brasil");
			if (brasil!=null)brasil.GetComponent<Button>().interactable = true; 
		}
		
//fase2

				if (p1=='1'&& p2=='1'&&p3=='1'&& p4=='1'&&p5=='1')
		{
			fase2 = GameObject.FindWithTag("fase2");
			if (fase2!=null)fase2.GetComponent<Button>().interactable = true; 
		}
		else
		{
			fase2 = GameObject.FindWithTag("fase2");
		    if (fase2!=null)fase2.GetComponent<Button>().interactable = false; 
		}		
		

		
	}
}

