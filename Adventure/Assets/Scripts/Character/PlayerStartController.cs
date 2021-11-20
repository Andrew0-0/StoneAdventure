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

        void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
            charAnimator = GetComponent<Animator>();
            sprite = GetComponent<SpriteRenderer>();
            _model = new PlayerModel(4.0f, 100.0f, Rb, onGrounD, sprite, charAnimator);
            _playerPresenter = new PlayerPresenter(_model, _component);
            _playerPresenter.Attach();
        }

        void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            _model.Move(new Vector3(_horizontal,0,_vertical));
        }
    }
}
