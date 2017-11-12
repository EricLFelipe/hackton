using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Salvar : MonoBehaviour {

    Habilitados hscript;
	GameObject go;
    string a;
	Respostas resp;
	ToggleGroup toggleGroup;
	GameObject a17;
	GameObject b17;
	GameObject c17;
	GameObject d17;
	GameObject e17;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Salvar1()
	{
		
		 toggleGroup = GameObject.Find("Canvas/Toggles").GetComponent<ToggleGroup>();
		 a = toggleGroup.ActiveToggles().FirstOrDefault().ToString();
		 resp = GameObject.Find("Respostas").GetComponent<Respostas>();
		 		 
		 //start-brasil
		if(Application.loadedLevelName == "Brasil1")
		{
			if(resp!=null)resp.questao17=a[0];
			Application.LoadLevel("Brasil2");
		}
		
		if(Application.loadedLevelName == "Brasil2")
		{
			if(resp!=null)resp.questao18=a[0];
			Application.LoadLevel("Brasil3");
		}
		
		if(Application.loadedLevelName == "Brasil3")
		{
			if(resp!=null)resp.questao19=a[0];
			Application.LoadLevel("Brasil4");
		}
		
		if(Application.loadedLevelName == "Brasil4")
		{
			if(resp!=null)resp.questao20=a[0];
			go = GameObject.Find("Habilitados");	
			hscript = go.GetComponent<Habilitados>();
			hscript.p1='1';
			Application.LoadLevel("Rally1");
		}
		//end-brasil
		
		//start-eua
		
		if(Application.loadedLevelName == "EUA1")
		{
			if(resp!=null)resp.questao1=a[0];
			Application.LoadLevel("EUA2");
		}
		
		if(Application.loadedLevelName == "EUA2")
		{
			if(resp!=null)resp.questao2=a[0];
			Application.LoadLevel("EUA3");
		}
		
		if(Application.loadedLevelName == "EUA3")
		{
			if(resp!=null)resp.questao3=a[0];
			Application.LoadLevel("EUA4");
		}
		
		if(Application.loadedLevelName == "EUA4")
		{
			if(resp!=null)resp.questao4=a[0];
			go = GameObject.Find("Habilitados");	
			hscript = go.GetComponent<Habilitados>();
			hscript.p2='1';
			Application.LoadLevel("Rally1");
		}
		//suica
		
		if(Application.loadedLevelName == "Suica1")
		{
			if(resp!=null)resp.questao5=a[0];
			Application.LoadLevel("Suica2");
		}
		
		if(Application.loadedLevelName == "Suica2")
		{
			if(resp!=null)resp.questao6=a[0];
			Application.LoadLevel("Suica3");
		}
		
		if(Application.loadedLevelName == "Suica3")
		{
			if(resp!=null)resp.questao7=a[0];
			Application.LoadLevel("Suica4");
		}
		
		if(Application.loadedLevelName == "Suica4")
		{
			if(resp!=null)resp.questao8=a[0];
			go = GameObject.Find("Habilitados");	
			hscript = go.GetComponent<Habilitados>();
			hscript.p3='1';
			Application.LoadLevel("Rally1");
		}
		//suica
		//australia
		if(Application.loadedLevelName == "Australia1")
		{
			if(resp!=null)resp.questao9=a[0];
			Application.LoadLevel("Australia2");
		}
		
		if(Application.loadedLevelName == "Australia2")
		{
			if(resp!=null)resp.questao10=a[0];
			Application.LoadLevel("Australia3");
		}
		
		if(Application.loadedLevelName == "Australia3")
		{
			if(resp!=null)resp.questao11=a[0];
			Application.LoadLevel("Australia4");
		}
		
		if(Application.loadedLevelName == "Australia4")
		{
			if(resp!=null)resp.questao12=a[0];
			go = GameObject.Find("Habilitados");	
			hscript = go.GetComponent<Habilitados>();
			hscript.p4='1';
			Application.LoadLevel("Rally1");
		}
		//australia
		//alemanha
		if(Application.loadedLevelName == "Alemanha1")
		{
			if(resp!=null)resp.questao13=a[0];
			Application.LoadLevel("Alemanha2");
		}
		
		if(Application.loadedLevelName == "Alemanha2")
		{
			if(resp!=null)resp.questao14=a[0];
			Application.LoadLevel("Alemanha3");
		}
		
		if(Application.loadedLevelName == "Alemanha3")
		{
			if(resp!=null)resp.questao15=a[0];
			Application.LoadLevel("Alemanha4");
		}
		
		if(Application.loadedLevelName == "Alemanha4")
		{
			if(resp!=null)resp.questao16=a[0];
			go = GameObject.Find("Habilitados");	
			hscript = go.GetComponent<Habilitados>();
			hscript.p5='1';
			Application.LoadLevel("Rally1");
		}
		//alemanha
	}
	
	
}
