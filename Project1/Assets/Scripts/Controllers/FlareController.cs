
using UnityEngine;

[RequireComponent(typeof(Flare))]

public class FlareController : MonoBehaviour
{
    private Flare flareObj;

    void Start()
    {
        flareObj = GetComponent<Flare>();
        flareObj.GetInstanceID();
    }


    void Update()
    {
        
    }
}
