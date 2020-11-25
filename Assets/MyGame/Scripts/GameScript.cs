using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    int max;
    int min;
    int guess;
    public Text textGuess;


    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        min = 1;
        guess = UnityEngine.Random.Range(1, 100);

    }

    void guessNext()
    {
        guess = (min + max) / 2;
        textGuess.text = guess.ToString();
    }

    public void ButtonLow()
    {
        max = guess;
        guessNext();

    }

    public void ButtonHigh()
    {
        min = guess;
        guessNext();

    }

}
