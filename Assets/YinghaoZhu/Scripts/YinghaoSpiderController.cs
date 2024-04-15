using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YinghaoSpiderController : MonoBehaviour
{
    Animator animator;
    public float speed = 5f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update(){
        Move();
    }

    private void Move(){
        float horizontalInput = - Input.GetAxis("Horizontal");
        float verticalInput = - Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(movement * speed * Time.deltaTime);
        
        if (movement != Vector3.zero)
        {
            animator.SetBool("SpiderWalk", true); 
        }
        else
        {
            animator.SetBool("SpiderWalk", false); 
        }
    }
}
