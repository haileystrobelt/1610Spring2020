using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
  
    
    void Update()
    {
        transform.position = player.position + offset;
    }
}

//tutorial from https://www.youtube.com/watch?v=HVB6UVcb3f8 from brackeys
