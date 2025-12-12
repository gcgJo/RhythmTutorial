using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller beatS;

    public static GameManager instance;

    public int currentScore;
    public int Notescore = 10;
    public int Multiplier;
    public int MultiplierTracker;
    public int[] multiplierThreshold;

    public Text scoreTxt;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance= this;
        scoreTxt.text = "Score: 0";
        Multiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                beatS.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        currentScore += Notescore *Multiplier;
    }

    public void NoteMissed()
    {
        Debug.Log("Note Missed");
    }
}
