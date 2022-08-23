using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace GsiApiClient.Runtime.Requests
{
    public abstract class RequestBase
    {
        private readonly int _requestCapacity;
        private readonly int _requestInterval;
        private int _requestCount = 0;

        protected RequestBase()
        {
            _requestCapacity = 0;
            _requestInterval = 0; 
        }

        protected RequestBase(int requestCapacity, int requestInterval)
        {
            _requestCapacity = requestCapacity;
            _requestInterval = requestInterval;
        }

        protected async UniTask<(bool ok, string json)> RequestGetAsync(
            string url,
            int retryLimit = 0,
            int retryInterval = 0,
            CancellationToken ct = default)
        {
            for (var i = 0; i <= retryLimit; i++)
            {
                await UniTask.WaitUntil(() => _requestCount < _requestCapacity, cancellationToken: ct);
                try
                {
                    _requestCount++;
                    var request = await UnityWebRequest.Get(url).SendWebRequest().WithCancellation(ct);
                    return (true, request.downloadHandler.text);
                }
                catch (UnityWebRequestException e)
                {
                    if (e.ResponseCode == 503L)
                    {
                        Debug.Log($"Retry Request {i + 1}");
                        await UniTask.Delay(TimeSpan.FromSeconds(retryInterval), cancellationToken: ct);
                    }
                }
                finally
                {
                    IntervalTask();
                }
            }

            return (false, null);
        }

        private void IntervalTask(CancellationToken ct = default)
        {
            try
            {
                UniTask.Delay(TimeSpan.FromSeconds(_requestInterval), cancellationToken: ct)
                    .ContinueWith(() => _requestCount--)
                    .Forget();
            }
            catch (OperationCanceledException)
            {
                Debug.Log("Interval Cancelled");
                _requestCount--;
            }
        }
    }
}