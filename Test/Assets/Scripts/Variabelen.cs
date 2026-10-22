using UnityEngine;

public class Variabelen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Variabelen aanmaken
        int mijnLeeftijd = 16;
        float mijnLengte = 1.98f;
        string mijnNaam = "Colin";
        bool hebIkHonger = true;

        // Variabelen gebruiken in Debug.Log
        Debug.Log("Mijn naam is: " + mijnNaam);
        Debug.Log("Ik ben " + mijnLeeftijd + " jaar oud");
        Debug.Log("Mijn lengte is: " + mijnLengte + " meter");
        Debug.Log("Heb ik honger? " + hebIkHonger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
