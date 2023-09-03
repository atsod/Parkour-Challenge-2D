using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    // ����, ������ � ��������� ���������
    private Rigidbody2D playerBody;
    private SpriteRenderer playerSprite;
    private BoxCollider2D playerCollider;

    // C�������, ����������� ����������� � ���� ������ ���������
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector2 jumpVector;
    private float moveDirection;

    // ����� �����
    [SerializeField] private LayerMask groundMask;

    // ��������� ���������
    private bool isGrounded;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        playerCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        CollidersCheck();
        KeyboardMove();
        KeyboardJump();
        GroundCheckForPlayerColor();
    }

    // �������� ������ � ����� ��������� � ������ A � D
    private void KeyboardMove()
    {
        moveDirection = Input.GetAxis("Horizontal");
        playerBody.velocity = new Vector2(moveDirection * moveSpeed, playerBody.velocity.y);
    }

    // ��������� ������ �� ������, ���� ����� ����� �� �����
    private void KeyboardJump()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && isGrounded)
            playerBody.AddForce(jumpVector, ForceMode2D.Impulse);
    }

    private void CollidersCheck()
    {
        float offsetNumber = Mathf.Sqrt(2f) - 1f;
        Vector2 offset = new(offsetNumber, offsetNumber);

        Vector2 playerPosition = new(transform.position.x, transform.position.y);
        Vector2 playerSize = new(playerCollider.size.x, playerCollider.size.y);

        isGrounded = Physics2D.OverlapBox(playerPosition, playerSize + offset, transform.rotation.z, groundMask);
    }

    private void GroundCheckForPlayerColor()
    {
        Color greenColor = new(0.1875223f, 0.8113208f, 0.7430928f, 1f);
        Color redColor = new(0f, 0.5f, 0.45f, 1f);

        if (!isGrounded) playerSprite.color = Color.Lerp(redColor, greenColor, Time.deltaTime * 1.5f);
        else playerSprite.color = Color.Lerp(greenColor, redColor, Time.deltaTime * 1.5f);
    }
}
