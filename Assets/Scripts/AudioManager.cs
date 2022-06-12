using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour{

    public enum SoundEffect{
        Fire1, Fire2, Fire3, Jump, BackgroundMusic
    }

    public AudioSource fire1Effect;
    public AudioSource fire2Effect;
    public AudioSource fire3Effect;
    public AudioSource jumpEffect;
    public AudioSource backgroundMusic;

    public static AudioManager Instance;

    private void Awake(){
		if (Instance == null){
			Instance = this;
		}

		else if (Instance != this){
			Destroy(gameObject);
		}
    }

    public void PlaySoundEffect(SoundEffect type){

        switch(type){
            case SoundEffect.Fire1:
                fire1Effect.Play();
                break;
            case SoundEffect.Fire2:
                fire2Effect.Play();
                break;
            case SoundEffect.Fire3:
                fire3Effect.Play();
                break;
            case SoundEffect.Jump:
                jumpEffect.Play();
                break;
            case SoundEffect.BackgroundMusic:
                backgroundMusic.Play();
                break;
        }
    }
}
