using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text recordScoreText;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            scoreText.text = scoresCollector.Scores.ToString();

            recordScoreText.text = "Рекорд: " + levelProgress.CurrenRecordScore.ToString();
        }
    }
}
