﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_ManagementPlayer : MonoBehaviour {

	public AudioSource audio;

	[Space]
	[Header("Pencil")]
	public AudioClip pencilWin;
	public AudioClip pencilPunch;
	public AudioClip pencilSpecial;
	public AudioClip pencilDies;

	[Space]
	[Header("Woody")]
	public List<AudioClip> woodyPunch;
	public AudioClip woodyDab;
	public AudioClip woodyWin;
	public AudioClip woodyLose;
	public AudioClip woodySpecial;
	public AudioClip woodyMock;
	public AudioClip woodyGag;

	//PENCIL
	public void PencilWin(){

		audio.PlayOneShot (pencilWin);

	}
	public void PencilPunch(){

		audio.PlayOneShot (pencilPunch);

	}
	public void PencilSpecial(){

		audio.PlayOneShot (pencilSpecial);

	}
	public void PencilDies(){

		audio.PlayOneShot (pencilDies);

	}

	//WOODY
	public void WoodyPunch(){

		int randomize = Random.Range (0, woodyPunch.Count);
		AudioClip punch = woodyPunch [randomize];
		audio.PlayOneShot (punch);

	}
	public void WoodyDab(){

		audio.PlayOneShot (woodyDab);

	}
	public void WoodyWin(){

		audio.PlayOneShot (woodyWin);

	}
	public void WoodyLose(){

		audio.PlayOneShot (woodyLose);

	}
	public void WoodySpecial(){

		audio.PlayOneShot (woodySpecial);

	}
	public void WoodyMock(){

		audio.PlayOneShot (woodyMock);

	}
	public void WoodyGag(){

		audio.PlayOneShot (woodyGag);

	}
}
