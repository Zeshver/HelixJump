using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform axis;
    [SerializeField] private Floor floorPrefabs;

    [Header("Settings")]
    [SerializeField] private int defaultFloorAmount;
    [SerializeField] private float floorHeight;
    [SerializeField] private int amountEmptySegment;
    [SerializeField] private int minTrapSegment;
    [SerializeField] private int maxTrapSegment;

    private float floorAmount = 0;
    public float FloorAmount => floorAmount;

    private float floorThickness = 0.5f;

    private float lastFloorY = 0;
    public float LastFloorY => lastFloorY;

    public void Generate(int level)
    {
        DestroyChild();

        floorAmount = defaultFloorAmount + level;

        axis.transform.localScale = new Vector3(1, floorAmount * floorHeight + floorHeight, 1);

        for (int i = 0; i < floorAmount; i++)
        {
            Floor floor = Instantiate(floorPrefabs, transform);
            floor.transform.Translate(0, i * floorHeight, 0);
            floor.name = "Floor" + i;


            if (i == 0)
            {
                floor.SetFinishSegment();
            }

            if (i > 0 && i < floorAmount - 1)
            {
                floor.SetRandomRotation();
                floor.AddEmptySegment(amountEmptySegment);
                floor.AddRandomTrapSegment(Random.Range(minTrapSegment, maxTrapSegment + 1));
            }

            if (i == floorAmount - 1)
            {
                floor.AddEmptySegment(2);
                lastFloorY = floor.transform.position.y + floorThickness;
            }
        }
    }

    private void DestroyChild()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == axis)
            {
                continue;
            }

            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
