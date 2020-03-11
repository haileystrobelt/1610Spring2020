using UnityEngine;

[CreateAssetMenu]

public class VectorData : ScriptableObject
{
    public Vector3 value;

    public void ChangePosition(Transform transformObj)
    {
        transformObj.position = value;
    }

    public void ChangeValueFromTransform(Transform transformObj)
    {
        value = transformObj.position;
    }

    public void ChangeVector3Data(VectorData vector3DataObj)
    {
        vector3DataObj.value = value;
    }
    
    
    
}
