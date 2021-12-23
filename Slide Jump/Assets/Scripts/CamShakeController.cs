using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShakeController : MonoBehaviour
{
	public Transform camTransform;
	public float shakeDuration = 0f;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;
	public SpriteRenderer rink;

	Vector3 originalPos;

    private void Start()
    {
		Camera.main.fieldOfView = rink.bounds.size.x + Screen.height / Screen.width * 0.5f;
	}

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
	
	}
}
