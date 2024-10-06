using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBall : MonoBehaviour
{

    [SerializeField] GameObject ballPrefab;
    int ballCount;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball") 
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = "newBall" + ballCount;
            newBall.transform.position = this.transform.position;
            Destroy(this.gameObject);
        }
    }
}
