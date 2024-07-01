using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DevelopperConsole : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI consoleText;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private CommandExecutor commandExecutor;


    private void Start()
    {
        inputField.onEndEdit.AddListener(HandleInput);
    }

    private void HandleInput(string input)
    {
        string output = input + "\n";
        consoleText.text += output;
        consoleText.text += commandExecutor.ExcecuteCommand(input);
        inputField.text = string.Empty;
    }
}
