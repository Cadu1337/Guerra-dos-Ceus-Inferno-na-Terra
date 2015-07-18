using UnityEngine;
using System.Collections;

public class Main_Menu : MonoBehaviour {

	public void Menu(){
		
		Application.LoadLevel (0);
	}

	public void Jogar(){
		
		Application.LoadLevel (1);
	}
	
	public void ComoJogar(){
		
		Application.LoadLevel (2);
	}

	public void Creditos(){
		
		Application.LoadLevel (3);
	}
	
	public void sair(){
		
		Application.Quit();
	}
}
