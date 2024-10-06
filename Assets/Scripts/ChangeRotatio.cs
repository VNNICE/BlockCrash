using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotAngle = 4f;

    private void FixedUpdate()
    {
        transform.Rotate(0f, rotAngle, 0f);
    }
}
