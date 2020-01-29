using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour

{
    public int myInt;
    public float myFloat;
    public string myString;
    public UnityEvent myEventOne;
    public UnityEvent myEventTwo;
    public UnityEvent myEventThree;
    
    // Start is called before the first frame update
    void Start()
    {
        myEventOne.Invoke();
        myEventTwo.Invoke();
        myEventThree.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
       print((myInt));
       print((myFloat));
       print((myString));
    }
}
