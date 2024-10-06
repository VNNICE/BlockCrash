using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float Bounce = 10f;
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "CopyBall")
        {
            collision.rigidbody.AddForce(0f, Bounce/2f, Bounce, ForceMode.Impulse);
        }
    }
}
