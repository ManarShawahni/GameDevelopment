using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int number = Random.Range(1, 21);
            if (number == 5)
            {
                continue;
            }

            Debug.Log(number);

            if (number == 15)
            {
                Debug.Log("Number 15 found, stopping the loop.");
                break;
            }
        }
        Debug.Log("Loop exit");
    }
}
