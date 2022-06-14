using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

public class StartScene : MonoBehaviour
{

    [SerializeField] private Button StartButton;

    private void Start()
    {
        StartButton.onClick.AddListener(StartButtonClicked);
    }

    private void StartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
