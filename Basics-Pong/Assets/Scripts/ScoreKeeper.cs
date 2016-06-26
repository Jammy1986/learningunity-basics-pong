using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScoreKeeper : MonoBehaviour
    {
        private int _playerScore;
        public Text PlayerScoreText;
        public int PlayerScore
        {
            get { return _playerScore; }
            set
            {
                _playerScore = value;
                PlayerScoreText.text = "" + _playerScore;
            }
        }

        private int _enemyScore;
        public Text EnemyScoreText;
        public int EnemyScore
        {
            get { return _enemyScore; }
            set
            {
                _enemyScore = value;
                EnemyScoreText.text = "" + _enemyScore;
            }
        }
    }
}