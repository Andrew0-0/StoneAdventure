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

    private void OnMove(Vector2 vector2)
    {
        _component.Move(vector2 * _model.speed);
    }
}

public interface IController
{
}

