using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log($"Batemos em um {collisionInfo.collider.name}");
            movement.enabled = false;
        }
    }
}
