using UnityEngine;

public class PlayerPresenter : IController
{
    private readonly PlayerModel _model;
    private readonly PlayerComponent _component;

    public PlayerPresenter(PlayerModel model, PlayerComponent component)
    {
        _model = model;
        _component = component;
    }

    public void Attach()
    {
        _model.OnMove += OnMove;
    }

    public void Detach()
    {
        _model.OnMove -= OnMove;
    }
    
    public void Attach1()
    {
        _model.OnJump += OnJump;
    }

    private void OnJump(Vector2 obj)
    {
        throw new System.NotImplementedException();
    }

    public void Detach1()
    {
        _model.OnJump -= OnJump;
    }

    private void OnMove(Vector2 vector2)
    {
        _component.Move(vector2 * _model.speed);
    }

    private void OnJump(float jumpForce, Rigidbody2D rb)
    {
        _component.Jump(jumpForce, rb);
    }
}

public interface IController
{
}

