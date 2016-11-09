using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
public class MainMenuController : MonoBehaviour {

    public void OpenScene1()
    {
        SceneManager.LoadScene("Scene1");
    }


}
