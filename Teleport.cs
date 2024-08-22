using UnityEngine;

public class Teleport : MonoBehaviour
{
     public Transform teleportDestination;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) // Проверяем, что в коллайдер вошел игрок
        {
            other.transform.position = teleportDestination.position; // Телепортируем игрока в точку teleportDestination
        }
    }
}
