# Mini-level — Inleveren

**Naam:** Colin van Tongeren  
**Klas:**  SD1C    
**Datum:**  28/10/2026   
**Les:** GDV Les 6

---

## Wat heb ik gemaakt?

 Mijn mini level stamt af van het populaire spel Super Mario, het doel is om de key op te pakken en dan bij de deur proberen te komen om de deur open te maken en het level te behalen.  

  

...

---

## Screenshot / GIF van je level

 <img width="1636" height="778" alt="Mini_Level_GIF" src="https://github.com/user-attachments/assets/3477ce24-7757-43c6-8a0e-b8f055755484" />  
 

![Mini-level preview](images/level.gif)  



---

## Bewegend object

 Het object dat beweegt is de key die gebruikt wordt om de deur op het einde te open en de key draait door de code die ik de key heb gegeven.   

...

```csharp
public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 90f;

    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
```

---

## Collider of trigger

 De platformen hebben een collider en de killzones hebben triggers.   

...

```csharp
 private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Respawn(other.gameObject));
        }
    }
```

---

## Logica met `if` of `switch`

 De keuze die ik gemaakt had voor het mini level was om de player een key te moeten laten oppakken die de player dan zou moeten gebruiken om de deur op het einde van de level te kunnen openen.   

...

```csharp
public class LevelFinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Congratulations! Level Complete!");
        }
    }
}
```

---

## Eigen extra idee

 Ik heb niet echt een eigen extra feature toegevoegd aan de mini level dus er is niet veel wat ik hier kan zeggen.   

...

```csharp

```

---

## Evaluatie

### Wat ging goed? en waarom?

 Wat wel makkelijk was was het gebruiken van mijn scripts die ik al had gemaakt in de vorige opdrachten en ik ben best wel trots op het eind resultaat.   

...

### Wat vond je lastig? en waarom?

 Een ding waar ik wel tegen op liep was het feit dat ik de key eigenlijk zwaartekracht wou geven, maar het weigerde hou dan ook om normaal zwaartekracht te krijgen, dus ik had het uiteindelijk gewoon laten gaan.   

...

### Wat zou je een volgende keer anders doen?

 Om eerst meer research te doen over hoe ik dingen kan maken om dingen te laten werken.   

...
