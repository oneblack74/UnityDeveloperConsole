# 💻 Unity Developer Console

> A **modular developer console** for Unity, allowing you to execute custom commands directly from the game at runtime.

---

## ✨ Features

- 🧠 **Command Execution**  
  Type commands during gameplay to trigger custom logic.

- 🧩 **Modular Design**  
  Easily add and organize new commands directly through the **Unity Inspector**.

- 🗂️ **Scriptable Objects**  
  Each command is implemented as a **ScriptableObject** for easy reusability and separation of concerns.

---

## 🕹️ Usage

### 1. Scene Setup

- Create a **Canvas** in your scene
- Add:
  - A `TMP_InputField` (for user input)
  - A `TMP_Text` (to display output)

- Attach the following scripts:
  - `DeveloperConsole.cs`
  - `CommandExecutor.cs`

### 2. Inspector Setup

- On **CommandExecutor**, assign your list of custom `Command` ScriptableObjects
- On **DeveloperConsole**, assign:
  - The **InputField** reference
  - The **Text Output** reference
  - The **CommandExecutor** reference

### 3. Create Your Commands

- Right-click in the Project window  
  → `Create > Developer Console > Command`

Fill in the following for each command:

- **Command keyword** (e.g., `godmode`, `teleport`)
- **Description**
- Implement the command behavior in the associated method

---

## 🧪 Example

Typing:
```text
godmode
```
→ Activates god mode (if such a command exists in your setup).

---

## 📌 Project Status

🧪 In progress

---

## 👤 Author

Axel Brissy
    🔗 [GitHub](https://github.com/oneblack74)

---

## 📥 Installation

✅ Prerequisites
- Unity 2022.3.17f1
- Package Input System
- Package TextMeshPro

📦 Setup
1. Clone the repository:
   ```
   git clone https://github.com/oneblack74/UnityDeveloperConsole.git
   ```
2. Open the project in Unity
3. Open or create a scene and follow the Usage section

