using UnityEngine;
[CreateAssetMenu(fileName = "Quiz", menuName = "Configs/Step" )]
public class StepSO : ScriptableObject
{
    public string QuestionText;

    [TextArea(4, 8)]
    public string FirstOption;

    [TextArea(4, 6)]
    public string SecondOption;
    
    [TextArea(4, 7)]
    public string ThirdOption;
    
    [TextArea(4, 8)]
    public string FourthOption;

    public StepSO[] choices;
}
