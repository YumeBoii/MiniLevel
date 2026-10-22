using UnityEngine;
using System.Collections;

public class DoorUnlock : MonoBehaviour
{
    public Transform doorToOpen;
    public float openAngle = 90f;
    public float openSpeed = 2f;

    private bool isOpen = false;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    private void Start()
    {
        closedRotation = doorToOpen.localRotation;

        openRotation = closedRotation *
            Quaternion.Euler(0f, openAngle, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        KeyInventory inventory =
            other.GetComponent<KeyInventory>();

        if (inventory != null && inventory.hasKey && !isOpen)
        {
            isOpen = true;
            StartCoroutine(OpenDoor());
        }
        else if (inventory != null && !inventory.hasKey)
        {
            Debug.Log("This door is locked! Find the key.");
        }
    }

    private IEnumerator OpenDoor()
    {
        float time = 0f;
        Quaternion startingRotation = doorToOpen.localRotation;

        while (time < 1f)
        {
            time += Time.deltaTime * openSpeed;

            doorToOpen.localRotation = Quaternion.Slerp(
                startingRotation,
                openRotation,
                time
            );

            yield return null;
        }

        doorToOpen.localRotation = openRotation;

        Debug.Log("Door unlocked! You can proceed.");
    }
}