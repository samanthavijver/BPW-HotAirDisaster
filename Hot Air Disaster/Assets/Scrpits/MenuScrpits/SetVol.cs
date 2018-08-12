using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVol : MonoBehaviour {

    public AudioMixer masterMixer;          //refers to Audiomixer

	public void SetMasterLvl(float masterLvl)       //changes masterlevel on audiomixer
    {
        masterMixer.SetFloat("masterVol", masterLvl);
    }

    public void SetMusicLvl(float musicLvl)       //changes music level on audiomixer
    {
        masterMixer.SetFloat("musicVol", musicLvl);
    }

    public void SetSfxLvl(float sfxLvl)            //changes sfx level on audiomixer
    {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }

    //public void ClearVolume()
    //{
        //masterMixer.ClearFloat("musicVol");
    //}

}
