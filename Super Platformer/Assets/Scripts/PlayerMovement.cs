using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    [SerializeField] GameObject die;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = this.transform.position;
        player.transform.rotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if(Input.GetButtonDown("Jump"))
        {
            animator.SetBool("IsJumping", true);
            jump = true;
        }
        // if(Input.GetButtonDown("Crouch"))
        // {
        //     crouch = true;
        // } else if(Input.GetButtonUp("Crouch"))
        // {
        //     crouch = false;
        // }
    }

    public void OnLanding() 
    {
        animator.SetBool("IsJumping", false);
    }
    // public void OnCrouching(bool isCrouching) {
    //     animator.SetBool("IsCrouching", isCrouching);
    // }
    void FixedUpdate() {
        // Move the character
        // Move holds (Direction, Crouch, Jump)
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy"){
            Destroy(gameObject);
            Instantiate(gameObject, player.position, player.rotation);
        }
    }
}
