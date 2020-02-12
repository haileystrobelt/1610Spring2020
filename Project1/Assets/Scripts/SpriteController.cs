using UnityEngine;

[RequireComponent(typeof(Sprite))]

public class SpriteController : MonoBehaviour
{

    public Color spriteColor = Color.red;
    public Color OffColor = Color.red;
    private SpriteRenderer spriteObj;
    
    
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        spriteObj.color = spriteColor;
    }

    private void OnDisable()
    {
        spriteObj.color = OffColor;
    }


    void Update()
    {
        
    }
}
