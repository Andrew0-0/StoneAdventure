using UnityEngine;
public class PlayerComponent : MonoBehaviour
{
    public void Move(Vector2 speed)
    {
        transform.Translate(speed*Time.deltaTime);
    }
}
