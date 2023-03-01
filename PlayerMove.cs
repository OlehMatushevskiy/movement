
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float Horizontal;
    private float Vertical;
    public float Speed;

    private Camera _mainCamera;
    private Rigidbody2D rb;

    private void Start()
    {
        _mainCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //код для того, щоб гравець дивився за мишею
        Vector3 WorldPos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        WorldPos.z = 0;
        Vector2 Dir = new Vector2(WorldPos.x - transform.position.x, WorldPos.y - transform.position.y);
        transform.right = Dir;

        //код для пересування гравця
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Speed * Horizontal * Time.deltaTime, Speed * Vertical * Time.deltaTime);
    }
}

