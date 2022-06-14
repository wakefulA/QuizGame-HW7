using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{

    [Header("UI Elements")]
    [SerializeField] private Button FirstButton;
    [SerializeField] private Button SecondButton;
    [SerializeField] private Button ThirdButton;
    [SerializeField] private Button FourthButton;
    
    [SerializeField] private TextMeshProUGUI _buttonLabelFirstButton;
    [SerializeField] private TextMeshProUGUI _buttonLabelSecondButton;
    [SerializeField] private TextMeshProUGUI _buttonLabelThirdButton;
    [SerializeField] private TextMeshProUGUI _buttonLabelFourthButton;
    [SerializeField] private TextMeshProUGUI _questionLabel;

    [Header("Initial Setup")]
    [SerializeField] private StepSO _startStep;
    
    private StepSO _currentStep;
    
    private void Start()
    {
        CashStep(_startStep);
        FirstButton.onClick.AddListener(FirstButtonClicked);
        SecondButton.onClick.AddListener(SecondButtonClicked);
        ThirdButton.onClick.AddListener(ThirdButtonClicked);
        FourthButton.onClick.AddListener(FourthdButtonClicked);
    }

    private void FourthdButtonClicked()
    {
        NextStep();
    }

    private void ThirdButtonClicked()
    {
        NextStep();
    }

    private void SecondButtonClicked()
    {
        NextStep();
    }

    private void FirstButtonClicked()
    {
        NextStep();
    }
    
    private void CashStep(StepSO step)
    {
        _currentStep = step;
        _questionLabel.text = step.QuestionText;
        _buttonLabelFirstButton.text = step.FirstOption;
        _buttonLabelSecondButton.text = step.SecondOption;
        _buttonLabelThirdButton.text = step.ThirdOption;
        _buttonLabelFourthButton.text = step.FourthOption;
    }

    private void NextStep()
    {
        if (_currentStep.choices.Length == 0)
            SceneManager.LoadScene(2);
        
        else
        
        {
            StepSO _step = _currentStep.choices[0];
            CashStep(_step);
        }
    }
}

