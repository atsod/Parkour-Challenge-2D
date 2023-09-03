using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    // Тело, спрайт и коллайдер персонажа
    private Rigidbody2D _playerBody;
    private SpriteRenderer _playerSprite;
    private BoxCollider2D _playerCollider;

    // Cкорость, направление перемещения и сила прыжка персонажа
    private float _moveSpeed;
    private Vector2 _jumpVector;
    private float _moveDirection;

    // Маска земли
    [SerializeField] private LayerMask _groundMask;

    // Состояния персонажа
    private bool _isGrounded;

    // Возможные цвета игрока
    private Color _greenColor;
    private Color _redColor;

    private void Awake()
    {
        _playerBody = GetComponent<Rigidbody2D>();
        _playerSprite = GetComponent<SpriteRenderer>();
        _playerCollider = GetComponent<BoxCollider2D>();

        _moveSpeed = 8f;
        _jumpVector = new Vector2(0f, 8f);

        _greenColor = new(0.1875223f, 0.8113208f, 0.7430928f, 1f);
        _redColor = new(0f, 0.5f, 0.45f, 1f);
    }

    void Update()
    {
        CollidersCheck();
        AllInputMovement();
        GroundCheckForPlayerColor();
    }

    private void AllInputMovement()
    {
        KeyboardMove();
        KeyboardJump();
    }

    // Движение вправо и влево стрелками и кнопка A и D
    private void KeyboardMove()
    {
        _moveDirection = Input.GetAxis("Horizontal");
        _playerBody.velocity = new Vector2(_moveDirection * _moveSpeed, _playerBody.velocity.y);
    }

    // Добавляем прыжок на пробел, если игрок стоит на земле
    private void KeyboardJump()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && _isGrounded)
            _playerBody.AddForce(_jumpVector, ForceMode2D.Impulse);
    }

    private void CollidersCheck()
    {
        float offsetNumber = Mathf.Sqrt(2f) - 1f;
        Vector2 offset = new(offsetNumber, offsetNumber);

        Vector2 playerPosition = new(transform.position.x, transform.position.y);
        Vector2 playerSize = new(_playerCollider.size.x, _playerCollider.size.y);

        _isGrounded = Physics2D.OverlapBox(playerPosition, playerSize + offset, transform.rotation.z, _groundMask);
    }

    private void GroundCheckForPlayerColor()
    {
        if (!_isGrounded)
        {
            _playerSprite.color = Color.Lerp(_redColor, _greenColor, Time.deltaTime * 1.5f);
        }
        else
        {
            _playerSprite.color = Color.Lerp(_greenColor, _redColor, Time.deltaTime * 1.5f);
        }
    }
}
