using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("main");
    }

    // Update is called once per frame
    void Update()
    {
        
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
        mySR,color -= mycolor;
        yield return null;
    }
    }
}
