using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    SpriteRenderer mySR;
    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
      }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            change_color();
        }
        
    }
    IEnumerator change_color()
    {
        Color myColor = new Color(0.001f, 0.001f, 0.001f, 0.0f);
        //mySR.color = Color.clear;
        while(true)
        {
            if (mySR.color.r == 0)
            {
                Debug.Log("에볼루션");
                yield break;
            }
            mySR.color -= myColor;
            yield return null;
        }
       
    }
}
