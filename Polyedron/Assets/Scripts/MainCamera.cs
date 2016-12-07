using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    int mod;
    bool show;
    public Texture btnTexture;
    public float speed = 200.0f;


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

			// Golpe (para ativar, só precisa tirar o comentário
			//GameObject.Find("Player").transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

			// Pulo Duplo
			GameObject.Find("Player").transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
			GameObject.Find("Player").transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

			// Atirar Projétil
			//GameObject.Find("Projectile").transform.position = GameObject.Find("Player").transform.position;
			//GameObject.Find("Projectile").transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            
        }
        

            
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
}
