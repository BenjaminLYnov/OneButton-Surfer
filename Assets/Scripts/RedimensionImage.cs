using UnityEngine;

public class RedimensionImage : MonoBehaviour
{
    public float pourcentage = 100;
    private RectTransform rt;
    private float size;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        pourcentage = pourcentage / 100;
        size = Screen.width * pourcentage;
        rt.sizeDelta = new Vector2(size, size);
    }

    void Update()
    {
        size = Screen.width * pourcentage;
        rt.sizeDelta = new Vector2(size, size);
    }
}
