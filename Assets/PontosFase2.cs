using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PontosFase2 : MonoBehaviour {
	
	string a;
	Respostas2 resp2;
	int cliquesq1;
	int cliquesq2;
	int cliquesq3;
	int cliquesq4;
	int cliquesq5;
	int cliquesq6;
	int cliquesq7;
	int cliquesq8;
	int cliquesq9;
	int cliquesq10;
	int cliquesq11;
	int cliquesq12;
	int cliquesq13;
	int cliquesq14;
	int cliquesq15;
	int cliquesq16;
	int cliquesq17;
	int cliquesq18;
	int cliquesq19;
	int cliquesq20;
	ToggleGroup toggleGroup;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
		public void Verifica () {
			
		 toggleGroup = GameObject.Find("Canvas/Toggles").GetComponent<ToggleGroup>();
		 a = toggleGroup.ActiveToggles().FirstOrDefault().ToString();
		 resp2 = GameObject.Find("Respostas2").GetComponent<Respostas2>();
		 
		 //questao 1
		 
		if(Application.loadedLevelName == "1")
		{
			
		if (a[0] =='d' && cliquesq1==0)
		{
			resp2.pquestao1='5';
			Application.LoadLevel("2");
	    }
		
		if (a[0] =='d' && cliquesq1==1)
		{
			resp2.pquestao1='3';
			Application.LoadLevel("2");
	    }
		
		if (a[0] =='d' && cliquesq1==2)
		{
			resp2.pquestao1='1';
			Application.LoadLevel("2");
	    }
		
		if (a[0] !='d')
		{
			cliquesq1++;
					if (cliquesq1>2)
					{
						resp2.pquestao1='0';
						Application.LoadLevel("2");
					}
		}
		
		
		}
			
		//fim
		
		//questao 2
		 
		if(Application.loadedLevelName == "2")
		{
			
		if (a[0] =='a' && cliquesq2==0)
		{
			resp2.pquestao2='5';
			Application.LoadLevel("3");
	    }
		
		if (a[0] =='a' && cliquesq2==1)
		{
			resp2.pquestao2='3';
			Application.LoadLevel("3");
	    }
		
		if (a[0] =='a' && cliquesq2==2)
		{
			resp2.pquestao2='1';
			Application.LoadLevel("3");
	    }
		
		if (a[0] !='a')
		{
			cliquesq2++;
					if (cliquesq2>2)
					{
						resp2.pquestao2='0';
						Application.LoadLevel("3");
					}
		}
		
		
		}
			
		//fim
		
		//questao 3
		 
		if(Application.loadedLevelName == "3")
		{
			
		if (a[0] =='c' && cliquesq3==0)
		{
			resp2.pquestao3='5';
			Application.LoadLevel("4");
	    }
		
		if (a[0] =='c' && cliquesq3==1)
		{
			resp2.pquestao3='3';
			Application.LoadLevel("4");
	    }
		
		if (a[0] =='c' && cliquesq3==2)
		{
			resp2.pquestao3='1';
			Application.LoadLevel("4");
	    }
		
		if (a[0] !='c')
		{
			cliquesq3++;
					if (cliquesq3>2)
					{
						resp2.pquestao3='0';
						Application.LoadLevel("4");
					}
		}
		
		
		}
			
		//fim
		
		//questao 4
		 
		if(Application.loadedLevelName == "4")
		{
			
		if (a[0] =='e' && cliquesq4==0)
		{
			resp2.pquestao4='5';
			Application.LoadLevel("5");
	    }
		
		if (a[0] =='e' && cliquesq4==1)
		{
			resp2.pquestao4='3';
			Application.LoadLevel("5");
	    }
		
		if (a[0] =='e' && cliquesq4==2)
		{
			resp2.pquestao4='1';
			Application.LoadLevel("5");
	    }
		
		if (a[0] !='e')
		{
			cliquesq4++;
					if (cliquesq4>2)
					{
						resp2.pquestao4='0';
						Application.LoadLevel("5");
					}
		}
		
		
		}
			
		//fim
		
		//questao 5
		 
		if(Application.loadedLevelName == "5")
		{
			
		if (a[0] =='d' && cliquesq5==0)
		{
			resp2.pquestao5='5';
			Application.LoadLevel("6");
	    }
		
		if (a[0] =='d' && cliquesq5==1)
		{
			resp2.pquestao5='3';
			Application.LoadLevel("6");
	    }
		
		if (a[0] =='d' && cliquesq5==2)
		{
			resp2.pquestao5='1';
			Application.LoadLevel("6");
	    }
		
		if (a[0] !='d')
		{
			cliquesq5++;
					if (cliquesq5>2)
					{
						resp2.pquestao5='0';
						Application.LoadLevel("6");
					}
		}
		
		
		}
			
		//fim
		
		//questao 6
		 
		if(Application.loadedLevelName == "6")
		{
			
		if (a[0] =='b' && cliquesq6==0)
		{
			resp2.pquestao6='5';
			Application.LoadLevel("7");
	    }
		
		if (a[0] =='b' && cliquesq6==1)
		{
			resp2.pquestao6='3';
			Application.LoadLevel("7");
	    }
		
		if (a[0] =='b' && cliquesq6==2)
		{
			resp2.pquestao6='1';
			Application.LoadLevel("7");
	    }
		
		if (a[0] !='b')
		{
			cliquesq6++;
					if (cliquesq6>2)
					{
						resp2.pquestao6='0';
						Application.LoadLevel("7");
					}
		}
		
		
		}
			
		//fim
		
		//questao 7
		 
		if(Application.loadedLevelName == "7")
		{
			
		if (a[0] =='e' && cliquesq7==0)
		{
			resp2.pquestao7='5';
			Application.LoadLevel("8");
	    }
		
		if (a[0] =='e' && cliquesq7==1)
		{
			resp2.pquestao7='3';
			Application.LoadLevel("8");
	    }
		
		if (a[0] =='e' && cliquesq7==2)
		{
			resp2.pquestao7='1';
			Application.LoadLevel("8");
	    }
		
		if (a[0] !='e')
		{
			cliquesq7++;
					if (cliquesq7>2)
					{
						resp2.pquestao7='0';
						Application.LoadLevel("8");
					}
		}
		
		
		}
			
		//fim
		
		//questao 8
		 
		if(Application.loadedLevelName == "8")
		{
			
		if (a[0] =='a' && cliquesq8==0)
		{
			resp2.pquestao8='5';
			Application.LoadLevel("9");
	    }
		
		if (a[0] =='a' && cliquesq8==1)
		{
			resp2.pquestao8='3';
			Application.LoadLevel("9");
	    }
		
		if (a[0] =='a' && cliquesq8==2)
		{
			resp2.pquestao8='1';
			Application.LoadLevel("9");
	    }
		
		if (a[0] !='a')
		{
			cliquesq7++;
					if (cliquesq8>2)
					{
						resp2.pquestao8='0';
						Application.LoadLevel("9");
					}
		}
		
		
		}
			
		//fim
		//questao 9
		 
		if(Application.loadedLevelName == "9")
		{
			
		if (a[0] =='c' && cliquesq9==0)
		{
			resp2.pquestao9='5';
			Application.LoadLevel("10");
	    }
		
		if (a[0] =='c' && cliquesq9==1)
		{
			resp2.pquestao9='3';
			Application.LoadLevel("10");
	    }
		
		if (a[0] =='c' && cliquesq9==2)
		{
			resp2.pquestao9='1';
			Application.LoadLevel("10");
	    }
		
		if (a[0] !='c')
		{
			cliquesq9++;
					if (cliquesq9>2)
					{
						resp2.pquestao9='0';
						Application.LoadLevel("10");
					}
		}
		
		
		}
			
		//fim
		//questao 10
		 
		if(Application.loadedLevelName == "10")
		{
			
		if (a[0] =='b' && cliquesq10==0)
		{
			resp2.pquestao10='5';
			Application.LoadLevel("11");
	    }
		
		if (a[0] =='b' && cliquesq10==1)
		{
			resp2.pquestao10='3';
			Application.LoadLevel("11");
	    }
		
		if (a[0] =='b' && cliquesq10==2)
		{
			resp2.pquestao10='1';
			Application.LoadLevel("11");
	    }
		
		if (a[0] !='b')
		{
			cliquesq10++;
					if (cliquesq10>2)
					{
						resp2.pquestao10='0';
						Application.LoadLevel("11");
					}
		}
		
		
		}
			
		//fim
		//questao 11
		 
		if(Application.loadedLevelName == "11")
		{
			
		if (a[0] =='e' && cliquesq11==0)
		{
			resp2.pquestao10='5';
			Application.LoadLevel("12");
	    }
		
		if (a[0] =='e' && cliquesq11==1)
		{
			resp2.pquestao11='3';
			Application.LoadLevel("12");
	    }
		
		if (a[0] =='e' && cliquesq11==2)
		{
			resp2.pquestao11='1';
			Application.LoadLevel("12");
	    }
		
		if (a[0] !='e')
		{
			cliquesq11++;
					if (cliquesq11>2)
					{
						resp2.pquestao11='0';
						Application.LoadLevel("12");
					}
		}
		
		
		}
			
		//fim
		//questao 12
		 
		if(Application.loadedLevelName == "12")
		{
			
		if (a[0] =='a' && cliquesq12==0)
		{
			resp2.pquestao12='5';
			Application.LoadLevel("13");
	    }
		
		if (a[0] =='a' && cliquesq12==1)
		{
			resp2.pquestao12='3';
			Application.LoadLevel("13");
	    }
		
		if (a[0] =='a' && cliquesq12==2)
		{
			resp2.pquestao12='1';
			Application.LoadLevel("13");
	    }
		
		if (a[0] !='a')
		{
			cliquesq12++;
					if (cliquesq12>2)
					{
						resp2.pquestao12='0';
						Application.LoadLevel("13");
					}
		}
		
		
		}
			
		//fim
		
		//questao 13
		 
		if(Application.loadedLevelName == "13")
		{
			
		if (a[0] =='c' && cliquesq13==0)
		{
			resp2.pquestao13='5';
			Application.LoadLevel("14");
	    }
		
		if (a[0] =='c' && cliquesq13==1)
		{
			resp2.pquestao13='3';
			Application.LoadLevel("14");
	    }
		
		if (a[0] =='c' && cliquesq13==2)
		{
			resp2.pquestao13='1';
			Application.LoadLevel("14");
	    }
		
		if (a[0] !='c')
		{
			cliquesq13++;
					if (cliquesq13>2)
					{
						resp2.pquestao13='0';
						Application.LoadLevel("14");
					}
		}
		
		
		}
			
		//fim
		//questao 14
		 
		if(Application.loadedLevelName == "14")
		{
			
		if (a[0] =='b' && cliquesq14==0)
		{
			resp2.pquestao14='5';
			Application.LoadLevel("15");
	    }
		
		if (a[0] =='b' && cliquesq14==1)
		{
			resp2.pquestao14='3';
			Application.LoadLevel("15");
	    }
		
		if (a[0] =='b' && cliquesq14==2)
		{
			resp2.pquestao14='1';
			Application.LoadLevel("15");
	    }
		
		if (a[0] !='b')
		{
			cliquesq14++;
					if (cliquesq14>2)
					{
						resp2.pquestao14='0';
						Application.LoadLevel("15");
					}
		}
		
		
		}
			
		//fim
		//questao 15
		 
		if(Application.loadedLevelName == "15")
		{
			
		if (a[0] =='c' && cliquesq15==0)
		{
			resp2.pquestao15='5';
			Application.LoadLevel("16");
	    }
		
		if (a[0] =='c' && cliquesq15==1)
		{
			resp2.pquestao15='3';
			Application.LoadLevel("16");
	    }
		
		if (a[0] =='c' && cliquesq15==2)
		{
			resp2.pquestao15='1';
			Application.LoadLevel("16");
	    }
		
		if (a[0] !='c')
		{
			cliquesq15++;
					if (cliquesq15>2)
					{
						resp2.pquestao15='0';
						Application.LoadLevel("16");
					}
		}
		
		
		}
			
		//fim
		//questao 16
		 
		if(Application.loadedLevelName == "16")
		{
			
		if (a[0] =='b' && cliquesq16==0)
		{
			resp2.pquestao16='5';
			Application.LoadLevel("17");
	    }
		
		if (a[0] =='b' && cliquesq16==1)
		{
			resp2.pquestao15='3';
			Application.LoadLevel("17");
	    }
		
		if (a[0] =='b' && cliquesq16==2)
		{
			resp2.pquestao16='1';
			Application.LoadLevel("17");
	    }
		
		if (a[0] !='b')
		{
			cliquesq16++;
					if (cliquesq16>2)
					{
						resp2.pquestao16='0';
						Application.LoadLevel("17");
					}
		}
		
		
		}
			
		//fim
		//questao 17
		 
		if(Application.loadedLevelName == "17")
		{
			
		if (a[0] =='e' && cliquesq17==0)
		{
			resp2.pquestao17='5';
			Application.LoadLevel("18");
	    }
		
		if (a[0] =='e' && cliquesq17==1)
		{
			resp2.pquestao17='3';
			Application.LoadLevel("18");
	    }
		
		if (a[0] =='e' && cliquesq17==2)
		{
			resp2.pquestao17='1';
			Application.LoadLevel("18");
	    }
		
		if (a[0] !='e')
		{
			cliquesq17++;
					if (cliquesq17>2)
					{
						resp2.pquestao17='0';
						Application.LoadLevel("18");
					}
		}
		
		
		}
			
		//fim
		//questao 18
		 
		if(Application.loadedLevelName == "18")
		{
			
		if (a[0] =='a' && cliquesq18==0)
		{
			resp2.pquestao18='5';
			Application.LoadLevel("19");
	    }
		
		if (a[0] =='a' && cliquesq18==1)
		{
			resp2.pquestao18='3';
			Application.LoadLevel("19");
	    }
		
		if (a[0] =='a' && cliquesq18==2)
		{
			resp2.pquestao18='1';
			Application.LoadLevel("19");
	    }
		
		if (a[0] !='a')
		{
			cliquesq18++;
					if (cliquesq18>2)
					{
						resp2.pquestao18='0';
						Application.LoadLevel("19");
					}
		}
		
		
		}
		//fim18			
	    //questao 19
		 
		if(Application.loadedLevelName == "19")
		{
			
		if (a[0] =='b' && cliquesq19==0)
		{
			resp2.pquestao19='5';
			Application.LoadLevel("20");
	    }
		
		if (a[0] =='b' && cliquesq19==1)
		{
			resp2.pquestao19='3';
			Application.LoadLevel("20");
	    }
		
		if (a[0] =='b' && cliquesq19==2)
		{
			resp2.pquestao19='1';
			Application.LoadLevel("20");
	    }
		
		if (a[0] !='b')
		{
			cliquesq19++;
					if (cliquesq19>2)
					{
						resp2.pquestao19='0';
						Application.LoadLevel("20");
					}
		}
		
		
		}
		//fim
		//questao 20
		 
		if(Application.loadedLevelName == "20")
		{
			
		if (a[0] =='d' && cliquesq20==0)
		{
			resp2.pquestao20='5';
			Application.LoadLevel("Rank");
	    }
		
		if (a[0] =='d' && cliquesq20==1)
		{
			resp2.pquestao20='3';
			Application.LoadLevel("Rank");
	    }
		
		if (a[0] =='d' && cliquesq20==2)
		{
			resp2.pquestao20='1';
			Application.LoadLevel("Rank");
	    }
		
		if (a[0] !='d')
		{
			cliquesq20++;
					if (cliquesq20>2)
					{
						resp2.pquestao20='0';
						Application.LoadLevel("Rank");
					}
		}
		
		
		}
			
		//fim
		
	}
	
	
}
