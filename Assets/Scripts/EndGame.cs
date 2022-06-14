using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
    [SerializeField] private Button PlayAgainButton;
    private void Start()
    {
        PlayAgainButton.onClick.AddListener(PlayAgainButtonClicked);
    }

    private void PlayAgainButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
