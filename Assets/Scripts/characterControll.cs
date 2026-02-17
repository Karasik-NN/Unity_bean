using UnityEngine;

public class characterControll : MonoBehaviour
{
    public float speed = 10f;
    private float screenWidth;

    void Start()
    {
        
        screenWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    void Update()
    {
        
        float moveInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector2.right * moveInput * speed * Time.deltaTime);

        float clampedX = Mathf.Clamp(transform.position.x, -screenWidth, screenWidth);
        transform.position = new Vector2(clampedX, transform.position.y);
    }
}
    