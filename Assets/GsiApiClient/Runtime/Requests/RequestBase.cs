using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace GsiApiClient.Runtime.Requests
{
    public abstract class RequestBase
    {
        protected static async UniTask<string> RequestGetAsync(string url)
        {
            var request = UnityWebRequest.Get(url);
            try
            {
                var result = await request.SendWebRequest();
                return result.downloadHandler.text;
            }
            catch (Exception e)
            {
                Debug.LogError($"{e}");
                return request.error;
            }
        }
    }
}