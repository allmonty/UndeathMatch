using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public Vector3 moveDir;

    [SerializeField] float moveSpeed = 2f;

    Rigidbody rigid;
    Animator anim;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        look();
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        rigid.velocity = new Vector3(moveDir.x * moveSpeed, rigid.velocity.y, moveDir.z * moveSpeed);

        if(moveDir.magnitude > 0f)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
    }

    void look()
    {
        transform.LookAt(transform.position + moveDir.normalized);
    }
}
