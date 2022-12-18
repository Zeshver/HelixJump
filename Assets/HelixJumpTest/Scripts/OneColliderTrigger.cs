using UnityEngine;

public abstract class OneColliderTrigger : MonoBehaviour
{
    private Collider lastCollider;

    protected virtual void OnOneTriggerEnter(Collider other) { }
    protected virtual void OnOneTriggerExit(Collider other) { }

    private void OnTriggerEnter(Collider other)
    {
        if (lastCollider != null && lastCollider != other) return;

        lastCollider = other;

        OnOneTriggerEnter(other);

        Debug.Log("Jupm");
    }

    private void OnTriggerExit(Collider other)
    {
        if (lastCollider == other)
        {
            lastCollider = null;
        }

        OnOneTriggerExit(other);

        Debug.Log("Down");
    }
}
