# ATECQuiZ

# 🎯 ATECQuiZ - Quiz Game

![CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![dotNET](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![XML](https://img.shields.io/badge/XML-FF6600?style=for-the-badge&logo=xml&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)
![ATEC](https://img.shields.io/badge/Training-TPSI%20%7C%20ATEC-darkgreen?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen?style=for-the-badge)

> C# Windows Forms application developed as a project for the Programming course of the CET TPSI program at ATEC.
>
> ATECQuiZ is a quiz game with multiple themes, progressive difficulty levels, and a local highscore system.

---

## 📌 About the Project

**ATECQuiZ** was developed as a project for the **Structured Programming ** course unit of the **CET TPSI** program at **ATEC — Training Academy**.

The goal is to implement a complete quiz game applying Windows Forms concepts and XML data handling taught throughout the course.

---

## ✨ Features

| Feature | Description |
|---|---|
| 🎨 Theme Selection | Choose between Sports, Cinema, History, or Mix |
| 🏆 Progressive Levels | 3 difficulty levels — need 4/5 correct answers to advance |
| ❓ Random Questions | Questions are shuffled on every game |
| ✅ Visual Feedback | Buttons turn green (correct) or red (wrong) |
| 🎵 Background Music | Music plays during the game and stops at the end |
| 👤 Player Name | Enter your name after finishing to save your score |
| 📋 Highscores | Top 10 ranking sorted by score, saved locally |
| 💾 Persistence | Scores saved in a local `.txt` file |
| 📄 XML Questions | All questions loaded from an external XML file |

---

## 🗂️ Project Structure

```
ATECQuiZ/
├── Form1.cs                        # Main menu — theme and navigation buttons
├── FormJogo.cs                     # Game screen — questions, answers, scoring
├── FormFim.cs                      # End screen — result message and final score
├── FormNome.cs                     # Player name input dialog
├── FormHighscores.cs               # Top 10 leaderboard screen
├── Resources/
│   ├── QuizQuestions.xml           # All quiz questions by theme and level
│   ├── musica_quiz.mp3             # Background music for the game
│   ├── btn_Desporto.png            # Theme button images
│   ├── btn_Cinema.png
│   ├── btn_Historia.png
│   └── btn_Mix.png
├── imagem_fundo.png                # Main menu background image
└── highscores.txt                  # Local highscore storage (auto-generated)
```

---

## 🎮 How to Play

1. On the main menu, choose a **theme** (Sports, Cinema, History, or Mix)
2. Answer **5 questions** per level — you need at least **4 correct** to advance
3. Complete all **3 levels** to win the game
4. At the end, enter your **name** to save your score
5. Check the **Highscores** to see the Top 10 ranking

---

## ▶️ How to Run

1. Clone the repository:
```bash
git clone https://github.com/ClaudiaAlfieri/ATECQuiZ.git
```

2. Open the solution in **Visual Studio**

3. Build and run the project (`F5` or **Debug → Start Debugging**)

> Requires **.NET Framework 4.7.2** and **Windows OS**.

---

## 🛠️ Technologies Used

- **C#** — main language
- **.NET Framework 4.7.2** — application framework
- **Windows Forms** — graphical user interface
- **XML** — question storage and loading
- **WinMM (mciSendString)** — background music playback
- **Git** — version control
- **GitHub** — remote repository

---

## 👩‍💻 Author

This project was developed by **Cláudia Alfieri** as a project for the Structured Programming course of the CET TPSI program at ATEC.

---

Made with ❤️, lots of `MessageBox.Show()` and a fair amount of XML along the way 🎯🚀
