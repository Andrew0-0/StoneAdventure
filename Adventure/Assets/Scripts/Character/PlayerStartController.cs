using UnityEngine;

namespace Character
{
    public class PlayerStartController : MonoBehaviour
    {
        [SerializeField] private PlayerComponent _component;
        private PlayerModel _model;
        private PlayerPresenter _playerPresenter;
        public Rigidbody2D Rb;
        public bool onGrounD = true;
        public SpriteRenderer sprite;
        public Animator charAnimator;

        private float _horizontal;
        private float _vertical;
        private bool _jump;

        void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
            charAnimator = GetComponent<Animator>();
            sprite = GetComponent<SpriteRenderer>();
            _model = new PlayerModel(4.0f, 100.0f, Rb, onGrounD, sprite, charAnimator);
            _playerPresenter = new PlayerPresenter(_model, _component);
            _playerPresenter.Attach();
            _playerPresenter.Attach1();
        }

        void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            //_jump = Input.GetKeyDown("Space");
            _model.Move(new Vector2(_horizontal,_vertical));
            //_model.Jump(_jump);
            //_model.Jump(new Vector2(_horizontal, _jump));
        }
    }
}
