using UnityEngine;

public class KeyInventory : MonoBehaviour
{
    public bool hasKey = false;

    public void CollectKey()
    {
        hasKey = true;
        Debug.Log("You picked up the key!");
    }
}