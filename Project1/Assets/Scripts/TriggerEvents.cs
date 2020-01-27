using UnityEngine;
using UnityEngine.Events;


public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent; 
    
    private void OnTriggerExit(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
