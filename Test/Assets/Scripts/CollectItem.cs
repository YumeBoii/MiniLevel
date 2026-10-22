using UnityEngine;

public class CollectItem : MonoBehaviour
{
   void Start()
   {

   }

   void Update()
   {

   }

   private void OnTriggerEnter(Collider other)
   {
    Debug.Log(other.tag);

    if(other.CompareTag("Coin"))
    {
        
    }
   }
}
