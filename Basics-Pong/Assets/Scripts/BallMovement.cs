using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Dampening;

	// Use this for initialization
	public void Start ()
    {
        var rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Random.insideUnitCircle * Dampening;
	}
}