using UnityEngine;
using System.Collections;

public class Disappear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color= new Color(1, 1, 1, 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
