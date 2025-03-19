using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb2d;
    [SerializeField] public float rand;

    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    public void GoBall()
    {
        rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(45, -15));
            Debug.Log("0");
        }
        else
        {
            rb2d.AddForce(new Vector2(-45, -15));
            Debug.Log("1");
        }

    }
    private void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 2);
    }
}