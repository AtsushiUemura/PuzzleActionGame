using UnityEngine;
using System.Collections;
using System.Reflection;

public class AudioManager : MonoBehaviour {

    [SerializeField]
    private AudioSource SEAudioSource;
    [SerializeField]
    private AudioSource BGMAudioSource;

    public AudioClip BGM = null;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void PlaySE(AudioClip se) {
        Log.Write(MethodBase.GetCurrentMethod().ToString());
        SEAudioSource.PlayOneShot(se);
    }

    public void PlayBGM(AudioClip bgm) {
        Log.Write(MethodBase.GetCurrentMethod().ToString());
        BGMAudioSource.clip = bgm;
        BGMAudioSource.Play();
    }
}
