using UnityEngine;
using UnityEngine.UI;

public class OptionSelector : MonoBehaviour
{
    public Text feedbackText; // Reference to a UI Text element to display feedback
    public Text livesText; // Reference to a UI Text element to display remaining lives
    public int maxLives = 3; // Maximum number of lives
    private int currentLives; // Current number of lives

    void Start()
    {
        currentLives = maxLives;
        UpdateLivesUI();
    }

    // Function to handle option selection
    public void SelectOption(string option)
    {
        if (IsValidOption(option))
        {
            // Correct option selected
            feedbackText.text = "Correct option selected!";
            feedbackText.color = Color.green;
        }
        else
        {
            // Wrong option selected
            feedbackText.text = "Wrong option selected!";
            feedbackText.color = Color.red;
            ReduceLives();
        }
    }

    // Validation function to check if the selected option is correct
    private bool IsValidOption(string option)
    {
        // Implement your validation logic here
        // For demonstration purposes, let's assume "Option1" is the correct option
        return option == "Option1";
    }

    // Function to reduce lives
    private void ReduceLives()
    {
        currentLives--;
        UpdateLivesUI();

        if (currentLives <= 0)
        {
            // Game over logic here
            // For example: Show game over screen, reset level, etc.
            Debug.Log("Game Over!");
        }
    }

    // Function to update the UI displaying remaining lives
    private void UpdateLivesUI()
    {
        livesText.text = "Lives: " + currentLives.ToString();
    }
}