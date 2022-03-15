using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    private Rigidbody2D rb2d;
    private void Awake()
    {
        Debug.Log("Player Controller Awake");
        //rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        //float Vertical = Input.GetAxisRaw("Jump");
        MoveCharacter(Horizontal);
    }
    private void MoveCharacter(float Horizontal)
    {
        //move character horizontally
        Vector3 position = transform.position;
        position.x += Horizontal*speed*Time.deltaTime;
        transform.position = position;

        //move character vertically
        /*if(Vertical > 0)
        {
            rb2d.AddForce(new Vector2(0f,jump), ForceMode2D.Force);
        }*/
    }
}
