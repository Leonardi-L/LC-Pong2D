using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.name == "Ball")
        {
            //string wallName = transform.name;
            ////memanggil method Score di GameManager.cs
            //GameManager.instance.AddScore(wallName);
            ////memanggil method RestartGame() di BallControl.cs
            hitInfo.gameObject.SendMessage("RestartGame");
            GameManager.instance.AddScore(gameObject.name);
        }
    }
}