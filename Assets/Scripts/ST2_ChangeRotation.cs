using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ST2_ChangeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotAngle = 4f;
    float T = 0;
    bool reverse = false;
    private void Start()
    {

    }
    private void Update()
    {
        T += Time.deltaTime;
        if (Mathf.RoundToInt(T) % 5 == 0)
        {
            if (reverse == false)
            {
                reverse = true;
                T = 1;
            }
            else if (reverse == true)
            {
                reverse = false;
                T = 1;
            }
        }
    }
    private void FixedUpdate()
    {
        if (reverse == false)
        {
            transform.Rotate(0f, rotAngle, 0f);
        }
        else
        {
            transform.Rotate(0f, -rotAngle, 0f);
        }

    }
}
