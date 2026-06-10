using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int min;
    public int max;
    public int guess;
    public TextMeshProUGUI guessText;
    public GameObject winPanel;
    public Button higherButton;
    public Button lowerButton;
    public Button correctButton;

    private void Start()
    {
        guess = (min + max) / 2;
    }

    public void Higher()
    {
        min = guess + 1;
        guess = (min + max) / 2;
    }

    public void Lower()
    {
        max = guess - 1;
        guess = (min + max) / 2;
    }

    public void Correct()
    {
        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
        winPanel.SetActive(true);
    }

    private void Update()
    {
        guessText.text = guess.ToString();
    }
}
