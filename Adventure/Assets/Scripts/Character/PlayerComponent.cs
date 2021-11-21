using UnityEngine;
public class PlayerComponent : MonoBehaviour
{
    public void Move(Vector2 speed)
    {
        transform.Translate(speed*Time.deltaTime);
    }

    public void Jump(float jumpForce, Rigidbody2D rb)
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
