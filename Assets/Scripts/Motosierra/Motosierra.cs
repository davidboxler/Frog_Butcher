using UnityEngine;

public class Motosierra : MonoBehaviour
{
    [SerializeField] private GameObject spriteMotosierra; // Referencia al sprite o parte visual

    private void OnEnable()
    {
        RanaVida.EventoPersonajeDerrotado += DesactivarMotosierra;
    }

    private void OnDisable()
    {
        RanaVida.EventoPersonajeDerrotado -= DesactivarMotosierra;
    }

    private void DesactivarMotosierra()
    {
        if (spriteMotosierra != null)
        {
            spriteMotosierra.SetActive(false);
        }
        else
        {
            gameObject.SetActive(false); // alternativa si no estás usando un hijo
        }
    }

    public void ReactivarMotosierra()
    {
        if (spriteMotosierra != null)
        {
            spriteMotosierra.SetActive(true);

            Animator animator = spriteMotosierra.GetComponent<Animator>();
            if (animator != null)
            {
                animator.Play("Idle"); // Asegurate de usar el nombre exacto de la animación inicial
            }
        }
        Debug.Log("Motosierra activada: " + spriteMotosierra.activeSelf);
    }
}
