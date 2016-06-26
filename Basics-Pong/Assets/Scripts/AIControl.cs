using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts
{
    public class AIControl : MonoBehaviour
    {
        public Rigidbody2D BallRigidbody2D;
        public float SpeedModifier;

        public void FixedUpdate()
        {
            if (BallRigidbody2D.velocity.x > 0)
            {
                var raycasts = Physics2D.RaycastAll(BallRigidbody2D.position, BallRigidbody2D.velocity);
                if (raycasts.Length <= 1)
                {
                    var directionToBall = Mathf.Clamp(BallRigidbody2D.position.y, -1, 1);
                    HeadInDirection(directionToBall);
                }
                else
                {
                    CalculateBouncesToDetermineDestination(raycasts);
                }
            }
            else
            {
                //Return to center.
                var directionToCentre = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, -1, 1) * -1;
                HeadInDirection(directionToCentre);
            }
        }

        private void CalculateBouncesToDetermineDestination(RaycastHit2D[] raycasts)
        {
//            Assert.AreEqual("Ball", raycasts[0].transform.tag);
            while (true)
            {
                var nextDestination = raycasts[1];
                if (nextDestination.transform.CompareTag("Enemy"))
                {
                    //Do nothing, we are intercepting.
                }
                else if (nextDestination.transform.CompareTag("yWall"))
                {
                    //Calculate bounce, and re-run.
                    raycasts = Physics2D.RaycastAll(nextDestination.point, nextDestination.normal);
                    continue;
                }
                else
                {
                    //It's heading for my wall, intercept.
                    HeadInDirection(Mathf.Clamp(nextDestination.point.y - GetComponent<Rigidbody2D>().transform.position.y, -1, 1));
                }
                break;
            }
        }

        private void HeadInDirection(float direction)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * Time.fixedDeltaTime * direction * SpeedModifier);
        }
    }
}