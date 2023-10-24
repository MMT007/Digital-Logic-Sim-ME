using System.Collections;
using System.Collections.Generic;
using DLS.Simulation;
using UnityEngine;

namespace DLS.ChipCreation
{
	public class PixelDisplay : MonoBehaviour
	{
		[SerializeField] ChipDisplay chip;
		[SerializeField] MeshRenderer[] segments;

		void Start()
		{
			for (int i = 0; i < segments.Length; i++)
			{
				segments[i].sharedMaterial = Material.Instantiate(segments[i].sharedMaterial);
			}
		}

		void LateUpdate()
		{
			int index = 0;

			for(int i = 0;i < 4;i++){
				index += chip.InputPins[i].State.ToInt() * (int) Mathf.Pow(2,i);
			}

			int r = chip.InputPins[4].State.ToInt();
			int g = chip.InputPins[5].State.ToInt();
			int b = chip.InputPins[6].State.ToInt();

			Color color = new Color(r,g,b);

			if(chip.InputPins[7].State == PinState.HIGH){
				segments[index].sharedMaterial.color = color;
			}
		}
	}
}