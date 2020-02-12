using UnityEngine;

[RequireComponent(typeof(Light))]

public class LightController : MonoBehaviour
{
    private Light lightControl;
   

    void Start()
    {
        lightControl = GetComponent<Light>();
        lightControl.intensity = 0f;
    }


    void Update()
    {
        
    }
}
