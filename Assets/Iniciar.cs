using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using Assets.Scripts;


public class Iniciar : MonoBehaviour {


	// Use this for initialization
	GameObject go;
	User userscript;

	MySqlConnection con;
	private string stConexao = "Server=localhost;Database=hackton;Uid=root;Pwd=pokemonblack;";
    MySqlCommand cmd;
          
     public Rect windowRect0 = new Rect(20,20,450,480);
     
     public static string hash="";

     void Start () 
	 {
         
     }
     
     // Update is called once per frame
     void Update () 
	 {
         
     }
	 
     void OnGUI() 
	 {
         windowRect0 = GUI.Window(0, windowRect0, RegisterBoard, "CÓDIGO DO CHECKIN");
     }
	 
	 
     void RegisterBoard(int windowID) 
	 {
		 bool result;
		 bool status = false;
		 
         GUI.Label (new Rect (40, 40, 500, 100), "Digite o código");
         hash = GUI.TextField (new Rect (25, 60, 375, 30), hash);
		 
         
		 
		 if (GUI.Button (new Rect (25,410,175, 50), "Liberar"))
		{
			con = new MySqlConnection(stConexao);
			cmd = new MySqlCommand ();
			cmd.CommandText = "SELECT * FROM hash WHERE hashid = '"+hash+"'";
			cmd.Connection = con;
			con.Open();
			
			cmd.ExecuteNonQuery();
			MySqlDataReader mySqlDreader;
			mySqlDreader = cmd.ExecuteReader();

		
		while (mySqlDreader.Read())
		{
			string a =(mySqlDreader["hashid"]).ToString();

			
			if (a==hash)
			{
				
			go = GameObject.Find("User");	
			userscript = go.GetComponent<User>();
			userscript.usuario=hash;
			Application.LoadLevel("Batatinha");
			}
			
		}
			
			
			con.Close();
		}
	


	 }
	 

}
