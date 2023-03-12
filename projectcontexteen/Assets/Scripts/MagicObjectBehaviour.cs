using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using UnityEngine.UI;
using TMPro;

public class MagicObjectBehaviour : MonoBehaviour
{
	public GameObject InteractiveArtHUD;
	public GameObject InteractiveDesignHUD;
	public GameObject InteractiveDevHUD;

	public bool[] SetValue = new bool[3];


	public SpriteRenderer sprtrndr;
	public Sprite[] ArtistImages;

	

	private void Start()
	{
		InteractiveArtHUD.SetActive(false);
		InteractiveDesignHUD.SetActive(false);
		InteractiveDevHUD.SetActive(false);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Artist"))
		{
			if (SetValue[0])
			{
				InteractiveArtHUD.SetActive(true);
			}
		}

		if (collision.CompareTag("Design"))
		{
			if (SetValue[1])
			{
				InteractiveDesignHUD.SetActive(true);
			}
		}

		if (collision.CompareTag("Development"))
		{
			if (SetValue[2])
			{
				InteractiveDevHUD.SetActive(true);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.CompareTag("Artist"))
		{
			if (SetValue[0])
			{
				InteractiveArtHUD.SetActive(false);
			}
		}

		if (collision.CompareTag("Design"))
		{
			if (SetValue[1])
			{
				InteractiveDesignHUD.SetActive(false);
			}
		}

		if (collision.CompareTag("Development"))
		{
			if (SetValue[2])
			{
				InteractiveDevHUD.SetActive(false);
			}
		}

	}

	public void SetArt1()
	{
		sprtrndr.sprite = ArtistImages[0];
		SetValue[0] = false;
	}

	public void SetArt2()
	{
		sprtrndr.sprite = ArtistImages[1];
		SetValue[0] = false;
	}

	public void SetArt3()
	{
		sprtrndr.sprite = ArtistImages[2];
		SetValue[0] = false;
	}

	public void SetDesign1()
	{
		SetValue[1] = false;
	}

	public void SetDesign2()
	{
		SetValue[1] = false;
	}

	public void SetDesign3()
	{
		SetValue[1] = false;
	}

	public void SetDev1()
	{
		SetValue[2] = false;
	}

	public void SetDev2()
	{
		SetValue[2] = false;
	}

	public void SetDev3()
	{
		SetValue[2] = false;
	}


}
