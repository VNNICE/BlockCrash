using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public float bounceForce = 10f;
    public int point = 10;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "CopyBall")
        {
            Vector3 normal = collision.contacts[0].normal;
            Vector3 velocity = new Vector3(-normal.x, 0f, -normal.z);
            collision.rigidbody.AddForce(velocity.normalized * bounceForce, ForceMode.VelocityChange);
            gameManager.AddScore(point);
        }
    }
}
