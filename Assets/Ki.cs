using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ki : MonoBehaviour
{
    SpriteRenderer mySR;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("branch_practice");

        mySR = GetComponent<SpriteRenderer>();  
        Debug.Log("Ki");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            change_color();
        }
    }
    void change_color ()
    {
        mySR.color = Color.gray;
    }
}
