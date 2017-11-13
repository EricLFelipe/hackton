using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using Assets.Scripts;
using System;

public class Login : MonoBehaviour {


	// Use this for initialization
	string hash;
	int grupamento;
	int resto;
	int postoinicial;
	int liderfase2;
    int id;
	MySqlConnection con;
	private string stConexao = "Server=localhost;Database=hackton;Uid=root;Pwd=pokemonblack;";
    MySqlCommand cmd;
	MySqlCommand cmd2;
	MySqlCommand cmd3;
     
     
     public Rect windowRect0 = new Rect(20,20,450,480);

     
     public static string nome1="";
     public static string ra1="";
	 public static string nome2="";
     public static string ra2="";
	 public static string nome3="";
     public static string ra3="";
	 
	 private GameObject go;
	 private Registrado reg;


	 
	 
     void Start () 
	 {
         
     }
     
     // Update is called once per frame
     void Update () 
	 {
         
     }
	 
     void OnGUI() 
	 {
         windowRect0 = GUI.Window(0, windowRect0, RegisterBoard, "CADASTRAR TIME");
     }
	 
	 
     void RegisterBoard(int windowID) 
	 {
		 
         GUI.Label (new Rect (40, 40, 500, 100), "Digite o nome do primeiro participante(lider)");
         nome1 = GUI.TextField (new Rect (25, 60, 375, 30), nome1);
		 
         GUI.Label (new Rect (40, 100, 500, 100), "Digite o ra do primeiro participante(lider)");
         ra1= GUI.TextField(new Rect (25, 120, 375, 30), ra1);
		 
		 GUI.Label (new Rect (40, 160, 500, 100), "Digite o nome do segundo participante");
         nome2 = GUI.TextField (new Rect (25, 180, 375, 30), nome2);
		 
         GUI.Label (new Rect (40, 220, 500, 100), "Digite o ra do segundo participante");
         ra2= GUI.TextField(new Rect (25, 240, 375, 30), ra2);
		 
		 GUI.Label (new Rect (40, 280, 500, 100), "Digite o nome do terceiro participante");
         nome3 = GUI.TextField (new Rect (25, 300, 375, 30), nome3);
		 
         GUI.Label (new Rect (40, 335, 500, 100), "Digite o ra do terceiro participante");
         ra3= GUI.TextField(new Rect (25, 360, 375, 30), ra3);
		 
		 if (GUI.Button (new Rect (25,410,175, 50), "Enviar"))
		{
			con = new MySqlConnection(stConexao);
			cmd = new MySqlCommand ();
			cmd.CommandText = "INSERT INTO cadastro (nome1,ra1,nome2,ra2,nome3,ra3) VALUES ('"+nome1+"','"+ra1+"','"+nome2+"','"+ra2+"','"+nome3+"','"+ra3+"');";
			cmd.Connection = con;
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			
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
			

			nome1 = "";
			ra1= "";
			nome2 = "";
			ra2= "";
			nome3 = "";
			ra3= "";
			
			go = GameObject.Find("Registrado");
			reg = go.GetComponent<Registrado>();
			reg.enabled=true;
		}
	
		 
		 if (GUI.Button (new Rect (225,410,175, 50), "Home"))
		 {
		 Application.LoadLevel("Home");
		 }

	 }
	 

}
