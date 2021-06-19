using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneChanger 
{

    public static void SceneController(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
