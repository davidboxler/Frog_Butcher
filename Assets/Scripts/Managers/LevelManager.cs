using System.Collections;
using UnityEngine;

    public class LevelManager : MonoBehaviour
    {

        [SerializeField] private Rana personaje;
        [SerializeField] private Transform puntoReaparicion;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (personaje.PersonajeVida.Derrotado)
                {
                    personaje.transform.localPosition = puntoReaparicion.position;
                    personaje.RestaurarPersonaje();
                }
            }
        }
    }
