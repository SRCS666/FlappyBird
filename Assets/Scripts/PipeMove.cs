using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
