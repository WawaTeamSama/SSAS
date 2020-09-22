using UnityEngine;
using System.Collections;

public class First : MonoBehaviour {

    private Transform camTrans;
    private Vector3 camAng;
    private float camHeight = 0f;
   
	// Use this for initialization
	void Start () {
        camTrans = GetComponent<Transform>();
        Vector3 startPos = transform.position;
        startPos.y += camHeight;
       
        camTrans.position = startPos;
        camTrans.rotation = transform.rotation;
        camAng = camTrans.eulerAngles;
        
    }
	
	// Update is called once per frame
	void Update () {
        float y = Input.GetAxis("Mouse X");
        float x = Input.GetAxis("Mouse Y");
        camAng.x -= x;
        camAng.y += y;
        camTrans.eulerAngles = camAng;
        camTrans.position = new Vector3(this.transform.position.x, camTrans.position.y, this.transform.position.z);
        float camy = camAng.y;
        this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, camy, this.transform.eulerAngles.z);
        Vector3 startPos = transform.position;
        startPos.y += camHeight;
        
        camTrans.position = startPos;
    }
}
