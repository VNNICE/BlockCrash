using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] public float bounceForce = 10f;
    [SerializeField] public int point = 10;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {

            Vector3 normal = collision.contacts[0].normal;
            Vector3 velocity = new Vector3(normal.x, 0f, normal.z);
            collision.rigidbody.AddForce(velocity.normalized * bounceForce, ForceMode.VelocityChange);
            gameManager.AddScore(point);
        }
    }
}
