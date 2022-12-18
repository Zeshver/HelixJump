using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress LevelProgress;
    [SerializeField] private BallController BallController;
    [SerializeField] private int scores;
    [SerializeField] private int recordScores;

    public int Scores => scores;
    public int RecordScores => recordScores;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty && BallController.Bonus == false)
        {
            scores += LevelProgress.CurrentLevel;

            if (recordScores < scores)
            {
                recordScores = scores;
            }
        }

        if (type == SegmentType.Empty && BallController.Bonus == true)
        {
            scores += LevelProgress.CurrentLevel * 2;

            if (recordScores < scores)
            {
                recordScores = scores;
            }
        }
    }
}
