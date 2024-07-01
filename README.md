# Unity Developer Console

A modular developer console for Unity, allowing you to execute custom commands directly from the game.

## Features

- **Command Execution**: Enter commands in the console to execute various actions.
- **Modular Design**: Easily add new commands via the Unity Inspector.
- **Scriptable Objects**: Commands are created using scriptable objects, making them reusable and maintainable.

## Getting Started

### Prerequisites

- Unity 2022.3.17f1 (This project was created and tested with this version)

### Installation

1. Clone the repository to your local machine:
   ```sh
   git clone https://github.com/oneblack74/UnityDeveloperConsole.git
   ```

2. Clone the project in Unity

### Usage

1. Setting Up the Scene.

- Create a canvas with an InputField and a TextMeshProUGUI as a child.
- Put the DeveloperConsole and CommandExecutor scripts on it. The CommandExecutor script will contain a list of ScriptableObjects representing the commands. On the DeveloperConsole script put the references of the two children of the gameObject and the CommandExecutor script.


## Status
(Project under development)
