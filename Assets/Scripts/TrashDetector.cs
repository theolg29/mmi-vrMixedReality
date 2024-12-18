using UnityEngine;
using TMPro;

public class TrashBin : MonoBehaviour
{
    public string acceptedTag;
    public TMP_Text scoreText;
    public AudioClip successSound;
    public AudioClip errorSound;

    private AudioSource audioSource;
    private int score = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(acceptedTag))
        {
            score++;
            UpdateScoreText();
            audioSource.PlayOneShot(successSound);
            Destroy(other.gameObject);
        }
        else
        {
                    Debug.Log("Mauvais tri détecté. Tag : " + other.tag + " | Tag attendu : " + acceptedTag);

            audioSource.PlayOneShot(errorSound);
            if (score > 0)
            {
                score--;
                UpdateScoreText();
            }
            
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
