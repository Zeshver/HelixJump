using UnityEngine;

public class DestroySegment : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}
