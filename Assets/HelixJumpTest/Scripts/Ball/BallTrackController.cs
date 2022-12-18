using UnityEngine;

public class BallTrackController : BallEvents
{
    [SerializeField] private GameObject sprite;
    [SerializeField] private GameObject levelTransform;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Empty)
        {
            var _sprite = Instantiate(sprite, new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z), Quaternion.Euler(90, Random.Range(1, 180), 0));
            _sprite.transform.SetParent(levelTransform.transform);
        }        
    }
}
