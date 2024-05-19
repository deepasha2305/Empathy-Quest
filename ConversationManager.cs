using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public Text botText;
    public Text playerText;
    public InputField playerInput;
    public Button sendButton;

    private void Start()
    {
        sendButton.onClick.AddListener(OnSendButtonClick);
        StartConversation();
    }

    void StartConversation()
    {
        botText.text = "Eldric: Hello! How can I assist you today?";
    }

    void OnSendButtonClick()
    {
        string playerMessage = playerInput.text;
        playerText.text = "You: " + playerMessage;

        // Simple bot response logic
        string botResponse = GetBotResponse(playerMessage);
        botText.text = "Eldric: " + botResponse;

        // Clear the input field
        playerInput.text = "";
    }

    string GetBotResponse(string playerMessage)
    {
        if (playerMessage.Contains("hello") || playerMessage.Contains("hi"))
        {
            return "Hello! How can I help you today?";
        }
        else if (playerMessage.Contains("I'm here for the key."))
        {
            return "Ah! The legendary artifact of old. Not everyone can access it. Are you ready for the quests?";
        }
        else if (playerMessage.Contains("yes") || playerMessage.Contains("yes i am ready") || playerMessage.Contains("I'm ready") || playerMessage.Contains("Im ready"))
        {
            return "Alright then! May luck be with you!";
        }
        else if(playerMessage.Contains("What should I do?"))
        {
            return "Tell me if you are ready for the quests.";
        }
        else
        {
            return "I'm not sure how to respond to that. Can you ask something else?";
        }
    }
}