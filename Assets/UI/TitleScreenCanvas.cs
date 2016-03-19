using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleScreenCanvas : MonoBehaviour
{
    //public bool isMuted = false;
    //public GameObject muteButton;
    //public Sprite muteSprite;
    //public Sprite volumeSprite;

    public void OnStartGame()
    {
        Resolver.Instance.GetController<GameStateEngine>().ChangeGameState(GameStateEngine.States.Playing);
    }

    //public void OnMute()
    //{
    //    isMuted = !isMuted;

    //    if (isMuted)
    //    {
    //        AudioListener.volume = 0;
    //        muteButton.GetComponent<Image>().sprite = muteSprite;
    //    }
    //    else
    //    {
    //        AudioListener.volume = 1;
    //        muteButton.GetComponent<Image>().sprite = volumeSprite;
    //    }
    //}

    public void OnCredits()
    {
        Resolver.Instance.GetController<GameStateEngine>().ChangeGameState(GameStateEngine.States.Credits);
    }

}

