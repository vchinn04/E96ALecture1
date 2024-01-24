using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float SPEED = 5f;
    [SerializeField] float jumpHeight = 10f;
    Vector3 DEFAULT_SCALE;
    Vector3 vel;

    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 direction =  ctx.ReadValue<Vector2>() * SPEED;
        Debug.Log(direction);
        Move(direction.x, direction.y);
        return;
    }

    private void Move(float x, float y)
    {
       vel= new Vector3(x, rb.velocity.y, y);
    }

   public void OnJump()
    {
        // TODO: check if player is on the ground, and call Jump()
        Jump();

    }

    private void Jump()
    {
        // TODO: Set the y velocity to some positive value while keeping the x and z whatever they were originally
        rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);

    }

    void DoFlatten(bool status)
    {
        //TODO: store input as a 2D vector and call Move()
        Debug.Log("FLATTEN!");
        if (status)
            transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.x * 1 / 2, transform.localScale.x * 2);
        else
            transform.localScale = DEFAULT_SCALE;

    }

    public void OnFlatten(InputAction.CallbackContext ctx)
    {
        DoFlatten(ctx.performed); 
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
  
        DEFAULT_SCALE = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(vel.x, rb.velocity.y, vel.z);
    }
}
