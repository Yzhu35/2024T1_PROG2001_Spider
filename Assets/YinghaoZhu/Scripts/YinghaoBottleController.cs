using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public AudioClip pickupSound;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        int currentScore = 0;
        if (int.TryParse(scoreText.text, out currentScore))
        {
            score = currentScore;
        }
        if(gameObject.CompareTag("GreenBottle")){
            score = score + 1;
            UpdateScoreText();
        }
        if(gameObject.CompareTag("BlueBottle")){
            score = score + 3;
            UpdateScoreText();
        }
        if (other.CompareTag("Spider"))
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(gameObject);
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
