using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using Assets.Scripts;

public class Query : MonoBehaviour {


	// Use this for initialization
    int id;
	MySqlConnection con;
	private string stConexao = "Server=localhost;Database=hackton;Uid=root;Pwd=pokemonblack;";
    MySqlCommand cmd;
     
     
     

	 
	 
     void Start () 
	 {
         
     }
     
     // Update is called once per frame
     public void Test () 
	 {
         
     
	 
     
			con = new MySqlConnection(stConexao);
			cmd = new MySqlCommand ();
			cmd.CommandText = "SELECT * FROM cadastro ORDER BY ID DESC LIMIT 1;";
			cmd.Connection = con;
			con.Open();
			cmd.ExecuteNonQuery();
			MySqlDataReader mySqlDreader;
			mySqlDreader = cmd.ExecuteReader();
			while (mySqlDreader.Read())
            {
				id = Convert.ToInt32((mySqlDreader["id"]).ToString());
			}
			con.Close();
			//Debug.Log(id);
			if (id % 5==0)
			{
				Debug.Log("deu certo");
			}
			
			


		 }

	 }
	 


