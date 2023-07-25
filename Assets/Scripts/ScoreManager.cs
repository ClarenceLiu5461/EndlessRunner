using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //increase score of 1 
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }
}
