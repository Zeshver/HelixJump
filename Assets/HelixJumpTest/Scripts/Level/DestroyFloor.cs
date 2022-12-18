using UnityEngine;

public class DestroyFloor : MonoBehaviour
{
    [SerializeField] private Rigidbody segment;
    [SerializeField] private Collider segmentCollider;
    [SerializeField] private Transform player;

    private float timerRate = 0.2f;
    private float timerMin = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        segment = GetComponent<Rigidbody>();
        segmentCollider = GetComponent<Collider>();

        segment.isKinematic = true;
        segment.useGravity = false;
    }

    private void Update()
    {
        if (transform.position.y > player.position.y) 
        { 
            timerRate -= Time.deltaTime;

            if (timerRate <= timerMin)
            {
                transform.parent = null;
                segment.isKinematic = false;
                segment.useGravity = true;
                segment.AddRelativeForce(60, 40, 0);

                segmentCollider.enabled = false;

                enabled = false;
            }
        }
    }
}
