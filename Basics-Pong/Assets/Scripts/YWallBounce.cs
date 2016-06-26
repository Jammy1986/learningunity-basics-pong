using UnityEngine;

namespace Assets.Scripts
{
    public class YWallBounce : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Ball"))
            {
                other.attachedRigidbody.velocity = new Vector2(other.attachedRigidbody.velocity.x, other.attachedRigidbody.velocity.y*-1);
            }
            else
            {
                other.attachedRigidbody.velocity = new Vector2(other.attachedRigidbody.velocity.x, other.attachedRigidbody.velocity.y * -1);
            }
        }
    }
}