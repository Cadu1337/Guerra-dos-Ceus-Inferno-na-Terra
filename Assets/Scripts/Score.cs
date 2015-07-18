using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score2 : MonoBehaviour {
	
	public static int score;
	public string text;
	
	
	
	void Start () {
		
		//score = Ball.score = 0;
	}
	
	void Update () {
		
		//score = Ball.score;
		GetComponent<TextMesh>().text = score.ToString();
	}
}
