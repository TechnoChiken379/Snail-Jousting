using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MovementButBetter : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2;
    [SerializeField] public float walkSpeed = 4f;



    private Vector3 moveDirection;
    private Vector3 moveDirectionZ;
    private Vector3 moveDirectionX;
    private Vector3 velocity;



    public float gravityValue = -9.81f;
    public float jumpHeight = 3f;

    private CharacterController characterController;



    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>(); // Get the character controller
    }



    // Update is called once per frame
    void Update()
    {
        Move(); // Shmove
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Death")) // If touch thing that makes dead
        {
            SceneManager.LoadScene("DeathScreen"); // Dead
        }
    }

    private void Move()
    {
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // If you're on the floor and your Y velocity is smaller than 0, make it (y velo) -2
        }



        float moveZ = Input.GetAxis("Vertical"); // yeah
        float moveX = Input.GetAxis("Horizontal"); // floats



        moveDirectionZ = new Vector3(0, 0, moveZ);
        moveDirectionX = new Vector3(moveX, 0, 0);
        moveDirection = transform.TransformDirection(moveDirectionZ + moveDirectionX);



        if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
        {
            Walk();
        }

        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
            if (moveDirection != Vector3.zero)
            {
                Idle();
            }
        }

        //characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        velocity.y += gravityValue * Time.deltaTime; // applies gravity
        moveDirection += velocity;
        characterController.Move(moveDirection * Time.deltaTime);
    }



    private void Walk()
    {
        moveDirection *= walkSpeed;
    }

    private void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravityValue); 
    }
    private void Idle() { }
}