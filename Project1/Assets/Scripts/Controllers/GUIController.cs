
using UnityEngine;

[RequireComponent(typeof(GUI))]

public class GUIController : MonoBehaviour
{
    private GUI guiObj;
    
    
    void Start()
    {
        guiObj = GetComponent<GUI>();
        var ns = guiObj.GetType().Namespace;
    }


    void Update()
    {
        
    }
}
