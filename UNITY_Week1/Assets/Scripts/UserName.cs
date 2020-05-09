using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserName : MonoBehaviour
{
    // Start is called before the first frame update

    int number = 0;
    char ch = 'A';
    string str = "Hello World";
    bool isTrue = true;
    float f = 0.4912838f;

    void Start()
    {
        Debug.Log("number: " + number);
        Debug.Log("ch: " + ch);
        Debug.Log("str: " + str);
        Debug.Log("isTrue: " + isTrue);
        Debug.Log("f: " + f);

        for (int i = 1; i <= 9; ++i)
        {
            Debug.Log(2 + " x " + i + " = " + (2 * i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
