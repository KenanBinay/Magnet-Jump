using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShakeController : MonoBehaviour
{
	public Transform camTransform;
	public float shakeDuration = 0f;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;

	Vector3 originalPos;

	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{
		originalPos = camTransform.localPosition;
	}

	void LateUpdate()
	{
		if (Player.SpikeControl)
		{
			shakeDuration = 0.2f;
			if (shakeDuration > 0)
			{
				camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

				shakeDuration -= Time.deltaTime * decreaseFactor;
			}
		}
		else
		{
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
		/*
		if(Player.SpikeControl==1f)
		{

			if (shakeDuration > 0)
			{
				camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

				shakeDuration -= Time.deltaTime * decreaseFactor;
			}	
		}
		else if(Player.SpikeControl==0f)
		{
			StartCoroutine(ShakeCam());
		}
*/
	}
/*	private IEnumerator ShakeCam()
	{
		yield return new WaitForSeconds(0.1f);
		shakeDuration = 0f;
		camTransform.localPosition = originalPos;

	}
	*/	
}
