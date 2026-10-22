using UnityEngine;

public class HealthBar : MonoBehaviour
{

    float health = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Press U to increase health by 10
        if (Input.GetKeyDown(KeyCode.U))
        {
            health += 10f;
        }

        // Press O to decrease health by 10
        if (Input.GetKeyDown(KeyCode.O))
        {
            health -= 10f;
        }

        // Don't let health go above 100
        if (health > 100f)
        {
            health = 100f;
        }

        // Don't let health go below 0
        if (health < 0f)
        {
            health = 0f;
        }

        // Check the current health
        if (health <= 0f)
        {
            Debug.Log("Game Over");
        }
        else if (health > 80f)
        {
            Debug.Log("Excellent health");
        }
        else if (health > 50f)
        {
            Debug.Log("Good health");
        }
        else if (health > 20f)
        {
            Debug.Log("Low health");
        }
        else
        {
            Debug.Log("Critical health");
        }
    
    }
}
