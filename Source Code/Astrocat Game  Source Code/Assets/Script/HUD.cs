using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public Texture2D Head;
	public Texture2D red;
	public Texture2D green;
	public Texture2D BG;

	public Texture2D[] Minerals = new Texture2D[4];


	void OnGUI(){
		// draw the hud backgroun here
		GUI.DrawTexture(new Rect(Screen.width / 50, Screen.height/50, Screen.width / 2.75f, Screen.width/10), BG);

		GUI.DrawTexture (new Rect(Screen.width / 10,Screen.height / 20,Screen.width / 4,Screen.height / 10),red);

		// this is were the oxygen level is edited and displayed
		GUI.BeginGroup((new Rect(Screen.width / 10,Screen.height / 20,(Screen.width / 4)*(Universal.Oxygen/100) ,Screen.height / 10)));
		GUI.DrawTexture (new Rect(0,0,Screen.width / 4,Screen.height / 10),green);
		GUI.EndGroup();

		GUI.DrawTexture(new Rect(Screen.width / 50, Screen.height/50, Screen.width / 10, Screen.width/10), Head);

		// dirffrent elements in the gui
		GUI.Box(new Rect((Screen.width / 2 ),Screen.height / 20,Screen.width / 10,Screen.height / 5), "Fe \n" + Universal.materials[0]+ " KG");
		GUI.Box(new Rect((Screen.width / 2 )+ (Screen.width / 8),Screen.height / 20,Screen.width / 10,Screen.height / 5), "Zn \n" + Universal.materials[1] + " KG");
		GUI.Box(new Rect((Screen.width / 2 )+ (Screen.width / 8)*2,Screen.height / 20,Screen.width / 10,Screen.height / 5), "Mg \n" + Universal.materials[2]+ " KG");
		GUI.Box(new Rect((Screen.width / 2 )+ (Screen.width / 8)*3,Screen.height / 20,Screen.width / 10,Screen.height / 5), "Co \n" + Universal.materials[3]+ " KG");


		// diffrent element images
		GUI.DrawTexture(new Rect((Screen.width / 2)- Screen.width / 40,Screen.height / 20,Screen.height / 10,Screen.height / 10), Minerals[0]);
		GUI.DrawTexture(new Rect(Screen.width / 2 + (Screen.width / 8)- Screen.width / 40,Screen.height / 20,Screen.height / 10,Screen.height / 10), Minerals[1]);
		GUI.DrawTexture(new Rect((Screen.width / 2 + (Screen.width / 8)*2)- Screen.width / 40,Screen.height / 20,Screen.height / 10,Screen.height / 10),Minerals[2] );
		GUI.DrawTexture(new Rect((Screen.width / 2 + (Screen.width / 8)*3) - Screen.width / 40,Screen.height / 20,Screen.height / 10,Screen.height / 10), Minerals[3]);


	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
