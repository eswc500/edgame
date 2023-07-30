using UnityEngine;
using DG.Tweening;

public class FloatMovement : MonoBehaviour
{
    public float floatDuration = 1.0f; // Duraci�n de un ciclo completo de flotaci�n.
    public float floatHeight = 1.0f; // Altura m�xima de flotaci�n.

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
        StartFloating();
    }

    private void StartFloating()
    {
        // Calculamos la posici�n final de la flotaci�n.
        Vector3 targetPosition = initialPosition + Vector3.up * floatHeight;

        // Creamos un bucle infinito para la animaci�n de flotaci�n con Dotween.
        transform.DOMove(targetPosition, floatDuration)
            .SetEase(Ease.InOutQuad)
            .SetLoops(-1, LoopType.Yoyo); // Hacemos que el movimiento vuelva a la posici�n inicial (Yoyo) de forma infinita.
    }
}

