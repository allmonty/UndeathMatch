using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public Vector3 moveDir;

    [SerializeField] float moveSpeed = 2f;

    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
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
    }

    void look()
    {
        transform.LookAt(transform.position + moveDir.normalized);
    }
}
