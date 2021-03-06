﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DLO   {
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance = null;     //Allows other scripts to call functions from SoundManager.             
        public AudioClip[] bounceSounds;
        public AudioClip[] scoreSounds;
        public AudioClip[] restartGameSounds;
        public AudioClip[] onFireSounds;
        public AudioClip[] offFireSounds;

        private AudioSource sfxSource;                  //Drag a reference to the audio source which will play the sound effects.

        // Ensures a singleton
        void Awake()
        {
            //Check if there is already an instance of SoundManager
            if (instance == null)
                instance = this;
            //If instance already exists:
            else if (instance != this)
                Destroy(gameObject);

            //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
            DontDestroyOnLoad(gameObject);

            // Set GameObjects
            sfxSource = FindObjectOfType<AudioSource>();
        }

        // Public Functions
        #region
        //Used to play single bounce sound clips.
        public void PlayBounce()
        {
            //Randomly select sound
            int i = Random.Range(0, bounceSounds.Length - 1);

            //Set the clip of our efxSource audio source to the clip passed in as a parameter.
            sfxSource.clip = bounceSounds[i];

            //Play the clip.
            sfxSource.Play();
        }

        //Used to play single scoring sound clips.
        public void PlayScore()
        {
            //Randomly select sound
            int i = Random.Range(0, scoreSounds.Length - 1);

            //Set the clip of our efxSource audio source to the clip passed in as a parameter.
            sfxSource.clip = scoreSounds[i];

            //Play the clip.
            sfxSource.Play();
        }

        public void PlayRestartGame()
        {
            //Randomly select sound
            int i = Random.Range(0, restartGameSounds.Length - 1);

            //Set the clip of our efxSource audio source to the clip passed in as a parameter.
            sfxSource.clip = restartGameSounds[i];

            //Play the clip.
            sfxSource.Play();
        }

        public void PlayOnFire()
        {
            //Randomly select sound
            int i = Random.Range(0, onFireSounds.Length - 1);

            //Set the clip of our efxSource audio source to the clip passed in as a parameter.
            sfxSource.clip = onFireSounds[i];

            //Play the clip.
            sfxSource.Play();
        }

        public void PlayOffFire()
        {
            //Randomly select sound
            int i = Random.Range(0, offFireSounds.Length - 1);

            //Set the clip of our efxSource audio source to the clip passed in as a parameter.
            sfxSource.clip = offFireSounds[i];

            //Play the clip.
            sfxSource.Play();
        }
        #endregion
    }
}