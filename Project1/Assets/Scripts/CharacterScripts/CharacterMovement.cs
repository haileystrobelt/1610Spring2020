using UnityEngine;

[RequireComponent((typeof(CharacterController)))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    private int jumpCount = 0;
    public int jumpCountMax = 2;

    private Animator anim;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }

        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping",false);
        }

       
        
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;

        }
        
        positionDirection.y += gravity;
        //positionDirection.z = Input.GetAxis("Horizontal") * speed;
        controller.Move(positionDirection*Time.deltaTime);

        
        //flipping character
        if (positionDirection.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (positionDirection.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //isWalking
        if (positionDirection.x == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }
        
        if (positionDirection.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //isJumping
        
    }
}

//Referenced youtube.com/watch?v=FTxQKHG5WCA&list=PL1_0JJtF9SoIOTlS5w_j6w1VaB-H5f0-T&index=2
