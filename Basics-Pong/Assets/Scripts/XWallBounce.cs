using UnityEngine;

namespace Assets.Scripts
{
    public class XWallBounce : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D other)
        {
            other.attachedRigidbody.velocity = new Vector2(other.attachedRigidbody.velocity.x * -1, other.attachedRigidbody.velocity.y);
        }
    }
}