using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float width;

    [SerializeField] private SpriteRenderer spriteRenderer;

    private Vector2 startSize;

    private void Start()
    {
        startSize = new(spriteRenderer.size.x,spriteRenderer.size.y);
    }

    private void Update()
    {
        spriteRenderer.size = new(spriteRenderer.size.x + speed * Time.deltaTime, spriteRenderer.size.y);

        if (spriteRenderer.size.x > width)
        {
            spriteRenderer.size = startSize;
        }
    }
}
