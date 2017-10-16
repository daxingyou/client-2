﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConst
{
    public const string GameName = "mygame";
    public const string ABExtensionName = ".assetbundle";
    public const string MetaExtensionn = ".meta";
    public const string StreamingAssets = "StreamingAssets";
    public const string NONE = "none";
    private static string assetBundlerPath = string.Empty;

    public const string SoundABDirectory = "sounds/";
    public const string CharacterModelABDirectory = "models/characters/";
    public const string EquipmentModelABDirectory = "models/equipments/";
    /// <summary>
    /// 获取ab存放路径 在移动平台ab会存放在可读写目录便于热更新
    /// </summary>
    public static string DataPath
    {
        get
        {
            string game = GameConst.GameName.ToLower();
            if (Application.isMobilePlatform)
            {
                if (assetBundlerPath == string.Empty)
                {
                    assetBundlerPath = Application.persistentDataPath + "/" + game + "/";
                }
            }
            else
            {
                if (assetBundlerPath == string.Empty)
                {
                    assetBundlerPath = Application.streamingAssetsPath+"/";
                }
            }
            return assetBundlerPath;
        }
    }
}
