using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange; // reference to all goals
    private bool isGameOver = true;
    private float elapsedTime = 0;
    private bool isRunning = true;
    void Update()
    {
        // if all goals are solved then isGameOver true
        isGameOver = blue._isSolved && green._isSolved && red._isSolved &&
        orange._isSolved;

        //increase the passed time 
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    void OnGUI()
    {
        // if game is over determine how much time passed
        if (isGameOver)
        {
            isRunning = false;
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 125, 60, 50);
            GUI.Label(rect2, "Good Job!");


            GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
            GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
        }

        if (isRunning)
        {
                // If the game is running, show the current time
                GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 365, 130, 40), "Your Time Is");
                GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 350, 20, 30), ((int)elapsedTime).ToString());
        }
        
    }
}
