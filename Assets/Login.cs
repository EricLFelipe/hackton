using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using Assets.Scripts;

public class Login : MonoBehaviour {


	// Use this for initialization

	MySqlConnection con;
	private string stConexao = "Server=localhost;Database=hackton;Uid=root;Pwd=pokemonblack;";
    MySqlCommand cmd;
     
     
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
