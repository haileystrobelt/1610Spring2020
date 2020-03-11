using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    private Camera cameraObj;
    
    
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.depth = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
