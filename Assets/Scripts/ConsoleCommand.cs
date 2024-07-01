using UnityEngine;

public abstract class ConsoleCommand : ScriptableObject
{
    public string[] commandName;
    public abstract string Excecute(string[] args);
}
