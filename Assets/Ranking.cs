using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {
	

		
		GameObject go2;
	    PontosF1 spontos;
		
		GameObject go3;
		User suser;
		
		GameObject go4;
	    Respostas2 spontos2;
		
		MySqlConnection con;
	    private string stConexao = "Server=localhost;Database=hackton;Uid=root;Pwd=pokemonblack;";
        MySqlCommand cmd;		
        MySqlCommand cmd2;
		
	
	// Use this for initialization
		
	void Start () {
		
		

		//query respostasf1
		
			go2 = GameObject.Find("PF1");
			spontos = go2.GetComponent<PontosF1>();
			
			go3 = GameObject.Find("User");
			suser = go3.GetComponent<User>();
		
		    con = new MySqlConnection(stConexao);
		    cmd = new MySqlCommand ();
			cmd.CommandText = "INSERT INTO pontosf1(hash,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20) VALUES ('"+suser.usuario+"','"+spontos.pq1+"','"+spontos.pq2+"','"+spontos.pq3+"','"+spontos.pq4+"','"+spontos.pq5+"','"+spontos.pq6+"','"+spontos.pq7+"','"+spontos.pq8+"','"+spontos.pq9+"','"+spontos.pq10+"','"+spontos.pq11+"','"+spontos.pq12+"','"+spontos.pq13+"','"+spontos.pq14+"','"+spontos.pq15+"','"+spontos.pq16+"','"+spontos.pq17+"','"+spontos.pq18+"','"+spontos.pq19+"','"+spontos.pq20+"');";
			cmd.Connection = con;
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		
		//query respostasf2
		
			go4 = GameObject.Find("Respostas2");
			spontos2 = go4.GetComponent<Respostas2>();
			
		    con = new MySqlConnection(stConexao);
			cmd2 = new MySqlCommand ();
			cmd2.CommandText = "INSERT INTO pontosf2(hash,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20) VALUES ('"+suser.usuario+"','"+spontos2.pquestao1+"','"+spontos2.pquestao2+"','"+spontos2.pquestao3+"','"+spontos2.pquestao4+"','"+spontos2.pquestao5+"','"+spontos2.pquestao6+"','"+spontos2.pquestao7+"','"+spontos2.pquestao8+"','"+spontos2.pquestao9+"','"+spontos2.pquestao10+"','"+spontos2.pquestao11+"','"+spontos2.pquestao12+"','"+spontos2.pquestao13+"','"+spontos2.pquestao14+"','"+spontos2.pquestao15+"','"+spontos2.pquestao16+"','"+spontos2.pquestao17+"','"+spontos2.pquestao18+"','"+spontos2.pquestao19+"','"+spontos2.pquestao20+"');";
			cmd2.Connection = con;
			con.Open();
			cmd2.ExecuteNonQuery();
			con.Close();
	
		
	}
	
	// Update is called once per frame
		
		
	void Update () {
		
			
	
	
	}
	


}
