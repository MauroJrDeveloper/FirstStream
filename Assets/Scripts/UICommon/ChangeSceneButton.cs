
using UnityEngine;
using UnityEngine.UI;

public class ChangeSceneButton : MonoBehaviour
{

    private Button thisButton;
    public string nextScene;

    void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        SceneChanger.SceneController(nextScene);
    }

}
