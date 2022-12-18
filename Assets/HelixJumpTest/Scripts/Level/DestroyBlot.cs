using UnityEngine;

public class DestroyBlot : MonoBehaviour
{
    [SerializeField] private float _destBlot;

    private void Update()
    {
        Destroy(gameObject, _destBlot);
    }
}
