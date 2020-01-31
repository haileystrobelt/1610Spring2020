using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseUpEvent, mouseButtonEvent, mouseDragEvent, mouseOverEvent, mouseExitEvent;
    
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }

    private void OnMouseUpAsButton()
    {
        mouseButtonEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }
    
    //Type things, try typing On... ect.
    //click on dictionary on different things
    //read about them
}
