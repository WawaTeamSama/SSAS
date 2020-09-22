using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour
{

    private Animator a;
    public float m_speed = 5f;
    public GameObject player;
   

    // Use this for initialization
    void Start()
    {
        a = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            a.SetBool("Walk", true);
            this.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
        }   
        else if (Input.GetKey(KeyCode.S))
        {
            a.SetBool("Walk", false);
            this.transform.Translate(Vector3.forward * -m_speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            a.SetBool("Walk", false);
            this.transform.Translate(Vector3.right * -m_speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            a.SetBool("Walk", false);
            this.transform.Translate(Vector3.left * -m_speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            a.SetBool("Run", true);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.up * 4f * Time.deltaTime);
            a.SetTrigger("Jump");
            this.transform.Translate(Vector3.down * 4f * Time.deltaTime);
        }
        if (Input.GetMouseButton(0))
        {
            a.SetTrigger("Attack");
        }


    }
}
