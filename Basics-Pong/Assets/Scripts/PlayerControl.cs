using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerControl : MonoBehaviour
    {
        public float SpeedModifier;

        public void FixedUpdate ()
        {
            var movementDirection = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * movementDirection * Time.fixedDeltaTime * SpeedModifier);
        }
    }
}