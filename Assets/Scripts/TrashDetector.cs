using UnityEngine;

public class TrashBin : MonoBehaviour
{
    [SerializeField] private string acceptedTag; // Tag des objets acceptés par la poubelle
    [SerializeField] private AudioClip successSound; // Son de succès (objet bien trié)
    [SerializeField] private AudioClip errorSound; // Son d'erreur (objet mal trié)
    [SerializeField] private AudioSource audioSource; // AudioSource qui jouera le son

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet qui entre dans la zone a le bon tag
        if (other.CompareTag(acceptedTag))
        {
            // Si l'objet est le bon, joue le son de succès
            Debug.Log("Bon tri ! Objet accepté : " + other.name);

            if (audioSource != null && successSound != null)
            {
                audioSource.PlayOneShot(successSound); // Joue le son de succès
            }
        }
        else
        {
            // Si l'objet est incorrect, joue le son d'erreur
            Debug.Log("Erreur de tri. Objet incorrect : " + other.name);

            if (audioSource != null && errorSound != null)
            {
                audioSource.PlayOneShot(errorSound); // Joue le son d'erreur
            }
        }
    }
}
