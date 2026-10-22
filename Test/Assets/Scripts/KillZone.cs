using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour
{
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Rigidbody rb;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        startPosition = player.transform.position;
        startRotation = player.transform.rotation;
        rb = player.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Respawn(other.gameObject));
        }
    }

    private IEnumerator Respawn(GameObject player)
    {
        // Laat de speler verdwijnen
        player.SetActive(false);

        // Wacht 1 seconde
        yield return new WaitForSeconds(1f);

        // Zet de speler terug op het beginpunt
        player.transform.position = startPosition;
        player.transform.rotation = startRotation;

        // Zet de snelheid op nul
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        // Laat de speler weer verschijnen
        player.SetActive(true);
    }
}
