using UnityEngine;

public class WallColorChange : MonoBehaviour
{
    public Color impactColor = Color.red;

    private Renderer wallRenderer;

    private void Start()
    {
        wallRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            wallRenderer.material.color = impactColor;
            Debug.Log("BALL HIT THE WALL!");
        }
    }
}
