using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using Assets.Scripts;

public class Query : MonoBehaviour {


	// Use this for initialization
	string hash;
	int grupamento;
	int resto;
	int postoinicial;
	int liderfase2;
    int id;
	MySqlConnection con;
	private string stConexao = "Server=localhost;Database=hackton;Uid=root;Pwd=pokemonblack;";
    MySqlCommand cmd2;
	MySqlCommand cmd3;
     
     
     

	 
	 
     void Start () 
	 {
         
     }
     
     // Update is called once per frame
     public void Test () 
	 {
         
     
	 
     
			con = new MySqlConnection(stConexao);
			
			//parte do hash
			
			cmd2 = new MySqlCommand ();
			cmd2.CommandText = "SELECT * FROM cadastro ORDER BY ID DESC LIMIT 1;";
			cmd2.Connection = con;
			con.Open();
			cmd2.ExecuteNonQuery();
			MySqlDataReader mySqlDreader;
			mySqlDreader = cmd2.ExecuteReader();
			while (mySqlDreader.Read())
            {
				id = Convert.ToInt32((mySqlDreader["id"]).ToString());
			}
			con.Close();
			
			//postoinicial		
			
			if (id>=5)
			{
				resto = id % 5;
				switch (resto)
				{
					case 0:
					postoinicial=5;
					break;
					case 1:
					postoinicial=1;
					break;
					case 2:
					postoinicial=2;
					break;
					case 3:
					postoinicial=3;
					break;
					case 4:
					postoinicial=4;
					break;
				}
			}
			else if (id<5)
			{
				switch (id)
				{
					case 1:
					postoinicial=1;
					break;
					case 2:
					postoinicial=2;
					break;
					case 3:
					postoinicial=3;
					break;
					case 4:
					postoinicial=4;
				    break;
			    }
			}
			
	        //grupamento

			if (id>3)
			{
				resto = id / 3;
				grupamento = resto+1;
			}
			
			else if (id<=3)
			{
				grupamento = 1;
			}
			
			
			
			
			//liderfase2

			
			if(id % 3==0)
			{
				liderfase2=1;
			}
			else if (id % 3!=0)
			{
				liderfase2=0;
			}
			
			hash = "00"+id.ToString()+"00"+grupamento.ToString()+postoinicial.ToString()+liderfase2.ToString();
			
			//Debug.Log(hash);
			
			
			
			cmd3 = new MySqlCommand ();
			cmd3.CommandText = "INSERT INTO hash VALUES ('"+id+"','"+hash+"');";
			cmd3.Connection = con;
			con.Open();
			cmd3.ExecuteNonQuery();
			con.Close();
			
			//fim do hash

		 }

	 }
	 


