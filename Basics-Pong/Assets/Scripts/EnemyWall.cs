using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyWall : MonoBehaviour
    {
        public ScoreKeeper ScoreKeeper;

        public void OnTriggerEnter2D(Collider2D other)
        {
            ++ScoreKeeper.PlayerScore;
        }
    }
}