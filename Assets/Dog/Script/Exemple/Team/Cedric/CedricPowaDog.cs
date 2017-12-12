using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CedricPowaDog : Dog
{
	#region Public Members

		public Rigidbody m_rigidbody;
		public AudioSource m_audioSource;
		public List<AudioClip> m_listDogSounds;

	#endregion

	#region Public void
 	public override void Bark(float volume, float frequence)
    {
        if(volume<0.5f && volume>0f){
            Debug.Log("Wouf, Wouff!");
            m_audioSource.clip = m_listDogSounds[0];
            m_audioSource.Play();
        }else if (volume > 0.5f && volume<1f){
            Debug.Log("WOUF wouf!");
            m_audioSource.clip = m_listDogSounds[1];
            m_audioSource.Play();
        }else if(volume>1){
            Debug.Log("WOUOUOUOUOUOUOUFHFHFFHFFF");
            m_audioSource.clip = m_listDogSounds[2];
            m_audioSource.Play();
        }else{
            Debug.LogWarning("No Bark o_O");
        }
    }

    public override void Jump(float heighCm)
    {
    	m_rigidbody.AddForce(heighCm * Vector3.up * 0.01f, ForceMode.Impulse);
    }

	#endregion

	#region System

		void Start ()
		{
			
		}
	
		void Update ()
		{
			
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

	#endregion
}
