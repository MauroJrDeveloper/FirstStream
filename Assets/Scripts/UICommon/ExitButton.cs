using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ExitButton : MonoBehaviour
{

    private Button thisButton;

    void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(ExitButtonFunction);
    }

    void ExitButtonFunction()
    {
        #if UNITY_EDITOR
            EditorApplication.Exit(0);
        #endif

       #if !UNITY_EDITOR
            Application.Quit();
        #endif
    }

}
