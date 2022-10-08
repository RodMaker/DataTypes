using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypesTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sbyte b_int;
        short s_int;
        int i_int;
        long l_int;

        b_int = -128;
        s_int = 17;
        i_int = 17;
        l_int = 17;

        l_int = 2000000000;
        l_int = l_int * 2;

        /*
        Debug.Log($"b_int={b_int}");
        Debug.Log($"s_int={s_int}");
        Debug.Log($"i_int={i_int}");
        Debug.Log($"l_int={l_int}");
        */

        float x;
        double y;

        x = 2.1f;
        y = 3.1;

        /*
        Debug.Log($"x={x}");
        Debug.Log($"y={y}");
        */

        /*
        // Conversion from int to float
        Debug.Log($"i_int={i_int}");
        x = i_int;
        Debug.Log($"x={x}");

        // Conversion from float to int
        x = 3.14159f;
        Debug.Log($"x={x}");
        i_int = (int)x; // cast
        Debug.Log($"i_int={i_int}");
        */

        x = (float)(3.3 * 5.7);
        Debug.Log($"x={x}");

        i_int = (int)(3.3 * 5.7);
        Debug.Log($"i_int={i_int}");

        x = (float)3 / (float)(2 + 5);
        Debug.Log($"x={x}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
