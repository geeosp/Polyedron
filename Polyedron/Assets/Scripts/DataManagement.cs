using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataManagement : MonoBehaviour
{
	public static DataManagement datamanagement;
	public int highScore;
	public int currentEnergy;
	public int energyCollected;
	
	void Awake () {
		if (datamanagement == null) {
			DontDestroyOnLoad (gameObject);
			datamanagement = this;
		} else if (datamanagement != this) {
			Destroy (gameObject);
		}
	}

	public void increaseEnergy() {
		datamanagement.energyCollected++;
		Debug.Log (datamanagement.energyCollected);
	}

	public void SaveData() {
		FileStream file = File.Create (Application.persistentDataPath + "/gameInfo.dat");
		gameData data = new gameData ();
		data.highScore = highScore;
		data.energyCollected = energyCollected;
		BinaryFormatter bf = new BinaryFormatter ();
		bf.Serialize (file, data);
		file.Close ();
	}

	public void LoadData() {
		if (File.Exists (Application.persistentDataPath + "/gameInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
			gameData data = (gameData) bf.Deserialize (file);
			file.Close ();
			highScore = data.highScore;
			energyCollected = data.energyCollected;
		}
	}

}

[Serializable]
class gameData {
	public int highScore;
	public int energyCollected;


}