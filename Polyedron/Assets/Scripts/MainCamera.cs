using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    float distance = 0.01F;
    int mod;
    bool show;
    public Texture btnTexture;
    public float speed = 1f;

    void OnGUI()
    {
        if (!btnTexture)
        {
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
        if (GUI.Button(new Rect(Screen.width - 100, 10, 90, 90), btnTexture))
        {
            Debug.Log("Clicked the button with an image");
            if (gameObject.name=="Cube")
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0.1f, 0.0f);
            }
			if (gameObject.name == "Sphere") {
				transform.position += new Vector3(speed * Time.deltaTime, 0.1f, 0.0f);
			}
			if (gameObject.name == "Triangle") {

			}
        }
        

            
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
}
