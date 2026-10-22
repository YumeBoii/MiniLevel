using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int health = 20;

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            if (playerHealth.health < playerHealth.maxHealth)
            {
                playerHealth.health += health;

                if (playerHealth.health > playerHealth.maxHealth)
                {
                    playerHealth.health = playerHealth.maxHealth;
                }

                Debug.Log("Health restored!");

                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Health already full!");
            }
        }
    }
}