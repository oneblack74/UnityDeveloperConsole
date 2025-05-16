using UnityEngine;
using UnityEngine.Events;

public abstract class ConsoleCommand : ScriptableObject
{
    public string commandName;
    public string[] options;
    public abstract string Excecute(string[] args);

}
