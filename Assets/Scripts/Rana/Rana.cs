using System.Collections;
using UnityEngine;

    public class Rana : MonoBehaviour
    {
    public RanaVida PersonajeVida { get; private set; }
    public RanaAnimaciones PersonajeAnimaciones { get; private set; }

    private void Awake()
    {
        PersonajeVida = GetComponent<RanaVida>();
        PersonajeAnimaciones = GetComponent<RanaAnimaciones>();
    }

    public void RestaurarPersonaje()
    {
        PersonajeVida.RestaurarPersonaje();
        PersonajeAnimaciones.RevivirPersonaje();

        Motosierra motosierra = GetComponentInChildren<Motosierra>(true); // ← ¡IMPORTANTE!
        if (motosierra != null)
        {
            Debug.Log("Motosierra encontrada, reactivando...");
            motosierra.ReactivarMotosierra();
        }
        else
        {
            Debug.LogWarning("Motosierra NO encontrada como hijo.");
        }
    }
}
