using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    SpriteRenderer mySR;
    Coroutine myCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
        Debug.Log("main");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (myCoroutine == null)
            {
                myCoroutine = StartCoroutine(change_color());
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(myCoroutine != null)
            {
                StopCoroutine(myCoroutine);
                myCoroutine = null;
            }
        }
    }
    IEnumerator change_color()
    {
        Color mycolor = new Color(0.001f, 0.001f, 0.001f, 0.0f);

        while (true)
        {
            if (mySR.color.r <= 0)
            {
                Debug.Log("¿¡º¼");
                myCoroutine = null;
                yield break;

            }
        }
        
        
    }
    
}
