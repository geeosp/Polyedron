using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl control;
    /**Essa classe é pra ser colocada em oda a cena que precise saber sobre o estado do jogador
     * qualquer coisa que precise ser acessada por qualquer cena coloca aqui
     * */
     public float sceneSpeed = 1;
	public GameObject scoreUI;
	public GameObject highScoreUI;

	void Update(){
		if (DataManagement.datamanagement.currentEnergy > DataManagement.datamanagement.highScore) {
			DataManagement.datamanagement.highScore = DataManagement.datamanagement.currentEnergy;
		}
		scoreUI.GetComponent<Text>().text = ("Score " + DataManagement.datamanagement.energyCollected.ToString());
		highScoreUI.GetComponent<Text>().text = ("High Score " + DataManagement.datamanagement.highScore.ToString());
	}

    // Use this for initialization
    void Awake()
    {
        // If a GameControl instance has yet to be created
        if (control == null)
        {
            // Ensure this instance is preserved across scenes
            DontDestroyOnLoad(gameObject);
            // Set the single GameControl instance to this one
            control = this;


        }
        // If a GameControl instance exists and this is NOT it
        else if (control != this)
        {
            // Destroy this GameObject
            Destroy(gameObject);
            return;
        }
    }

}
