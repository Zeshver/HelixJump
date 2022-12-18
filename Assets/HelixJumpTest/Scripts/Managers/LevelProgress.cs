using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{
    [SerializeField] private ScoresCollector ScoresCollector;

    private int currentLevel = 1;
    private int currentRecordScore = 0;
    public int CurrentLevel => currentLevel;
    public int CurrenRecordScore => currentRecordScore;

    protected override void Awake()
    {
        base.Awake();

        Load();
    }

#if UNITY_EDITOR
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) == true)
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.F2) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
#endif

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            currentLevel++;

            if (currentRecordScore < ScoresCollector.RecordScores)
            {
                currentRecordScore = ScoresCollector.RecordScores;
            }

            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("LevelProgress:CurrentLevel", CurrentLevel);
        PlayerPrefs.SetInt("Record:RecordScore", CurrenRecordScore);
    }

    private void Load()
    {
        currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
        currentRecordScore = PlayerPrefs.GetInt("Record:RecordScore", CurrenRecordScore);
    }

#if UNITY_EDITOR
    private void Reset()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
#endif
}
