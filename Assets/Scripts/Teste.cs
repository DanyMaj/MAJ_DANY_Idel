using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public class ExampleClass : MonoBehaviour
{
    IEnumerator WaitAndPrint()
    {
        // Suspendre l'exécution pendant 5 secondes
        yield return new WaitForSeconds(5);
        print("Attendre et imprimer " + Time.time);
    }

    IEnumerator Start()
    {
        print("Démarrage de " + Time.time);

        // Lancer la fonction WaitAndPrint en tant que coroutine
        yield return StartCoroutine("AttendreEtImprimer");
        print("Terminé " + Time.time);
    }
}

// Cet exemple appelle une coroutine et poursuit l'exécution de la fonction en parallèle. 

using UnityEngine;
using System.Collections; 

public class ExampleClass : MonoBehaviour
{

    private IEnumerator coroutine;

    void Start()
    {
        // - Après 0 seconde, affiche « Démarrage à 0,0 »
        // - Après 0 seconde, affiche « Avant que WaitAndPrint ne se termine 0.0 »
        // - Après 2 secondes, affiche « WaitAndPrint 2.0 »
        print("Démarrage de " + Time.time);

        // Démarrage de la fonction WaitAndPrint en tant que coroutine. 

        coroutine = WaitAndPrint(2.0f);
        DémarrerCoroutine(coroutine);

        print("Avant que WaitAndPrint ne se termine " + Time.time);
    }

    // toutes les 2 secondes, exécuter print()
    privé IEnumerator WaitAndPrint(float waitTime)
    {
        tant que(vrai)
        {
            yield renvoie new WaitForSeconds(waitTime);
            print("Attendre et imprimer " + Time.time);
        }
    }
}