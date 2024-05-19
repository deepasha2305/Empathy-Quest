using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gconvo : MonoBehaviour
{
    private Character player;
    private Character npc;

    // Start is called before the first frame update
    void Start()
    {
        player = new Character("Player");
        npc = new Character("NPC");
        StartConversation();
    }

    // Update is called once per frame
    void Update()
    {
        // You can handle updates here if needed
    }

    private void StartConversation()
    {
        player.Speak("Hello!");
        npc.Speak("Greetings, traveler.");
        player.Speak("I'm on a quest to find the lost artifact.");
        npc.Speak("Ah, the legendary artifact of old. It is said to be hidden deep within the Forbidden Forest.");
        player.Speak("The Forbidden Forest? That sounds dangerous.");
        npc.Speak("Indeed, it is fraught with peril. But if you are brave enough, you may find what you seek.");
        player.Speak("Thank you for the information. I'll head there right away.");
        npc.Speak("Farewell, and may luck be on your side.");
    }
}

public class Character
{
    public string Name { get; private set; }

    public Character(string name)
    {
        Name = name;
    }

    public void Speak(string message)
    {
        Debug.Log($"{Name}: {message}");
    }
}
