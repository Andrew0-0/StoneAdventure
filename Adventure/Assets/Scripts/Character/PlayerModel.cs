using System;
using UnityEngine;
public class PlayerModel
{
    public event Action<Vector2> OnMove;
    public float speed;
    public Rigidbody2D rb;
    public float jumpForce;
    public bool onGround;
    public SpriteRenderer sprite;
    public Animator charAnimator;
    //public readonly float MaxSpeed;
    //public readonly float Acceleration;you dyrak?


    public PlayerModel(float Speed, float JumpForce, Rigidbody2D Rb, bool on_ground, SpriteRenderer Sprite, Animator CharAnimator)
    {
        speed = Speed;
        jumpForce = JumpForce;
        rb = Rb;
        onGround = on_ground;
        sprite = Sprite;
        charAnimator = CharAnimator;
    }

    public void Move(Vector2 vector2)
    {
        OnMove?.Invoke(vector2);
    }
}

