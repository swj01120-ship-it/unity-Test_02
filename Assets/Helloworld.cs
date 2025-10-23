using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    Vector3 myVector = Vector3.zero;
    Rigidbody2D myRigid;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            myVector=Vector3.right;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            myVector=Vector3.left;
        }
        else
        {
            myVector=Vector3.zero;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            myRigid.AddForce(Vector3.up * 300.0f);
        }

        transform.Translate(myVector*3.0f*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.CompareTag("Floor"))
        {

        }
        
    }
}
