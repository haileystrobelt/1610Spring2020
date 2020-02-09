using UnityEngine;

public class PlayerCollision : MonoBehaviour


{
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
    }

   
}

//tutorial from https://www.youtube.com/watch?v=gAB64vfbrhI