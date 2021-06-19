
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{

    public string nextUI;

    private Button thisButton;

    private ButtonEvent buttonEventScript;

    void Start()
    {
        thisButton = GetComponent<Button>();
        buttonEventScript = GameObject.Find("MenuController").GetComponent<ButtonEvent>();
        thisButton.onClick.AddListener(buttonAction);
    }

    void buttonAction()
    {
        buttonEventScript.ButtonEventFunction(nextUI);
    }

}
