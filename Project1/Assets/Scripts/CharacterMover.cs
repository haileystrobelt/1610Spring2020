using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public Rigidbody rigbod;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //used FixedUpdate for physic functions
    { 
        rigbod.AddForce(0, 0, 2000 * Time.deltaTime); //adding Time.deltaTime will even out FPS advantages on differing computers
    }
}


//tutorial from https://www.youtube.com/watch?v=9ZEu_I-ido4 from Brackeys