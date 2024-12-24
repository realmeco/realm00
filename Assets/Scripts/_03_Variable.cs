using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _03_Variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int life;
        life = 3;
        Debug.Log(life);

        life = 2;
        Debug.Log(life);

        float  time = 9.9f;
        Debug.Log(time);

        time = 0.1f;
        Debug.Log(time);

        double hp = 99.123;
        Debug.Log(hp);

        hp = 10.05;
        Debug.Log(hp);

        string msg = "Game Start";
        Debug.Log(msg);

        msg = "Game Over";
        Debug.Log(msg);

        char grade = 'A';
        Debug.Log(grade);

        grade = 'S';
        Debug.Log(grade);

        bool result = true;
        Debug.Log(result);

        result = false;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
