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
        guessText.text = guess.ToString();
    }
}
