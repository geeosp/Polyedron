using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Light))]
public class InterpolateColor : MonoBehaviour
{
  //  private Light light;
    public Color[] colors;
    private int index;
    [Range(0, 0.025f)]
    public float velocity=.001f;
    private float actual;
    // Use this for initialization
    void Start()
    {
        index = 0;
        actual = 0;
     //   light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colors.Length > 0)
        {
            actual += velocity;
            if (actual >= 1)
            {
                actual -= 1;
                index = (index + 1) % colors.Length;
            }
            Color c2 = colors[index];
            Color c1 = colors[(index + 1) % (colors.Length)];

            float a, b,g,  r;
            a = c2.a*(1-actual) + c1.a*actual;
            b = c2.b * (1 - actual) + c1.b * actual;
            r = c2.r * (1 - actual) + c1.r * actual;
            g = c2.g * (1 - actual) + c1.g * actual;

            GetComponent<Light>().color = new Color(r, g, b, a);



        }



    }
}
