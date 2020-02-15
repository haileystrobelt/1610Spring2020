
using UnityEngine;

[RequireComponent(typeof(AudioListener))]

public class AudioListener : MonoBehaviour
{
    private AudioListener myAudListObj;
    void Start()
    {
        myAudListObj = GetComponent<AudioListener>();
        var nameLength = myAudListObj.name.Length;
    }


    void Update()
    {
        
    }
}
