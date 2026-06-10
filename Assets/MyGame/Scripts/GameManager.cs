using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int min;
    public int max;
    public int guess;
    public TextMeshProUGUI guessText;

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

    private void Update()
    {
        guessText.text = guess.ToString();
    }
}
