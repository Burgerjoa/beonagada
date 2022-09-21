using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gradienttest : MonoBehaviour
{
    public Gradient gradient;
    [Range(0, 1)]
    public float t;

    private Image img;

    void Start ()
    {
        img = transform.GetComponent<Image>();
    }

    void update()
    {
        img.color = gradient.Evaluate(t);
    }
}
