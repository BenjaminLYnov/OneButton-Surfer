using UnityEngine;
using UnityEngine.UI;

public class fondu : MonoBehaviour
{
    public float speedTransparence = 0.1f;
    
    float transparence = 0;

    void Update()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, transparence);
        if (transparence <= 1) transparence += speedTransparence * Time.deltaTime;
    }

}
