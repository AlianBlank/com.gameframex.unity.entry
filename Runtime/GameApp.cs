﻿using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取游戏基础组件。
    /// </summary>
    public static BaseComponent Base
    {
        get
        {
            if (_base == null)
            {
                _base = GameEntry.GetComponent<BaseComponent>();
            }

            return _base;
        }
    }

    private static BaseComponent _base;

    /// <summary>
    /// 获取配置组件。
    /// </summary>
    public static ConfigComponent Config
    {
        get
        {
            if (_config == null)
            {
                _config = GameEntry.GetComponent<ConfigComponent>();
            }

            return _config;
        }
    }

    private static ConfigComponent _config;


    /// <summary>
    /// 获取网络组件。
    /// </summary>
    public static NetworkComponent Network
    {
        get
        {
            if (_network == null)
            {
                _network = GameEntry.GetComponent<NetworkComponent>();
            }

            return _network;
        }
    }

    private static NetworkComponent _network;

    /// <summary>
    /// 获取对象池组件。
    /// </summary>
    public static ObjectPoolComponent ObjectPool
    {
        get
        {
            if (_objectPool == null)
            {
                _objectPool = GameEntry.GetComponent<ObjectPoolComponent>();
            }

            return _objectPool;
        }
    }

    private static ObjectPoolComponent _objectPool;

    /// <summary>
    /// 获取网络组件。
    /// </summary>
    // public static WebRequestComponent WebRequest
    // {
    //     get
    //     {
    //         if (_webRequest)
    //         {
    //             _webRequest = GameEntry.GetComponent<WebRequestComponent>();
    //         }
    //
    //         return _webRequest;
    //     }
    // }
    //
    // private static WebRequestComponent _webRequest;


    /// <summary>
    /// 获取Lua组件。
    /// </summary>
    public static LuaComponent Lua
    {
        get
        {
            if (_lua == null)
            {
                _lua = GameEntry.GetComponent<LuaComponent>();
            }

            return _lua;
        }
    }

    private static LuaComponent _lua;
}