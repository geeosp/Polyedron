using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    float distance = 0.01F;
    int mod;
    bool show;
    public Texture btnTexture;

    void OnGUI()
    {
        if (!btnTexture)
        {
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
        if (GUI.Button(new Rect(Screen.width-100, 10, 90, 90), btnTexture))
            Debug.Log("Clicked the button with an image");
            
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
}
