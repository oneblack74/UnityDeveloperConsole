using System.Collections.Generic;
using UnityEngine;

public class CommandExecutor : MonoBehaviour
{
    [SerializeField] private ConsoleCommand[] commands;

    private Dictionary<string[], ConsoleCommand> commandDictionary;

    private void Awake()
    {
        commandDictionary = new Dictionary<string[], ConsoleCommand>();
        foreach (var command in commands)
        {
            commandDictionary.Add(command.commandName, command);
        }
    }

    public string ExcecuteCommand(string input)
    {
        string[] inputSplit = input.Split(' ');
        foreach (var item in inputSplit)
        {
            Debug.Log("Item: <" + item + ">");
        }
        if (commandDictionary.ContainsKey(inputSplit))
        {
            string rep = commandDictionary[inputSplit].Excecute(inputSplit);
            return "Command executed: " + rep + "\n";
        }
        else
        {
            return "Command not found\n";
        }
    }

}
