using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    Canvas canvas;
    CanvasScaler canvasScaler;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        canvasScaler = canvas.GetComponent<CanvasScaler>();

//기본 해상도 비율
        float fixedAspectRatio = 9f / 16f;

//현재 해상도 비율
        float currentAspectRatio = (float)Screen.width / (float)Screen.height;

//현재 해상도 가로 비율이 더 길 경우
        if (currentAspectRatio > fixedAspectRatio) canvasScaler.matchWidthOrHeight = 0;
//현재 해상도의 세로 비율이 더 길 경우
        else if (currentAspectRatio < fixedAspectRatio) canvasScaler.matchWidthOrHeight = 1;
    }
}