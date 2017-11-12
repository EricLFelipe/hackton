using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosF1 : MonoBehaviour {

    Respostas rscript;
	GameObject go;
	public int pq1;
	public int pq2;
	public int pq3;
	public int pq4;
	public int pq5;
	public int pq6;
	public int pq7;
	public int pq8;
	public int pq9;
	public int pq10;
	public int pq11;
	public int pq12;
	public int pq13;
	public int pq14;
	public int pq15;
	public int pq16;
	public int pq17;
	public int pq18;
	public int pq19;
	public int pq20;
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		rscript = GameObject.Find("Respostas").GetComponent<Respostas>();
		
		//questao1
		if (rscript.questao1=='d')
		{
			pq1=1;
		}
		else 
		{
			pq1=0;
		}
		//fim
		//questao2
		if (rscript.questao2=='a')
		{
			pq2=1;
		}
		else 
		{
			pq2=0;
		}
		//fim
		//questao3
		if (rscript.questao3=='c')
		{
			pq3=1;
		}
		else 
		{
			pq3=0;
		}
		//fim
		//questao4
		if (rscript.questao4=='e')
		{
			pq4=1;
		}
		else 
		{
			pq4=0;
		}
		//fim
		//questao5
		if (rscript.questao5=='d')
		{
			pq5=1;
		}
		else 
		{
			pq5=0;
		}
		//fim
		//questao6
		if (rscript.questao6=='b')
		{
			pq6=1;
		}
		else 
		{
			pq6=0;
		}
		//fim
		//questao7
		if (rscript.questao7=='e')
		{
			pq7=1;
		}
		else 
		{
			pq7=0;
		}
		//fim
		//questao8
		if (rscript.questao8=='a')
		{
			pq8=1;
		}
		else 
		{
			pq8=0;
		}
		//fim
		//questao9
		if (rscript.questao9=='c')
		{
			pq9=1;
		}
		else 
		{
			pq9=0;
		}
		//fim
		//questao10
		if (rscript.questao10=='b')
		{
			pq10=1;
		}
		else 
		{
			pq10=0;
		}
		//fim
		//questao11
		if (rscript.questao11=='e')
		{
			pq11=1;
		}
		else 
		{
			pq11=0;
		}
		//fim
		//questao12
		if (rscript.questao12=='a')
		{
			pq12=1;
		}
		else 
		{
			pq12=0;
		}
		//fim
		//questao13
		if (rscript.questao13=='c')
		{
			pq13 = 1;
		}
		else 
		{
			pq13=0;
		}
		//fim
		//questao14
		if (rscript.questao14=='b')
		{
			pq14 = 1;
		}
		else 
		{
			pq14=0;
		}
		//fim
		//questao15
		if (rscript.questao15=='c')
		{
			pq15=1;
		}
		else 
		{
			pq15=0;
		}
		//fim
		//questao16
		if (rscript.questao16=='b')
		{
			pq16=1;
		}
		else 
		{
			pq16=0;
		}
		//fim
		//questao17
		if (rscript.questao17=='e')
		{
			pq17=1;
		}
		else 
		{
			pq17=0;
		}
		//fim
		//questao18
		if (rscript.questao18=='a')
		{
			pq18=1;
		}
		else 
		{
			pq18=0;
		}
		//fim
		//questao19
		if (rscript.questao19=='b')
		{
			pq19=1;
		}
		else 
		{
			pq19=0;
		}
		//fim
		//questao20
		if (rscript.questao20=='d')
		{
			pq20=1;
		}
		else 
		{
			pq20=0;
		}
		//fim	
	}
	
	
		
}
