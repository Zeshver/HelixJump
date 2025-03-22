using UnityEngine;
using UnityEngine.UI;

public class MaterialManager : MonoBehaviour
{
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material finishMaterial;
    [SerializeField] private Material trapMaterial;

    [SerializeField] private SpriteRenderer ballSpriteRenderer;

    [SerializeField] private Image backgroundImage;
    [SerializeField] private Camera backgroundCamera;

    private Color[] defaultColor = new Color[3] { new Color(0.5f, 0.2f, 0.4f), new Color(0.6f, 0.3f, 0.6f), new Color(0.7f, 0.6f, 0.7f) };
    private Color[] ballColor = new Color[3] { new Color(0.9f, 0.5f, 0.3f), new Color(0.7f, 0.7f, 0.3f), new Color(0.4f, 0.7f, 0.3f) };
    private Color[] axisColor = new Color[3] { new Color(0.1f, 0.1f, 0.3f), new Color(0.1f, 0.2f, 0.3f), new Color(0.1f, 0.1f, 0.5f) };
    private Color[] finishColor = new Color[3] { new Color(0.2f, 0.8f, 0.1f), new Color(0.2f, 0.8f, 0.8f), new Color(0.3f, 0.7f, 0.6f) };

    private Color[] backgroundImageColor = new Color[3] { new Color(0.2f, 0.2f, 0.2f), new Color(0.8f, 0.8f, 0.8f), new Color(0.5f, 0.5f, 0.5f) };
    private Color[] backgroundCameraColor = new Color[3] { new Color(0.3f, 0.7f, 0.3f), new Color(0.7f, 0.7f, 0.3f), new Color(0.3f, 0.7f, 0.7f) };

    public Material BallMaterial => ballMaterial;

    private void Start()
    {
        defaultMaterial.color = defaultColor[Random.Range(0, 2)];
        ballMaterial.color = ballColor[Random.Range(0, 2)];
        axisMaterial.color = axisColor[Random.Range(0, 2)];
        finishMaterial.color = finishColor[Random.Range(0, 2)];
        trapMaterial.color = Color.red;
        
        backgroundImage.color = backgroundImageColor[Random.Range(0, 2)];
        backgroundCamera.backgroundColor = backgroundCameraColor[Random.Range(0, 2)];

        ballSpriteRenderer.color = ballMaterial.color;
    }
}
