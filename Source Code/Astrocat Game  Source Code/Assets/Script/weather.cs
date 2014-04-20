using UnityEngine;
using System.Collections;

public class weather : MonoBehaviour {


	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(new Vector3(0,speed,0));
	}
}
