using UnityEngine;

[CreateAssetMenu(fileName = "SayHelloCommand", menuName = "ConsoleCommands/SayHelloCommand")]
public class SayHelloCommand : ConsoleCommand
{
    public override string Excecute(string[] args)
    {
        Debug.Log("Hello World!");

        return "Hello World!";
    }
}
