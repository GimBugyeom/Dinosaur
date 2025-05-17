using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    [Header("참조")]
    public Rigidbody2D rigid;
    [Header("설정")]
    public float jumppower = 1f;
    public float groundCheckDistance = 1f;
    public LayerMask groundLayer;
    private bool isGrounded;
 
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 
            groundCheckDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(jumppower * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
