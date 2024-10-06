using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public int point = 100;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "CopyBall")
        {
            Destroy(gameObject);
            gameManager.AddScore(point);
            gameManager.OnBroken();
        }


    }
}