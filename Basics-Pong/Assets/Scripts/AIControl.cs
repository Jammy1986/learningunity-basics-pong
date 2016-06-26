using UnityEngine;
using System.Collections;

public class AIControl : MonoBehaviour
{
    public Rigidbody2D BallRigidbody2D;

    public void Update()
    {
        if (BallRigidbody2D.velocity.x > 0)
        {
            //BallRigidbody2D.transform.position.y
        }
        else
        {
            //Return to center.
        }
    }
}