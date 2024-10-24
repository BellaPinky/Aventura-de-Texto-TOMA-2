using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get { return instance; }
    }

    [SerializeField] private GameObject messagePanel;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private GameObject interactionButtons;
    [SerializeField] private Button lookButton;
    [SerializeField] private Button useButton;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        HideMessage();
        HideInteractionButtons();
    }

    public void ShowMessage(string message)
    {
        messagePanel.SetActive(true);
        messageText.text = message;
        Invoke("HideMessage", 3f);
    }

    public void HideMessage()
    {
        messagePanel.SetActive(false);
    }

    public void ShowInteractionButtons()
    {
        interactionButtons.SetActive(true);
    }

    public void HideInteractionButtons()
    {
        interactionButtons.SetActive(false);
    }
}
