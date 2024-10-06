using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyBall : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public int point = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            gameManager.AddScore(point);
        }
        if (collision.gameObject.tag == "KillZone") 
        {
            Destroy(this.gameObject);
        }
    }
}
