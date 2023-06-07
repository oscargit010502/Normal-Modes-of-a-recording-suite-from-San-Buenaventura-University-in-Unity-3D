using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public AudioSource audio42Hz;
    public AudioSource audio55_3Hz;
    public AudioSource audio63Hz;
    public AudioSource audio68_9Hz;
    public AudioSource audio82_98Hz;
    public AudioSource audio98_5Hz;
    public AudioSource audio104Hz;
    public AudioSource audio110Hz;
    public AudioSource audio115Hz;
    public AudioSource audio126Hz;
    public AudioSource audio138Hz;

    public PositionGrid cellx;
    public PositionGrid cellz;

    public float fadeDuration = 1.0f;
    public float targetVolume = 0.8f;

    private float initialVolume;
    private float currentVolume;
    private float fadeTimer;

    private bool fadingIn;
    private bool fadingOut;

    public Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        initialVolume = 0.3f;
        currentVolume = initialVolume;
        fadeTimer = 0.0f;

        fadingIn = false;
        fadingOut = false;

        cellx = GetComponent<PositionGrid>();
        cellz = GetComponent<PositionGrid>();
    }


    // Update is called once per frame
    void Update()
    {
        int valorx = cellx.GetMycellX();
        int valorz = cellx.GetMycellZ();
        //Debug.Log("value x: "+ valorx + "value z" + valorz);
        if (audio42Hz.isPlaying)
        {
            if (valorx == 1 && valorz == 1 || valorx == 2 && valorz == 1 || valorx == 1 && valorz == 2 || valorx == 2 && valorz == 2
                || valorx == 9 && valorz == 1 || valorx == 8 && valorz == 1 || valorx == 8 && valorz == 2 || valorx == 9 && valorz == 2
                || valorx == 1 && valorz == 11 || valorx == 1 && valorz == 10 || valorx == 2 && valorz == 10 || valorx == 2 && valorz == 11
                || valorx == 8 && valorz == 11 || valorx == 8 && valorz == 10 || valorx == 9 && valorz == 11 || valorx == 9 && valorz == 10)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio42Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio42Hz.volume = currentVolume;
            }
        } 

        if (audio55_3Hz.isPlaying)
        {
            if (valorx == 1 && valorz == 1 || valorx == 2 && valorz == 1 || valorx == 3 && valorz == 1 || valorx == 4 && valorz == 1 || valorx == 5 && valorz == 1 || valorx == 6 && valorz == 1 || valorx == 7 && valorz == 1 || valorx == 8 && valorz == 1 || valorx == 9 && valorz == 1
                || valorx == 1 && valorz == 2 || valorx == 2 && valorz == 2 || valorx == 3 && valorz == 2 || valorx == 4 && valorz == 2 || valorx == 5 && valorz == 2 || valorx == 6 && valorz == 2 || valorx == 7 && valorz == 2 || valorx == 8 && valorz == 2 || valorx == 9 && valorz == 2
                || valorx == 1 && valorz == 5 || valorx == 2 && valorz == 5 || valorx == 3 && valorz == 5 || valorx == 4 && valorz == 5 || valorx == 5 && valorz == 5 || valorx == 6 && valorz == 5 || valorx == 7 && valorz == 5 || valorx == 8 && valorz == 5 || valorx == 9 && valorz == 5
                || valorx == 1 && valorz == 6 || valorx == 2 && valorz == 6 || valorx == 3 && valorz == 6 || valorx == 4 && valorz == 6 || valorx == 5 && valorz == 6 || valorx == 6 && valorz == 6 || valorx == 7 && valorz == 6 || valorx == 8 && valorz == 6 || valorx == 9 && valorz == 6
                || valorx == 1 && valorz == 7 || valorx == 2 && valorz == 7 || valorx == 3 && valorz == 7 || valorx == 4 && valorz == 7 || valorx == 5 && valorz == 7 || valorx == 6 && valorz == 7 || valorx == 7 && valorz == 7 || valorx == 8 && valorz == 7 || valorx == 9 && valorz == 7
                || valorx == 1 && valorz == 10 || valorx == 2 && valorz == 10 || valorx == 3 && valorz == 10 || valorx == 4 && valorz == 10 || valorx == 5 && valorz == 10 || valorx == 6 && valorz == 10 || valorx == 7 && valorz == 10 || valorx == 8 && valorz == 10 || valorx == 9 && valorz == 10
                || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 11 || valorx == 3 && valorz == 11 || valorx == 4 && valorz == 11 || valorx == 5 && valorz == 11 || valorx == 6 && valorz == 11 || valorx == 7 && valorz == 11 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio55_3Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio55_3Hz.volume = currentVolume;
            }
        }

        if (audio63Hz.isPlaying) // 63 Hz
        {
            if (valorx == 1 && valorz == 1 || valorx == 1 && valorz == 2 || valorx == 1 && valorz == 3 || valorx == 1 && valorz == 4 || valorx == 1 && valorz == 5 || valorx == 1 && valorz == 6 || valorx == 1 && valorz == 7 || valorx == 1 && valorz == 8 || valorx == 1 && valorz == 9 || valorx == 1 && valorz == 10 || valorx == 1 && valorz == 11
               || valorx == 2 && valorz == 1 || valorx == 2 && valorz == 2 || valorx == 2 && valorz == 3 || valorx == 2 && valorz == 4 || valorx == 2 && valorz == 5 || valorx == 2 && valorz == 6 || valorx == 2 && valorz == 7 || valorx == 2 && valorz == 8 || valorx == 2 && valorz == 9 || valorx == 2 && valorz == 10 || valorx == 2 && valorz == 11
               || valorx == 4 && valorz == 1 || valorx == 4 && valorz == 2 || valorx == 4 && valorz == 3 || valorx == 4 && valorz == 4 || valorx == 4 && valorz == 5 || valorx == 4 && valorz == 6 || valorx == 4 && valorz == 7 || valorx == 4 && valorz == 8 || valorx == 4 && valorz == 9 || valorx == 4 && valorz == 10 || valorx == 4 && valorz == 11
               || valorx == 5 && valorz == 1 || valorx == 5 && valorz == 2 || valorx == 5 && valorz == 3 || valorx == 5 && valorz == 4 || valorx == 5 && valorz == 5 || valorx == 5 && valorz == 6 || valorx == 5 && valorz == 7 || valorx == 5 && valorz == 8 || valorx == 5 && valorz == 9 || valorx == 5 && valorz == 10 || valorx == 5 && valorz == 11
               || valorx == 8 && valorz == 1 || valorx == 6 && valorz == 2 || valorx == 8 && valorz == 3 || valorx == 8 && valorz == 4 || valorx == 8 && valorz == 5 || valorx == 8 && valorz == 6 || valorx == 8 && valorz == 7 || valorx == 8 && valorz == 8 || valorx == 8 && valorz == 9 || valorx == 8 && valorz == 10 || valorx == 8 && valorz == 11
               || valorx == 9 && valorz == 1 || valorx == 4 && valorz == 2 || valorx == 9 && valorz == 3 || valorx == 9 && valorz == 4 || valorx == 9 && valorz == 5 || valorx == 9 && valorz == 6 || valorx == 9 && valorz == 7 || valorx == 9 && valorz == 8 || valorx == 9 && valorz == 9 || valorx == 9 && valorz == 10 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio63Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio63Hz.volume = currentVolume;
            }
        }

        if (audio68_9Hz.isPlaying)
        {
            if (valorx == 1 && valorz == 1 || valorx == 1 && valorz == 2 || valorx == 2 && valorz == 1 || valorx == 2 && valorz == 2
             || valorx == 4 && valorz == 1 || valorx == 4 && valorz == 2 || valorx == 5 && valorz == 1 || valorx == 5 && valorz == 2
             || valorx == 8 && valorz == 1 || valorx == 8 && valorz == 2 || valorx == 9 && valorz == 1 || valorx == 9 && valorz == 2
             || valorx == 1 && valorz == 10 || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 10 || valorx == 2 && valorz == 11
             || valorx == 4 && valorz == 10 || valorx == 4 && valorz == 11 || valorx == 5 && valorz == 10 || valorx == 5 && valorz == 11
             || valorx == 8 && valorz == 10 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 10 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio68_9Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio68_9Hz.volume = currentVolume;
            }
        }

        if (audio82_98Hz.isPlaying)
        {
            if (valorx == 1 && valorz == 1 || valorx == 2 && valorz == 1 || valorx == 3 && valorz == 1 || valorx == 4 && valorz == 1 || valorx == 5 && valorz == 1 || valorx == 6 && valorz == 1 || valorx == 7 && valorz == 1 || valorx == 8 && valorz == 1 || valorx == 9 && valorz == 1
                || valorx == 1 && valorz == 2 || valorx == 2 && valorz == 2 || valorx == 3 && valorz == 2 || valorx == 4 && valorz == 2 || valorx == 5 && valorz == 2 || valorx == 6 && valorz == 2 || valorx == 7 && valorz == 2 || valorx == 8 && valorz == 2 || valorx == 9 && valorz == 2
                || valorx == 1 && valorz == 4 || valorx == 2 && valorz == 4 || valorx == 3 && valorz == 4 || valorx == 4 && valorz == 4 || valorx == 5 && valorz == 4 || valorx == 6 && valorz == 4 || valorx == 7 && valorz == 4 || valorx == 8 && valorz == 4 || valorx == 9 && valorz == 4
                || valorx == 1 && valorz == 5 || valorx == 2 && valorz == 5 || valorx == 3 && valorz == 5 || valorx == 4 && valorz == 5 || valorx == 5 && valorz == 5 || valorx == 6 && valorz == 5 || valorx == 7 && valorz == 5 || valorx == 8 && valorz == 5 || valorx == 9 && valorz == 5
                || valorx == 1 && valorz == 5 || valorx == 2 && valorz == 5 || valorx == 3 && valorz == 5 || valorx == 4 && valorz == 5 || valorx == 5 && valorz == 5 || valorx == 6 && valorz == 5 || valorx == 7 && valorz == 5 || valorx == 8 && valorz == 5 || valorx == 9 && valorz == 5
                || valorx == 1 && valorz == 7 || valorx == 2 && valorz == 7 || valorx == 3 && valorz == 7 || valorx == 4 && valorz == 7 || valorx == 5 && valorz == 7 || valorx == 6 && valorz == 7 || valorx == 7 && valorz == 7 || valorx == 8 && valorz == 7 || valorx == 9 && valorz == 7
                || valorx == 1 && valorz == 8 || valorx == 2 && valorz == 8 || valorx == 3 && valorz == 8 || valorx == 4 && valorz == 8 || valorx == 5 && valorz == 8 || valorx == 6 && valorz == 8 || valorx == 7 && valorz == 8 || valorx == 8 && valorz == 8|| valorx == 9 && valorz == 8
                || valorx == 1 && valorz == 10 || valorx == 2 && valorz == 10 || valorx == 3 && valorz == 10 || valorx == 4 && valorz == 10 || valorx == 5 && valorz == 10 || valorx == 6 && valorz == 10 || valorx == 7 && valorz == 10 || valorx == 8 && valorz == 10 || valorx == 9 && valorz == 10
                || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 11 || valorx == 3 && valorz == 11 || valorx == 4 && valorz == 11 || valorx == 5 && valorz == 11 || valorx == 6 && valorz == 11 || valorx == 7 && valorz == 11 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio82_98Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio82_98Hz.volume = currentVolume;
            }
        }

        if (audio98_5Hz.isPlaying)
        {
            if (valorx == 1 && valorz == 1 || valorx == 1 && valorz == 2 
             || valorx == 3 && valorz == 1 || valorx == 3 && valorz == 2 
             || valorx == 6 && valorz == 1 || valorx == 6 && valorz == 2 
             || valorx == 9 && valorz == 1 || valorx == 9 && valorz == 2
             || valorx == 1 && valorz == 10 || valorx == 1 && valorz == 11 
             || valorx == 3 && valorz == 10 || valorx == 3 && valorz == 11
             || valorx == 6 && valorz == 10 || valorx == 6 && valorz == 11 
             || valorx == 9 && valorz == 10 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio98_5Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio98_5Hz.volume = currentVolume;
            }
        }

        if (audio104Hz.isPlaying) // 104 Hz
        {
            if (valorx == 1 && valorz == 1 || valorx == 1 && valorz == 2 || valorx == 2 && valorz == 1 || valorx == 2 && valorz == 2
             || valorx == 4 && valorz == 1 || valorx == 4 && valorz == 2 || valorx == 5 && valorz == 1 || valorx == 5 && valorz == 2
             || valorx == 8 && valorz == 1 || valorx == 8 && valorz == 2 || valorx == 9 && valorz == 1 || valorx == 9 && valorz == 2
             || valorx == 1 && valorz == 4 || valorx == 1 && valorz == 5 || valorx == 2 && valorz == 4 || valorx == 2 && valorz == 5
             || valorx == 4 && valorz == 4 || valorx == 4 && valorz == 5 || valorx == 5 && valorz == 4 || valorx == 5 && valorz == 5
             || valorx == 8 && valorz == 4 || valorx == 8 && valorz == 5 || valorx == 9 && valorz == 4 || valorx == 5 && valorz == 5
             || valorx == 1 && valorz == 7 || valorx == 1 && valorz == 8 || valorx == 2 && valorz == 7 || valorx == 2 && valorz == 8
             || valorx == 4 && valorz == 7 || valorx == 4 && valorz == 8 || valorx == 5 && valorz == 7 || valorx == 5 && valorz == 8
             || valorx == 8 && valorz == 7 || valorx == 8 && valorz == 8 || valorx == 9 && valorz == 7 || valorx == 5 && valorz == 8
             || valorx == 1 && valorz == 10 || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 10 || valorx == 2 && valorz == 11
             || valorx == 4 && valorz == 10 || valorx == 4 && valorz == 11 || valorx == 5 && valorz == 10 || valorx == 5 && valorz == 11
             || valorx == 8 && valorz == 10 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 10 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio104Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio104Hz.volume = currentVolume;
            }
        }

        if (audio110Hz.isPlaying)  // 110 Hz
        {
            if (valorx == 1 && valorz == 1 || valorx == 2 && valorz == 1 || valorx == 3 && valorz == 1 || valorx == 4 && valorz == 1 || valorx == 5 && valorz == 1 || valorx == 6 && valorz == 1 || valorx == 7 && valorz == 1 || valorx == 8 && valorz == 1 || valorx == 9 && valorz == 1
                || valorx == 1 && valorz == 3 || valorx == 2 && valorz == 3 || valorx == 3 && valorz == 3 || valorx == 4 && valorz == 3 || valorx == 5 && valorz == 3 || valorx == 6 && valorz == 3 || valorx == 7 && valorz == 3 || valorx == 8 && valorz == 3 || valorx == 9 && valorz == 3
                || valorx == 1 && valorz == 6 || valorx == 2 && valorz == 6 || valorx == 3 && valorz == 6 || valorx == 4 && valorz == 6 || valorx == 5 && valorz == 6 || valorx == 6 && valorz == 6 || valorx == 7 && valorz == 6 || valorx == 8 && valorz == 6 || valorx == 9 && valorz == 6
                || valorx == 1 && valorz == 9 || valorx == 2 && valorz == 9 || valorx == 3 && valorz == 9 || valorx == 4 && valorz == 9 || valorx == 5 && valorz == 9 || valorx == 6 && valorz == 9 || valorx == 7 && valorz == 9 || valorx == 8 && valorz == 9 || valorx == 9 && valorz == 9
                || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 11 || valorx == 3 && valorz == 11 || valorx == 4 && valorz == 11 || valorx == 5 && valorz == 11 || valorx == 6 && valorz == 11 || valorx == 7 && valorz == 11 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio110Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio110Hz.volume = currentVolume;
            }
        }

        if (audio115Hz.isPlaying)  // 115 Hz
        {
            if (valorx == 1 && valorz == 1 || valorx == 2 && valorz == 1 || valorx == 8 && valorz == 1 || valorx == 9 && valorz == 1
                || valorx == 1 && valorz == 3 || valorx == 2 && valorz == 3 || valorx == 8 && valorz == 3 || valorx == 9 && valorz == 3
                || valorx == 1 && valorz == 6 || valorx == 2 && valorz == 6 || valorx == 8 && valorz == 6 || valorx == 9 && valorz == 6
                || valorx == 1 && valorz == 9 || valorx == 2 && valorz == 9 || valorx == 8 && valorz == 9 || valorx == 9 && valorz == 9
                || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 11 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio115Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio115Hz.volume = currentVolume;
            }
        }

        if (audio126Hz.isPlaying) // 126 Hz
        {
            if (valorx == 1 && valorz == 1 || valorx == 1 && valorz == 2 || valorx == 1 && valorz == 3 || valorx == 1 && valorz == 4 || valorx == 1 && valorz == 5 || valorx == 1 && valorz == 6 || valorx == 1 && valorz == 7 || valorx == 1 && valorz == 8 || valorx == 1 && valorz == 9 || valorx == 1 && valorz == 10 || valorx == 1 && valorz == 11
               || valorx == 3 && valorz == 1 || valorx == 3 && valorz == 2 || valorx == 3 && valorz == 3 || valorx == 3 && valorz == 4 || valorx == 3 && valorz == 5 || valorx == 3 && valorz == 6 || valorx == 3 && valorz == 7 || valorx == 3 && valorz == 8 || valorx == 3 && valorz == 9 || valorx == 3 && valorz == 10 || valorx == 3 && valorz == 11
               || valorx == 5 && valorz == 1 || valorx == 5 && valorz == 2 || valorx == 5 && valorz == 3 || valorx == 5 && valorz == 4 || valorx == 5 && valorz == 5 || valorx == 5 && valorz == 6 || valorx == 5 && valorz == 7 || valorx == 5 && valorz == 8 || valorx == 5 && valorz == 9 || valorx == 5 && valorz == 10 || valorx == 5 && valorz == 11
               || valorx == 7 && valorz == 1 || valorx == 7 && valorz == 2 || valorx == 7 && valorz == 3 || valorx == 7 && valorz == 4 || valorx == 7 && valorz == 5 || valorx == 7 && valorz == 6 || valorx == 7 && valorz == 7 || valorx == 7 && valorz == 8 || valorx == 7 && valorz == 9 || valorx == 7 && valorz == 10 || valorx == 7 && valorz == 11
               || valorx == 9 && valorz == 1 || valorx == 9 && valorz == 2 || valorx == 9 && valorz == 3 || valorx == 9 && valorz == 4 || valorx == 9 && valorz == 5 || valorx == 9 && valorz == 6 || valorx == 9 && valorz == 7 || valorx == 9 && valorz == 8 || valorx == 9 && valorz == 9 || valorx == 9 && valorz == 10 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio126Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio126Hz.volume = currentVolume;
            }
        }

        if (audio138Hz.isPlaying)  // 138 Hz
        {
            if (valorx == 1 && valorz == 1 || valorx == 2 && valorz == 1 || valorx == 3 && valorz == 1 || valorx == 4 && valorz == 1 || valorx == 5 && valorz == 1 || valorx == 6 && valorz == 1 || valorx == 7 && valorz == 1 || valorx == 8 && valorz == 1 || valorx == 9 && valorz == 1
                || valorx == 1 && valorz == 3 || valorx == 2 && valorz == 3 || valorx == 3 && valorz == 3 || valorx == 4 && valorz == 3 || valorx == 5 && valorz == 3 || valorx == 6 && valorz == 3 || valorx == 7 && valorz == 3 || valorx == 8 && valorz == 3 || valorx == 9 && valorz == 3
                || valorx == 1 && valorz == 5 || valorx == 2 && valorz == 5 || valorx == 3 && valorz == 5 || valorx == 4 && valorz == 5 || valorx == 5 && valorz == 5 || valorx == 6 && valorz == 5 || valorx == 7 && valorz == 5 || valorx == 8 && valorz == 5 || valorx == 9 && valorz == 5
                || valorx == 1 && valorz == 7 || valorx == 2 && valorz == 7 || valorx == 3 && valorz == 7 || valorx == 4 && valorz == 7 || valorx == 5 && valorz == 7 || valorx == 6 && valorz == 7 || valorx == 7 && valorz == 7 || valorx == 8 && valorz == 7 || valorx == 9 && valorz == 7
                || valorx == 1 && valorz == 9 || valorx == 2 && valorz == 9 || valorx == 3 && valorz == 9 || valorx == 4 && valorz == 9 || valorx == 5 && valorz == 9 || valorx == 6 && valorz == 9 || valorx == 7 && valorz == 9 || valorx == 8 && valorz == 9 || valorx == 9 && valorz == 9
                || valorx == 1 && valorz == 11 || valorx == 2 && valorz == 11 || valorx == 3 && valorz == 11 || valorx == 4 && valorz == 11 || valorx == 5 && valorz == 11 || valorx == 6 && valorz == 11 || valorx == 7 && valorz == 11 || valorx == 8 && valorz == 11 || valorx == 9 && valorz == 11)
            {
                if (!fadingIn)
                {
                    fadingIn = true;
                    fadingOut = false;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(initialVolume, targetVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio138Hz.volume = currentVolume;

                Debug.Log("new volume applied");
            }
            else
            {
                if (!fadingOut)
                {
                    fadingIn = false;
                    fadingOut = true;
                    fadeTimer = 0.0f;
                }

                fadeTimer += Time.deltaTime;

                // Calculate the new volume based on the fade timer
                currentVolume = Mathf.Lerp(targetVolume, initialVolume, fadeTimer / fadeDuration);

                // Apply the new volume to the audio source
                audio138Hz.volume = currentVolume;
            }
        }
    }
}


