using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

    float distance = 0.001F;
    int mod;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Definindo de quando em quando mover background
        mod = (int)Time.timeSinceLevelLoad % (int)10.0F;

        // Adicionando para não mover mais qunado tiver no fim da tela de fundo
        if (mod == 0 && transform.position.x >= -16)
        {
            transform.position -= transform.right * distance;
        }
    }
}
