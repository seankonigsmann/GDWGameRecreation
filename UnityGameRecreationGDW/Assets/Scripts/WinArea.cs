using UnityEngine;
using TMPro;

public class WinArea : MonoBehaviour
{
    public GameObject winText; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //put this tag as the player
        {
            winText.SetActive(true);
        }
    }
}
